using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    public class Ship
    {
        public int coordx = 0, coordy = 0;
        public int Size;
        public int orientation;
        public int Health = 0;

        public Ship(int size, int coordx, int coordy, int orientation)
        {
            Size = size;
            Health = size;
            this.orientation = orientation;
            this.coordx = coordx;
            this.coordy = coordy;
        }

        public int ShipHealth()
        {
            return Health;
        }
       
        public void ShipIsDamaged()
        {
          Health--;
        }


    }
}
