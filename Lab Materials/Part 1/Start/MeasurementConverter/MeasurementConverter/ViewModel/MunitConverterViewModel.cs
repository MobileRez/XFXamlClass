using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MeasurementConverter.Helper;
using Xamarin.Forms;

namespace MeasurementConverter.ViewModel
{
    public enum Munits
    {
        Kilometer,
        Meter,
        Centimeter,
        Millimeter,
        Mile,
        Yard,
        Foot,
        Inch
    }

    class MunitConverterViewModel : Helper.ViewModel
    {

        public ICommand DoConvertCommand { get; set; }


        private string _startingMeasurement = string.Empty;

        public string StartEntry
        {
            get { return _startingMeasurement; }
            set
            {
                if (_startingMeasurement == value) return;
                _startingMeasurement = value;
                RaisePropertyChanged(nameof(StartEntry));
            }
        }

        private string _convertedMeasurement = string.Empty;
        private int _startUnit;
        private int _endUnit;

        public string ConvertedMeasurement
        {
            get { return _convertedMeasurement; }
            set
            {
                if (_convertedMeasurement == value) return;
                _convertedMeasurement = value;
                RaisePropertyChanged();
            }
        }

        public MunitConverterViewModel()
        {
            DoConvertCommand = new Command(DoConverstion);
        }


        public string StartingMeasurement
        {
            get { return _startingMeasurement; }
            set { _convertedMeasurement = value; }
        }

        public int StartUnit
        {
            get { return _startUnit; }
            set
            {
                if (value == _startUnit)
                    return;

                _startUnit = value;
                RaisePropertyChanged();
            }
        }

        public int EndUnit

        {
            get { return _endUnit; }
            set
            {
                if (value == _endUnit)
                    return;


                _endUnit = value;
                RaisePropertyChanged();
            }
        }


        private void DoConverstion()
        {
            //perform the conversion

            double result;

            result = MunitConverter.UnitConverter.Convert(Convert.ToDouble(StartingMeasurement), (MunitConverter.DistanceUnits)StartUnit,
                (MunitConverter.DistanceUnits)EndUnit);

            ConvertedMeasurement = result.ToString();
        }
    }
}
