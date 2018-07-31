using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class OS
    {
        private static OS instance;

        public string Name { get; set; }

        protected OS(string name)
        {
            Name = name;
        }

        public static OS GetOs(string name)
        {
            if (instance == null)
                instance = new OS(name);

            return instance;
        }
    }
}
