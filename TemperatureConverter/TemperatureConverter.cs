using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverterTool
{
    internal class TemperatureConverter
    {
        public int ConversionType { get; set; }    
        public float TemperatureValue { get; set; }

        public TemperatureConverter (int ConversionType, float TemperatureValue)
        {
            this.TemperatureValue = TemperatureValue;
            this.ConversionType = ConversionType;
        }

        public double ToCelsius(float TemperatureValue)
        {
            var TemperatureC = (5/9.0) * (TemperatureValue - 32);

            return Math.Round(TemperatureC, 2);
        }

        public void ToFahrenheit(float TemperatureValue)
        {

        }



    }
}
