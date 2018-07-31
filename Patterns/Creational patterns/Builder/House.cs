using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Items;

namespace Builder
{
    public class House
    {
        public Wall Walls { get; set; }
        public Window Windows { get; set; }
        public Door Door { get; set; }
    }
}
