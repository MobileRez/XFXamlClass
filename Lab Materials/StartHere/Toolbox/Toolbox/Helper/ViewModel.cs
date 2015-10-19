using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Toolbox.Annotations;

namespace Toolbox.Helper
{
    //This class implments a simple view model that implments INotifyPropertyChanged
    public class ViewModel : INotifyPropertyChanged
    {
        //This occours when a property value changes.
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        //This raises the INotifyPropertyChanged.
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
