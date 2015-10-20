using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Phoneword.Core;

namespace Toolbox.ViewModel
{

    public class MunitConverterViewModel : Helper.ViewModel
    {
        DelegateCommand _convertCommand;

        public ICommand ConvertCommand
        {
            get {return _convertCommand; }
        }

        private string _startingMeasurement = string.Empty;

        public string StartEntry
        {
            get { return _startingMeasurement; }
            set
            {
                if (_startingMeasurement != value)
                {
                    _startingMeasurement = value;
                    RaisePropertyChanged("StartEntry");
                    _convertCommand.RaiseCanExecuteChanged();
                }
            }
        }

        private string _convertedMeasurement = string.Empty;

        public string ConvertedMeasurement
        {
            get { return _convertedMeasurement; }
            set {
                if (_convertedMeasurement != value)
                {
                    _convertedMeasurement = value;
                    RaisePropertyChanged(ConvertedMeasurement);
                }
            }
        }

        public MunitConverterViewModel()
        {
            _convertCommand = new DelegateCommand(DoConverstion, () => !String.IsNullOrEmpty(StartEntry));
        }


        public string StartingMeasurement
        {
            get { return _startingMeasurement; }
            set { _convertedMeasurement = value; }
        }

        private void DoConverstion()
        {
            //perform the conversion
            ConvertedMeasurement = 

        }
    }
}
