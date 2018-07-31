using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Director
    {
        public House BuildHouse(HouseBuilder builder)
        {
            builder.CreateHouse();
            builder.SetDoor();
            builder.SetWalls();
            builder.SetWindows();

            return builder.House;
        }
    }
}
