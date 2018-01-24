using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class ResourceMonitor
    {
        private int memoryLimit;

        public ResourceMonitor(int memoryLimit)
        {
            this.MemoryLimit = memoryLimit;
        }

        public int MemoryLimit
        {
            get { return memoryLimit; }
            set { memoryLimit = value; }
        }

        private bool IsMemoryLimitExceeded()
        {
            return memoryLimit > GC.GetTotalMemory(false);
        }

        public void CheckRecources(object errorMessage)
        {
            if (IsMemoryLimitExceeded())
            {
                Console.WriteLine("{0}", errorMessage);
            }
        }
       
    }
}
