using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDataBiding.Model;

namespace WpfDataBiding.ViewModel
{
    public class OrderInfoViewModel:ViewModelBase
    {

        /// <summary>
        /// is nessasy to show the AllOrder
        /// </summary>
        public ObservableCollection<Orders> AllOrders
        {
            get;
            private set;
        }



        private IQueryable<Orders> _orderInfo;
        public IQueryable<Orders> OrderInfo
        {
            get { return _orderInfo; }
            set { _orderInfo = value; }
        }

        /// <summary>
        /// Construct 
        /// </summary>
        public OrderInfoViewModel()
        {
            var northWind = new Model.NorthWind();
            OrderInfo =(from data in northWind.Orders
                                                  select data ).Take(10);
            this.AllOrders = new ObservableCollection<Orders>(OrderInfo);

        }

        /// <summary>
        /// On Dispose
        /// </summary>
        protected override void OnDispose()
        {
            this.AllOrders.Clear();
            //base.OnDispose();
        }
    }
}
