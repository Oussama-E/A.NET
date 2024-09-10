using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfEmployee.Models;

namespace WpfEmployee.ViewModels
{
    public class EmployeeModel : INotifyPropertyChanged
    {
        private readonly Employee _employee;

        public Employee MonEmployee { get { return _employee; } }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public EmployeeModel(Employee employee)
        {
            this._employee = employee;
        }

        public string LastName 
        {
            get
            {
                return _employee.LastName;
            }
            set
            {
                _employee.LastName = value;
                OnPropertyChanged("FullName");
            }

        }
        public string FirstName 
        { 
            get
            {  
                return _employee.FirstName; 
            }
            set
            {
                _employee.FirstName = value;
                OnPropertyChanged("FullName");
            }

        }

        public string FullName
        {
            get
            {
                return _employee.LastName + " " + _employee.FirstName;
            }
        }


        public string? TitleOfCourtesy
        {
            get
            {
                return _employee.TitleOfCourtesy;
            }
            set
            {
                _employee.TitleOfCourtesy = value;
            }
        }

        public DateTime? DisplayBirthDate
        {
            get
            {
                return _employee.BirthDate;
            }
        }

        public DateTime? BirthDate
        {
            get
            {
                return _employee.BirthDate;
            }
            set
            {
                _employee.BirthDate = value;
                OnPropertyChanged("DisplayBirthDate");
            }
        }

        public DateTime? HireDate
        {
            get
            {
                return _employee.HireDate;
            }
            set
            {
                _employee.HireDate = value;
            }
        }

        


    }
}
