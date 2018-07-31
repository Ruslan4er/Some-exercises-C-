using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory.Furnitures;

namespace Abstract_Factory
{
    public abstract class FurnitureFactory
    {
        public abstract Chair CreateChair();
        public abstract СoffeTable CreateСoffeTable();
        public abstract Sofa CreateSofa();
    }

    public class VictorianFurnitureFactory:FurnitureFactory
    {
        public override Chair CreateChair()
        {
            return new VictorianChair();
        }

        public override СoffeTable CreateСoffeTable()
        {
            return new VictorianСoffeTable();
        }

        public override Sofa CreateSofa()
        {
            return new VictorianSofa();
        }
    }

    public class ModernFurnitureFactory : FurnitureFactory
    {
        public override Chair CreateChair()
        {
            return new ModernChair();
        }

        public override СoffeTable CreateСoffeTable()
        {
            return new ModernСoffeTable();
        }

        public override Sofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}
