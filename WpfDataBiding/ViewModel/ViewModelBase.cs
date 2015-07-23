using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDataBiding.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged, IDisposable
    {


        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;
        
       
        // TO DO OnPropertyChange
        protected virtual void OnPropertyChange(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            
            if( handler !=null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }


        #endregion

        #region IDisposable Members

        
        protected virtual void OnDispose()
        {}
        #endregion


        #region IDisposable Members

        public virtual void Dispose()
        {
            //throw new NotImplementedException();
        }

        #endregion
    }
}
