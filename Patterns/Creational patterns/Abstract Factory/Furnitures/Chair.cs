using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Furnitures
{
    public abstract class Chair
    {
    }

    public class VictorianChair : Chair
    {
        public VictorianChair()
        {
            Console.WriteLine("Кресло в викторианском стиле собрана");
        }
    }

    public class ModernChair : Chair
    {
        public ModernChair()
        {
            Console.WriteLine("Кресло в современном стиле собрана");
        }
    }
}
