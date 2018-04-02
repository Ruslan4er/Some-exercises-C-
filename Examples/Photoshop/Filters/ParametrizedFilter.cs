using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop.Filters
{
    public abstract class ParametrizedFilter : IFilter
    {
        IParameters parameters;

        protected ParametrizedFilter(IParameters parameters)
        {
            this.parameters = parameters;
        }
        
        public ParameterInfo[] GetParameters()
        {
            return parameters.GetDescription();
        }

        public Photo Process(Photo original, double[] values)
        {
            parameters.SetValues(values);
            return Process(original, parameters);
        }

        public abstract Photo Process(Photo original, IParameters parameters);
    }
}
