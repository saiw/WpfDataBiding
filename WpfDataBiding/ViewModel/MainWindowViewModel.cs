using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDataBiding.ViewModel
{
    public class MainWindowViewModel
    {
        ObservableCollection<ViewModelBase> _viewModel;
        public ObservableCollection<ViewModelBase>ViewModels
        {
            get
            {
                if(_viewModel == null)
                { _viewModel = new ObservableCollection<ViewModelBase>(); }
                return _viewModel;
            }
        }

        public MainWindowViewModel()
        {
            OrderInfoViewModel vmOrder = new OrderInfoViewModel();
            this.ViewModels.Add(vmOrder);
        }

    }
}
