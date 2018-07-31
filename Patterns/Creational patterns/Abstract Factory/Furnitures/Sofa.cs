using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Furnitures
{
    public abstract class Sofa
    {
    }

    public class VictorianSofa : Sofa
    {
        public VictorianSofa()
        {
            Console.WriteLine("Софа в викторианском стиле собрана");
        }
    }

    public class ModernSofa : Sofa
    {
        public ModernSofa()
        {
            Console.WriteLine("Софа в современном стиле собрана");
        }
    }

}
