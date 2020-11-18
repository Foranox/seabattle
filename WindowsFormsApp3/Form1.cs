using System;
using SeaBattle;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaBattle
{
    public partial class Form1 : Form
    {

        public Sea EnemySea = new Sea(10, 10);
        public Sea FriendlySea = new Sea(10, 10);
        public int orientation;
        int shipsize = 1;

        Color EmptyCell = Color.White;
        Color ShipCell = Color.LightBlue;
        Color MissCell = Color.LightGray;
        Color DamageCell = Color.Tomato;
        int Count1 = 4;
        int Count2 = 3;
        int Count3 = 2;
        int Count4 = 1;
        int TotalCount = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ShipIsHorisontal.Checked = true;
            Btn1cells.Checked = true;
            orientation = 1;
            dataGridView2.Visible = false;
            BtnNewGame.Visible = false;
            EndText.Visible = false;
            for (int i = 0; i < 9; i++)
            {
                int rowNumber1 = dataGridView1.Rows.Add();
                int rowNumber2 = dataGridView2.Rows.Add();
               
            }
        }

        public static void UpdateSea(Sea sea, DataGridView data, bool Show)
        {
            Color EmptyCell = Color.White;
            Color ShipCell = Color.LightBlue;
            Color MissCell = Color.LightGray;
            Color DamageCell = Color.Tomato;

            for (int x = 0; x < sea.Size; x++)
            {
                for (int y = 0; y < sea.Size; y++)
                {
                    switch (sea.Cells[x, y].status)
                    {
                        case 0:
                            data.Rows[x].Cells[y].Style.BackColor = EmptyCell;
                            break;
                        case 1:
                            if (Show) data.Rows[x].Cells[y].Style.BackColor = ShipCell;
                            else data.Rows[x].Cells[y].Style.BackColor = EmptyCell;
                            break;
                        case 2:
                            data.Rows[x].Cells[y].Style.BackColor = EmptyCell;
                            break;
                        case 3:
                            data.Rows[x].Cells[y].Style.BackColor = MissCell;
                            break;
                        case 4:
                            data.Rows[x].Cells[y].Style.BackColor = DamageCell;
                            break;
                        case 5:
                            data.Rows[x].Cells[y].Style.BackColor = EmptyCell;
                            break;
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int coordx = e.RowIndex;
            int coordy = e.ColumnIndex;
            if (FriendlySea.IsPlacePossible(shipsize, coordx, coordy, orientation))
            {
                Ship ship = new Ship(shipsize, coordx, coordy, orientation);
                switch (shipsize)
                {
                    case 1:
                        Count1 = CountAndPlaceShip(Count1, ships1, ship);
                        break;
                    case 2:
                        Count2 = CountAndPlaceShip(Count2, ships2, ship);
                        break;
                    case 3:
                        Count3 = CountAndPlaceShip(Count3, ships3, ship);
                        break;
                    case 4:
                        Count4 = CountAndPlaceShip(Count4, ships4, ship);
                        break;
                }
                UpdateSea(FriendlySea, dataGridView1, true);
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionBackColor = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor;
                Enemy.SetActiveCell(e.RowIndex, e.ColumnIndex);
                if (TotalCount == 10) Startgame();
            
            }

        }

        public int CountAndPlaceShip(int ShipsLeft, Label Count, Ship ship)
        {
            if (ShipsLeft - 1 >= 0)
            {
                ShipsLeft--;
                TotalCount++;
                Count.Text = Convert.ToString(ShipsLeft);
                FriendlySea.PlaceShip(ship);
                return ShipsLeft;
            }
            else return 0;
        }
        
        //Игра
        public void Startgame()
        {
            GroupBox.Visible = false;
            ShipIsHorisontal.Visible = false;
            ShipIsVertical.Visible = false;
            dataGridView2.Visible = true;
            dataGridView1.Enabled = false;
            BtnClean.Visible = false;

            for (int shipindex = 0; shipindex < EnemySea.ShipsCount; shipindex++)
            {
                switch (shipindex)
                {
                    case int n when (n >= 6):
                        EnemySea.RandomShip(1);
                        break;
                    case int n when (n >= 3 && n <= 5):
                        EnemySea.RandomShip(2);
                        break;
                    case int n when (n >= 1 && n <= 2):
                        EnemySea.RandomShip(3);
                        break;
                    case int n when (n == 0):
                        EnemySea.RandomShip(4);
                        break;
                }
            }
            UpdateSea(EnemySea, dataGridView2, false);
        }

        public void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int coordx = e.RowIndex;
            int coordy = e.ColumnIndex;
            if (Sea.CheckCanShoot(coordx, coordy, EnemySea))
            {
                if (!Sea.Shot(coordx, coordy, EnemySea)) Enemy.Attack(FriendlySea, dataGridView1);
            }       
            UpdateSea(EnemySea, dataGridView2, false);
            UpdateSea(FriendlySea, dataGridView1, true);
            dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionBackColor = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor;
            Enemy.UpdateActiveCell(dataGridView1);
            if (FriendlySea.ShipsCount == 0 || EnemySea.ShipsCount == 0) Endgame();
        }

        public void Endgame()
        {
            UpdateSea(EnemySea, dataGridView2, true);
            UpdateSea(FriendlySea, dataGridView1, true);
            if (EnemySea.ShipsCount == 0) EndText.Text = "Позравляем с победой!";
            if (FriendlySea.ShipsCount == 0) EndText.Text = "Кажется, вы проиграли!";
            EndText.Visible = true;
            dataGridView2.Enabled = false;
            BtnNewGame.Visible = true;
        }


        // Кнопки
        private void ShipIsHorisontal_CheckedChanged(object sender, EventArgs e)
        {
            orientation = 1;
        }

        private void ShipIsVertical_CheckedChanged(object sender, EventArgs e)
        {
            orientation = 0;
        }

        private void Btn1cells_CheckedChanged(object sender, EventArgs e)
        {
            shipsize = 1;
        }

        private void Btn2cells_CheckedChanged(object sender, EventArgs e)
        {      
            shipsize = 2;
        }

        private void Btn3cells_CheckedChanged(object sender, EventArgs e)
        {
            shipsize = 3;
        }

        private void Btn4cells_CheckedChanged(object sender, EventArgs e)
        {
            shipsize = 4;
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            Count1 = 4;
            Count2 = 3;
            Count3 = 2;
            Count4 = 1;
            TotalCount = 0;
            ShipIsHorisontal.Checked = true;
            Btn1cells.Checked = true;
            orientation = 1;
            dataGridView2.Visible = false;
            GroupBox.Visible = true;
            ShipIsHorisontal.Visible = true;
            ShipIsVertical.Visible = true;
            Sea.ClearSea(FriendlySea);
            Sea.ClearSea(EnemySea);
            UpdateSea(FriendlySea, dataGridView1, true);
            UpdateSea(EnemySea, dataGridView2, false);
            ships1.Text = Convert.ToString(Count1);
            ships2.Text = Convert.ToString(Count2);
            ships3.Text = Convert.ToString(Count3);
            ships4.Text = Convert.ToString(Count4);
            EndText.Visible = false;
            BtnNewGame.Visible = false;
            BtnClean.Visible = true;
            dataGridView1.Enabled = true;
            dataGridView2.Enabled = true;
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            Sea.ClearSea(FriendlySea);
            UpdateSea(FriendlySea, dataGridView1, true);
            Count1 = 4;
            Count2 = 3;
            Count3 = 2;
            Count4 = 1;
            TotalCount = 0;
            ships1.Text = Convert.ToString(Count1);
            ships2.Text = Convert.ToString(Count2);
            ships3.Text = Convert.ToString(Count3);
            ships4.Text = Convert.ToString(Count4);
        }
    }
}
