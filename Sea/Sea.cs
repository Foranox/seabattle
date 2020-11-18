using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaBattle
{
    public class Sea
    {
        public int Size;
        public Cell[,] Cells;
        private List<Ship> Ships = new List<Ship>();
        public int ShipsCount;

        public Sea(int seasize, int shipsCount)
        {
            Size = seasize;
            ShipsCount = shipsCount;
            Cells = new Cell[seasize, seasize];

            for (int x = 0; x < seasize; x++)
            {
                for (int y = 0; y < seasize; y++)
                {
                    Cells[x, y] = new Cell();
                }
            }
        }

        public bool PlaceShip(Ship ship)
        {
            int orientation = ship.orientation;
            int coordx = ship.coordx;
            int coordy = ship.coordy;
            int size = ship.Size;
            if (IsPlacePossible(size, coordx, coordy, orientation))
            {
                Ships.Add(ship);
                if (orientation == 0)
                {
                        for (int x = coordx; x <= coordx + size - 1; x++)
                        {
                            Cells[x, coordy].AddShip(ship);
                        }
                }
                else
                {
                        for (int y = coordy; y <= coordy + size - 1; y++)
                        {
                            Cells[coordx, y].AddShip(ship);
                        }
                }
                CreateSafeZone(size, coordx, coordy, orientation);
                return true;
            }
            else
            {
                return false;

            }
        }

        Random rnd = new Random();

        public void RandomShip(int size)
        {
            int coordx = 0, coordy = 0, orientation = 0;
            bool checker = false;
            do
            {
                orientation = rnd.Next(2);
                if (orientation == 0) coordx = rnd.Next(10 - size);
                    else coordx = rnd.Next(10);
                if (orientation != 0) coordy = rnd.Next(10 - size);
                    else coordy = rnd.Next(10 - size);
                checker = IsPlacePossible(size, coordx, coordy, orientation);
            }
            while (!checker);
            Ship ship = new Ship(size, coordx, coordy, orientation);
            PlaceShip(ship);
        }

        public void CreateSafeZone(int size, int coordx, int coordy, int orientation)
        {

            if (orientation == 0)
            {
                for (int x = coordx - 1; x <= coordx + size; x++)
                {
                    for (int y = coordy - 1; y <= coordy + 1; y++)
                    {
                        try
                        {
                            if (Cells[x, y].status != (int)Cell.Status.Ship) Cells[x, y].status = (int)Cell.Status.Blocked;
                        }
                        catch
                        {
                          
                        }
                    }
                }
            }
            else
            {
                for (int x = coordx - 1; x <= coordx + 1; x++)
                {
                    for (int y = coordy - 1; y <= coordy + size; y++)
                    {
                        try
                        {
                            if (Cells[x, y].status != (int)Cell.Status.Ship) Cells[x, y].status = (int)Cell.Status.Blocked;
                        }
                        catch
                        {

                        }
                    }
                }
            }
        }

        public bool IsPlacePossible(int size, int coordx, int coordy, int orientation)
        {
            if (orientation == 0)
            {
                if (coordx + size - 1 <= 9)
                {
                    for (int x = coordx; x <= coordx + size - 1; x++)
                    {
                        if (Cells[x, coordy].IsOccupied()) return false;
                    }
                    return true;
                }
            }
            else
            {
                if (coordy + size - 1 <= 9)
                {
                    for (int y = coordy; y <= coordy + size - 1; y++)
                    {
                        if (Cells[coordx, y].IsOccupied()) return false;
                    }
                    return true;
                }
            }
            return false;
        }

        public static bool CheckCanShoot(int coordx, int coordy, Sea sea)
        {
            if ((coordx >= 0 && coordx <= 9 && coordy <= 9 && coordy >= 0) && 
                (sea.Cells[coordx, coordy].status == (int)Cell.Status.Empty || 
                sea.Cells[coordx, coordy].status == (int)Cell.Status.Blocked || 
                sea.Cells[coordx, coordy].status == (int)Cell.Status.Ship))
            {
                return true;
            }
            else return false;
        }

        public static bool Shot(int coordx, int coordy, Sea sea)
        {
            if (sea.Cells[coordx, coordy].status == (int)Cell.Status.Empty || sea.Cells[coordx, coordy].status == (int)Cell.Status.Blocked)
            {
                sea.Cells[coordx, coordy].status = (int)Cell.Status.Missed;
                return false;
            }
            else
            {       sea.Cells[coordx, coordy].status = (int)Cell.Status.Damaged;
                    sea.Cells[coordx, coordy].ship.ShipIsDamaged();
                if (sea.Cells[coordx, coordy].ship.Health == 0)
                {
                    sea.ShipsCount--;
                    if (sea.Cells[coordx, coordy].ship.orientation == 0)
                    {
                        for (int x = sea.Cells[coordx, coordy].ship.coordx - 1; x <= sea.Cells[coordx, coordy].ship.coordx + sea.Cells[coordx, coordy].ship.Size; x++)
                        {
                            for (int y = sea.Cells[coordx, coordy].ship.coordy - 1; y <= sea.Cells[coordx, coordy].ship.coordy + 1; y++)
                            {
                                try
                                {
                                    if (sea.Cells[x, y].status != (int)Cell.Status.Damaged) sea.Cells[x, y].status = (int)Cell.Status.Missed;
                                }
                                catch
                                {

                                }
                            }
                        }
                    }
                    else
                    {
                        for (int x = sea.Cells[coordx, coordy].ship.coordx - 1; x <= sea.Cells[coordx, coordy].ship.coordx + 1; x++)
                        {
                            for (int y = sea.Cells[coordx, coordy].ship.coordy - 1; y <= sea.Cells[coordx, coordy].ship.coordy + sea.Cells[coordx, coordy].ship.Size; y++)
                            {
                                try
                                {
                                    if (sea.Cells[x, y].status != (int)Cell.Status.Damaged) sea.Cells[x, y].status = (int)Cell.Status.Missed;
                                }
                                catch
                                {

                                }
                            }
                        }
                    }
                }
                return true;
            }
        }

        public static void ClearSea(Sea sea)
        {
            for(int x = 0; x<=9; x++)
                for(int y = 0; y<=9; y++)
                {
                    sea.Cells[x, y].status = (int)Cell.Status.Empty;
                }
            sea.ShipsCount = 10;    
        }

        public static bool CheckShot(int coordx, int coordy, Sea sea)
        {
            if (sea.Cells[coordx, coordy].status == (int)Cell.Status.Ship) return true;
            else return false;
        }
    }
}
