using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    public class Converter
    {
        public decimal Farhenheit(decimal temperature)
        {
            return temperature * 9 / 5 + 32;
        }
    }
}
