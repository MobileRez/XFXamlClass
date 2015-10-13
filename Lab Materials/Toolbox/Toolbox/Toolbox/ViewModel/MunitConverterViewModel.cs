using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.ViewModel
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
    };

    public class MunitConverterViewModel : Helper.ViewModel
    {
        public Munits CfMunits { get; set; }
        public Munits CtMunits { get; set; }

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
