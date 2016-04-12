using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasurementConverter.Helper
{
    class MuConverter
    {
        //use meters as base 

        //put # from start into meters

        //convert meters to ending value

        //public static class DistanceRule
        //{
        //     public static Dictionary<DistanceUnit> 
        //}

        public enum DistanceUnits
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

        public static class Rule
        {
            public static Dictionary<DistanceUnits, double> Rules = new Dictionary<DistanceUnits, double>()
            {
                //The values are in respect to 1 meter. 
                //Ex) 1 meter = 1000 millimeters
                [DistanceUnits.Millimeter] = 1000,
                [DistanceUnits.Centimeter] = 100,
                [DistanceUnits.Meter] = 1,
                [DistanceUnits.Kilometer] = .001,
                [DistanceUnits.Inch] = 39.3701,
                [DistanceUnits.Foot] = 3.28084,
                [DistanceUnits.Yard] = 1.09361,
                [DistanceUnits.Mile] = 0.000621371,
            };
        }

        public static class UnitConverter
        {
            public static double Convert(double valueToConvert, DistanceUnits startUnit, DistanceUnits endUnit)
            {
                //value as meters
                double meterValue = ConvertToMeter(startUnit, valueToConvert);
                //value as final unit
                double finalValue = ConvertMeterTo(endUnit, meterValue);

                return Math.Round(finalValue, 2);
            }

            private static double ConvertToMeter(DistanceUnits origUnit, double value)
            {
                if (Rule.Rules.ContainsKey(origUnit))
                {
                    return value / Rule.Rules[origUnit];
                }
                else
                {
                    throw new Exception("Invalid unit");
                }
            }

            private static double ConvertMeterTo(DistanceUnits destUnit, double value)
            {
                if (Rule.Rules.ContainsKey(destUnit))
                {
                    return value * Rule.Rules[destUnit];
                }
                else
                {
                    throw new Exception("Invalid unit");
                }
            }
        }
    }
}
