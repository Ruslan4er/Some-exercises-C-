using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory.Furnitures;

namespace Abstract_Factory
{
    class Room
    {
        private Chair chair;
        private Sofa sofa;
        private СoffeTable coffeTable;

        public Room(FurnitureFactory factory)
        {
            chair = factory.CreateChair();
            sofa = factory.CreateSofa();
            coffeTable = factory.CreateСoffeTable();
        }

    }
}
