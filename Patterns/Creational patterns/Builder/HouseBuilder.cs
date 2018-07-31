using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Items;

namespace Builder
{
    public abstract class HouseBuilder
    {
        public House House { get; private set; }

        public void CreateHouse()
        {
            House = new House();
        }

        public abstract void SetWalls();
        public abstract void SetWindows();
        public abstract void SetDoor();

    }

    public class RichHouseBuilder : HouseBuilder
    {
        public override void SetWalls()
        {
            this.House.Walls = new Wall { Type = "Бетон" };
        }

        public override void SetWindows()
        {
            this.House.Windows = new Window { Count = 2 };
        }

        public override void SetDoor()
        {
            this.House.Door = new Door { Type = "Железная" };
        }
    }

    public class CheapHouseBuilder : HouseBuilder
    {
        public override void SetWalls()
        {
            this.House.Walls = new Wall { Type = "Плохой бетон" };
        }

        public override void SetWindows()
        {
            this.House.Windows = new Window { Count = 1 };
        }

        public override void SetDoor()
        {
            this.House.Door = new Door { Type = "Деревянная" };
        }
    }
}
