using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
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

    //public class Measurement : INotifyPropertyChanged
    //{
    //    public event PropertyChangedEventHandler PropertyChanged = delegate { };

    //    public Munits CfMunits { get; set; }
    //    public Munits CtMunits { get; set; }

    //    public int Start;

    //    public int Result;

    //    public override string ToString()
    //    {
    //        return $"Result={this.Result}";
    //    }
    //}

    class McLogic : MeasurementConverter
    {
            
    }
}
