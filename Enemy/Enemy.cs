using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaBattle
{
    public class Enemy
    {

        public static Random rnd = new Random();
        public static int coordx = 1, coordy = 1;
        //public static bool IsShipDamaged = false;
        public static bool IsShipFound = false, IsVectorRandom = true, Initiative = true, CanShoot = false;
        public static int RandomMove = -1;
        public static int x, y, oldx, oldy, tries = 0, activex, activey;



        public static void Attack(Sea FriendlySea, DataGridView dataGridView1)
        {
            Initiative = true;
            do
            {
                if (IsShipFound == false)
                {
                    do
                    {
                        coordx = rnd.Next(10);
                        coordy = rnd.Next(10);
                        x = coordx;
                        y = coordy;
                        oldx = x;
                        oldy = y;
                        IsVectorRandom = true;

                    }
                    while (!Sea.CheckCanShoot(coordx, coordy, FriendlySea));
                    if (Sea.Shot(oldx, oldy, FriendlySea))
                    {
                        Initiative = true;
                        if (FriendlySea.Cells[coordx, coordy].ship.Health != 0)
                        {
                            IsShipFound = true;
                        }
                    }
                    else Initiative = false;
                }

                if (Initiative == true && IsShipFound == true && FriendlySea.Cells[coordx, coordy].ship.Size != 1)
                {
                    CanShoot = false;
                    oldx = x;
                    oldy = y;
                    while (!CanShoot)
                    {
                        if (tries == 15)
                        {
                            IsVectorRandom = false;
                            tries = 0;
                            IsShipFound = false;
                            do
                            {
                                coordx = rnd.Next(10);
                                coordy = rnd.Next(10);
                                x = coordx;
                                y = coordy;
                                oldx = x;
                                oldy = y;

                            }
                            while (!Sea.CheckCanShoot(coordx, coordy, FriendlySea));
                            CanShoot = true;
                        }
                        if (IsVectorRandom)
                        { RandomMove = rnd.Next(4); }
                        switch (RandomMove)
                        {
                            case 0:
                                tries++;
                                if (Sea.CheckCanShoot(coordx, y + 1, FriendlySea))
                                {
                                    y++;
                                    CanShoot = true;
                                    if (Sea.CheckShot(coordx, y, FriendlySea))
                                    {
                                        RandomMove = 0;
                                        IsVectorRandom = false;
                                    }
                                }
                                break;
                            case 1:
                                tries++;
                                if (Sea.CheckCanShoot(coordx, y - 1, FriendlySea))
                                {
                                    y--;
                                    CanShoot = true;
                                    if (Sea.CheckShot(coordx, y, FriendlySea))
                                    {
                                        RandomMove = 1;
                                        IsVectorRandom = false;
                                    }
                                }
                                break;
                            case 2:
                                tries++;
                                if (Sea.CheckCanShoot(x + 1, coordy, FriendlySea))
                                {
                                    x++;
                                    CanShoot = true;
                                    if (Sea.CheckShot(x, coordy, FriendlySea))
                                    {
                                        RandomMove = 2;
                                        IsVectorRandom = false;
                                    }
                                }
                                break;
                            case 3:
                                tries++;
                                if (Sea.CheckCanShoot(x - 1, coordy, FriendlySea))
                                {
                                    x--;
                                    CanShoot = true;
                                    if (Sea.CheckShot(x, coordy, FriendlySea))
                                    {
                                        RandomMove = 3;
                                        IsVectorRandom = false;
                                    }
                                }
                                break;
                        }
                    }
                    oldx = x;
                    oldy = y;
                    if (!Sea.CheckShot(x, y, FriendlySea))
                    {
                        x = coordx;
                        y = coordy;
                    }
                }
                 if (tries == 15) tries = 0;

                if (Initiative == true && Sea.CheckShot(oldx, oldy, FriendlySea) && FriendlySea.Cells[oldx, oldy].ship.Health == 1)
                {
                    IsShipFound = false;
                }
                if (Initiative == true && Sea.CheckShot(oldx, oldy, FriendlySea) && FriendlySea.Cells[oldx, oldy].ship.Health > 1)
                {
                    Initiative = true;
                }

                if (Initiative == true && !Sea.Shot(oldx, oldy, FriendlySea))
                {
                    Initiative = false;
                    if (!IsVectorRandom)
                    {
                        switch (RandomMove)
                        {
                            case 0:
                                x = coordx;
                                y = coordy;
                                RandomMove = 1;
                                break;
                            case 1:
                                x = coordx;
                                y = coordy;
                                RandomMove = 0;
                                break;
                            case 2:
                                x = coordx;
                                y = coordy;
                                RandomMove = 3;
                                break;
                            case 3:
                                x = coordx;
                                y = coordy;
                                RandomMove = 2;
                                break;
                        }
                    }
                }
            }
            while (Initiative == true && FriendlySea.ShipsCount > 0);
        }

        public static void UpdateActiveCell(DataGridView data)
        {
            data.Rows[activex].Cells[activey].Style.SelectionBackColor = data.Rows[activex].Cells[activey].Style.BackColor;
        }

        public static void SetActiveCell(int coordx, int coordy)
        {
            activex = coordx;
            activey = coordy;
        }
    }
}