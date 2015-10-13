using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.Helper
{
    public static class MeasurementConverter
    {
        private const float Km = 1;
        private const float Cm = 1;
        private const float Mm = 1;
        private const float Mi = 1;
        private const float Yd = 1;
        private const float Ft = 1;
        private const float In = 1;

        static double TranslateMeasurement(string startingUnit, string endingUnit, double fromDistance)
        {
            //translates the measurement
            //BASE UNIT OF measurement as constants

            double toDistance = 0.0;
            

            switch (startingUnit)
            {
                case "Kilometer":
                    switch (endingUnit)
                    {
                        case "Kilometer":
                            toDistance = fromDistance;
                            break;
                        case "Meter":
                            toDistance = Math.Round(fromDistance * 1000);
                            break;
                        case "Centimeter":
                            toDistance = Math.Round(fromDistance * 100000);
                            break;
                        case "Millimeter":
                            toDistance = Math.Round(fromDistance * 1000000);
                            break;
                        case "Mile":
                            toDistance = Math.Round(fromDistance / 1.609344);
                            break;
                        case "Yard":
                            toDistance = Math.Round(fromDistance / 0.0009144);
                            break;
                        case "Foot":
                            toDistance = Math.Round(fromDistance / 0.0003048);
                            break;
                        case "Inch":
                            toDistance = Math.Round(fromDistance / 0.0000254);
                            break;
                    }
                    break;
                case "Meter":
                    switch (endingUnit)
                    {
                        case "Kilometer":
                            toDistance = Math.Round(fromDistance / 0.001);
                            break;
                        case "Meter":
                            toDistance = fromDistance;
                            break;
                        case "Centimeter":
                            toDistance = Math.Round(fromDistance * 100);
                            break;
                        case "Millimeter":
                            toDistance = Math.Round(fromDistance * 1000);
                            break;
                        case "Mile":
                            toDistance = Math.Round(fromDistance / 1609.344);
                            break;
                        case "Yard":
                            toDistance = Math.Round(fromDistance / 0.9144);
                            break;
                        case "Foot":
                            toDistance = Math.Round(fromDistance / 0.3048);
                            break;
                        case "Inch":
                            toDistance = Math.Round(fromDistance / 0.0254);
                            break;
                    }
                    break;
                case "Centimeter":
                    switch (endingUnit)
                    {
                        case "Kilometer":
                            toDistance = Math.Round(fromDistance / 100000);
                            break;
                        case "Meter":
                            toDistance = Math.Round(fromDistance / 100);
                            break;
                        case "Centimeter":
                            toDistance = fromDistance;
                            break;
                        case "Millimeter":
                            toDistance = Math.Round(fromDistance / 10);
                            break;
                        case "Mile":
                            toDistance = Math.Round(fromDistance / 160934.4);
                            break;
                        case "Yard":
                            toDistance = Math.Round(fromDistance / 91.44);
                            break;
                        case "Foot":
                            toDistance = Math.Round(fromDistance / 30.48);
                            break;
                        case "Inch":
                            toDistance = Math.Round(fromDistance / 2.54);
                            break;
                    }
                    break;
                case "Millimeter":
                    switch (endingUnit)
                    {
                        case "Kilometer":
                            toDistance = Math.Round(fromDistance / 1000000);
                            break;
                        case "Meter":
                            toDistance = Math.Round(fromDistance / 1000);
                            break;
                        case "Centimeter":
                            toDistance = Math.Round(fromDistance * 10);
                            break;
                        case "Millimeter":
                            toDistance = fromDistance;
                            break;
                        case "Mile":
                            toDistance = Math.Round(fromDistance / 1609344);
                            break;
                        case "Yard":
                            toDistance = Math.Round(fromDistance / 914.4);
                            break;
                        case "Foot":
                            toDistance = Math.Round(fromDistance / 304.8);
                            break;
                        case "Inch":
                            toDistance = Math.Round(fromDistance / 25.4);
                            break;
                    }
                    break;
                case "Mile":
                    switch (endingUnit)
                    {
                        case "Kilometer":
                            toDistance = Math.Round(fromDistance * 1.609344);
                            break;
                        case "Meter":
                            toDistance = Math.Round(fromDistance * 1609.344);
                            break;
                        case "Centimeter":
                            toDistance = Math.Round(fromDistance * 160934.4);
                            break;
                        case "Millimeter":
                            toDistance = Math.Round(fromDistance * 1609344);
                            break;
                        case "Mile":
                            toDistance = fromDistance;
                            break;
                        case "Yard":
                            toDistance = Math.Round(fromDistance / 1760);
                            break;
                        case "Foot":
                            toDistance = Math.Round(fromDistance / 5280);
                            break;
                        case "Inch":
                            toDistance = Math.Round(fromDistance / 63360);
                            break;
                    }
                    break;
                case "Yard":
                    switch (endingUnit)
                    {
                        case "Kilometer":
                            toDistance = fromDistance;
                            break;
                        case "Meter":
                            toDistance = fromDistance;
                            break;
                        case "Centimeter":
                            toDistance = fromDistance;
                            break;
                        case "Millimeter":
                            toDistance = fromDistance;
                            break;
                        case "Mile":
                            toDistance = fromDistance;
                            break;
                        case "Yard":
                            toDistance = fromDistance;
                            break;
                        case "Foot":
                            toDistance = fromDistance;
                            break;
                        case "Inch":
                            toDistance = fromDistance;
                            break;
                    }
                    break;
                case "Foot":
                    switch (endingUnit)
                    {
                        case "Kilometer":
                            toDistance = fromDistance;
                            break;
                        case "Meter":
                            toDistance = fromDistance;
                            break;
                        case "Centimeter":
                            toDistance = fromDistance;
                            break;
                        case "Millimeter":
                            toDistance = fromDistance;
                            break;
                        case "Mile":
                            toDistance = fromDistance;
                            break;
                        case "Yard":
                            toDistance = fromDistance;
                            break;
                        case "Foot":
                            toDistance = fromDistance;
                            break;
                        case "Inch":
                            toDistance = fromDistance;
                            break;
                    }
                    break;
                case "Inch":
                    switch (endingUnit)
                    {
                        case "Kilometer":
                            toDistance = fromDistance;
                            break;
                        case "Meter":
                            toDistance = fromDistance;
                            break;
                        case "Centimeter":
                            toDistance = fromDistance;
                            break;
                        case "Millimeter":
                            toDistance = fromDistance;
                            break;
                        case "Mile":
                            toDistance = fromDistance;
                            break;
                        case "Yard":
                            toDistance = fromDistance;
                            break;
                        case "Foot":
                            toDistance = fromDistance;
                            break;
                        case "Inch":
                            toDistance = fromDistance;
                            break;
                    }
                    break;
            }
            //toDistance = Math.Round(toDistance, 2);
            return toDistance;
        }
    }
}
