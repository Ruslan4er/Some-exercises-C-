using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms.PropertyGridInternal;

namespace MyPhotoshop.Filters.Parameters
{
    public class SimpleParametersHandler<TParameters> : IParameterHandler<TParameters>
        where TParameters : IParameters, new()
    {
        private static PropertyInfo[] properties;
        private static ParameterInfo[] descriptions;

        static SimpleParametersHandler()
        {
            properties = typeof(TParameters)
                .GetProperties()
                .Where(z => z.GetCustomAttributes(typeof(ParameterInfo), false).Length > 0)
                .ToArray();

            descriptions = typeof(TParameters).GetProperties()
                .Select(z => z.GetCustomAttributes(typeof(ParameterInfo), false))
                .Where(z => z.Length > 0)
                .Select(z => z[0])
                .Cast<ParameterInfo>()
                .ToArray();
        }

        
        public ParameterInfo[] GetDescription()
        {
            return descriptions;
        }

        public TParameters CreateParameters(double[] values)
        {
            var parameters = new TParameters();

            for (int i = 0; i < values.Length; i++)
                properties[i].SetValue(parameters, values[i], new object[0]);
            return parameters;
        }
    }
}
