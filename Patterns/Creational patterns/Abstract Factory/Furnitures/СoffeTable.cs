using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Furnitures
{
    public abstract class СoffeTable
    {
    }

    public class VictorianСoffeTable : СoffeTable
    {
        public VictorianСoffeTable()
        {
            Console.WriteLine("Кофейный столик в викторианском стиле собрана");
        }
    }

    public class ModernСoffeTable : СoffeTable
    {
        public ModernСoffeTable()
        {
            Console.WriteLine("Кофейный столик в современном стиле собрана");
        }
    }
}
