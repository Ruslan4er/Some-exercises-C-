using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Computer
    {

        public OS Os { get; set; }

        public void Launch(string osName)
        {
            Os = OS.GetOs("Windows 8");
        }


    }
}
