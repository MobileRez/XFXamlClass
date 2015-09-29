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

    public class MunitConverterViewModel
    {
        public Munits CfMunits { get; set; }
        public Munits CtMunits { get; set; }

    }
}
