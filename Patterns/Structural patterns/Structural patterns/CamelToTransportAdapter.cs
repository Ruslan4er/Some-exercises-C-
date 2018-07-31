using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_patterns
{
    class CamelToTransportAdapter:ITransport
    {
        private Camel camel;

        public CamelToTransportAdapter(Camel camel)
        {
            this.camel = camel;
        }

        public void Drive()
        {
            camel.Move();
        }
    }
}
