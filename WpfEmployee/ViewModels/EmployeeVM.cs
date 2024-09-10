using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApplication1.ViewModels;
using WpfEmployee.Models;

namespace WpfEmployee.ViewModels
{
    class EmployeeVM : INotifyPropertyChanged
    {
        private ObservableCollection<EmployeeModel> _EmployeesList;
        private ObservableCollection<OrderModel> _OrdersList;
        private List<string> _ListTitle;
        private NorthwindContext context = new NorthwindContext();
        private DelegateCommand _addCommand;
        private DelegateCommand _saveCommand;
        private EmployeeModel _selectedEmployee;

        public ObservableCollection<EmployeeModel> EmployeesList 
        {
            get { return _EmployeesList = _EmployeesList ?? LoadEmployeesList(); }
        }

        public ObservableCollection<OrderModel> OrdersList
        {
            get { 
                if(SelectedEmployee != null)
                    _OrdersList = LoadOrdersList();
                return _OrdersList;
                }
        }

        public List<string> ListTitle
        {
            get
            { return _ListTitle ?? LoadTitleList(); }
        }

        public EmployeeModel SelectedEmployee
        {
            get { return _selectedEmployee; }
            set { _selectedEmployee = value; OnPropertyChanged("OrdersList"); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        private ObservableCollection<EmployeeModel> LoadEmployeesList()
        {
            ObservableCollection<EmployeeModel> localCollection = new ObservableCollection<EmployeeModel>();

            foreach(var item in context.Employees)
            {
                localCollection.Add(new EmployeeModel(item));
            }

            return localCollection;
        }

        private ObservableCollection<OrderModel> LoadOrdersList()
        {
            ObservableCollection<OrderModel> localCollection = new ObservableCollection<OrderModel>();
            var query = from Order o in context.Orders
                        where (o.EmployeeId == SelectedEmployee.MonEmployee.EmployeeId)
                        orderby o.OrderDate descending
                        select o;



            int i = 0;
            foreach (var item in query)
            {
                decimal total = context.OrderDetails.Where(od => od.OrderId == item.OrderId).Sum(od => od.UnitPrice);
                localCollection.Add(new OrderModel(item, total));
                i++;
                if (i == 3) break;
            }

            return localCollection;

        }

        private List<string> LoadTitleList()
        {
            return context.Employees.Select(e => e.TitleOfCourtesy).Distinct().ToList();
        }

        public DelegateCommand AddCommand
        {
            get { return _addCommand = _addCommand ?? new DelegateCommand(NewEmployee); }
        }

        public DelegateCommand SaveCommand
        {
            get { return _saveCommand = _saveCommand ?? new DelegateCommand(SaveEmployee); }
        }

        private void NewEmployee()
        {
            MessageBox.Show("On rentre dans NewEmployee");
            Employee employeeGlobal = new Employee();
            EmployeeModel employeeModel = new EmployeeModel(employeeGlobal);
            EmployeesList.Add(employeeModel);
            SelectedEmployee = employeeModel;
        }

        private void SaveEmployee()
        {
            MessageBox.Show("On rentre dans SaveEmployee");
            Employee verif = context.Employees.Where(e => e.EmployeeId == SelectedEmployee.MonEmployee.EmployeeId).SingleOrDefault();
            if (verif == null)
            {
                context.Employees.Add(SelectedEmployee.MonEmployee);
            }
            context.SaveChanges();
            MessageBox.Show("Enregistrement effectué avec succès!");
        }


    }
}
