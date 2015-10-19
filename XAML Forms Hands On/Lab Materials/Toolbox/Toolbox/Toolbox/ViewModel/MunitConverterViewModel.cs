using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Toolbox.ViewModel
{

    public class MunitConverterViewModel : Helper.ViewModel
    {
        //DelegateCommand _conversionCommand;

        //public ICommand _conversionCommand
        //{
        //    get { return _convertedCommand; }
        //}
        

        private string _convertedMeasurement = string.Empty;

        private string _startingMeasurement = string.Empty;

        public string StartingMeasurement
        {
            get { return _startingMeasurement; }
            set { _convertedMeasurement = value; }
        }

        private void DoConverstion()
        {
            //perform the conversion

        }
    }
}
