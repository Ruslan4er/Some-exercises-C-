﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyPhotoshop.Filters;

namespace MyPhotoshop
{
    public class EmptyParameters:IParameters
    {
        public ParameterInfo[] GetDescription()
        {
            return new ParameterInfo [0];
        }

        public void SetValues(double[] values)
        {
            
        }
    }
}
