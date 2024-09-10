using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfEmployee.Models;

namespace WpfEmployee.ViewModels
{
    internal class OrderModel
    {
        private readonly Order _monOrder;
        private decimal _total = 0;

        public OrderModel(Order current, decimal total)
        {
            this._monOrder = current;
            this._total = total;
        }

        public string OrderDate
        {
           get
            {
                if(_monOrder.OrderDate.HasValue)
                    return _monOrder.OrderDate.Value.ToShortDateString();
                return "";
            }
        }

        public string OrderID
        {
            get
            {
                return _monOrder.OrderId.ToString();
            }
        }

        public string OrderTotal
        {
            get
            {
                return _total.ToString();
            }
        }
    }
}
