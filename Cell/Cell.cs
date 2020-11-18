using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    public class Cell
    { 
        public enum Status {Empty, Ship, Blocked, Missed, Damaged};
        public int status;
        public Ship ship;
        public int place;
        public int coordx, coord;



        public Cell()
        {
            status = (int)Status.Empty;  
        }

        public bool DoesShipPlaced()
        {
            if (ship != null) return true;
            else return false;
        }

        public void AddShip(Ship s)
        {
            status = (int)Status.Ship;
            ship = s;
        }

        public bool IsOccupied()
        {
            if (status != (int)Status.Empty)
                return true;
            else
                return false;
        }

    }
}
