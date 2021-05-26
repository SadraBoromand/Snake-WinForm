using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO; // For Input And Output The Files

namespace Snake_2
{
    public partial class Game : Form
    {
        // Width 690 => / 30 => 23
        // height 540 => / 30 => 18

        public PictureBox[] Snake = new PictureBox[414]; // Snake

        public int Snake_Size = 2; // Counter of Snake

        Keys K; // for keys Location

        Timer T1 = new Timer(); // Timer For Move

        public int Scoure = 0; // For Scoure Gamer
        // -------------------------------------------------------------

        public Game()
        {
            InitializeComponent();
        }
        // -------------------------------------------------------------

        // For Load Game
        private void Game_Load(object sender, EventArgs e)
        {
            // For Snake Body
            head.Location = new Point(90, 120);
            body1.Location = new Point(60, 120);
            body2.Location = new Point(30, 120);

            Snake[0] = head;
            Snake[1] = body1;
            Snake[2] = body2;

            // Start Game Timer
            T1.Interval = Speed;
            T1.Tick += T1_Tick;

            // For Apple 1
            Apple.Location = new Point(150, 120);
        }
        // -------------------------------------------------------------

        // For Timer Game
        private void T1_Tick(object sender, EventArgs e)
        {
            Move();
            Eat_Apple();
            Extra_Option();
            Game_Over();
        }
        // -------------------------------------------------------------

        // For Extra_Option
        public int Time_Game = 0, TG = 0, Speed = 100; 
        private void Extra_Option()
        {
            // For Time Game
            Time_Game++;
            if (Time_Game == 10)
            {
                TG += Time_Game / 10;
                lbl_Time.Text = TG.ToString();
                Time_Game = 00;
            }


            // For Up Speed
            bool Finish_Speed_Up = false;
            if (Finish_Speed_Up != true)
            {
                if (Snake_Size % 10 == 0)
                {
                    Speed -= 15;
                    if (Speed <= 0)
                    {
                        Speed = 1;
                        Finish_Speed_Up = true;
                    }
                }
            }

        }
        // -------------------------------------------------------------

        // For Move Snake
        private void Move()
        {

            for (int i = Snake_Size; i > 0; i--)
            {
                Snake[i].Location = Snake[i - 1].Location;
            }

            switch (K)
            {
                case Keys.Up:
                    if (head.Location.Y - 30 != Snake[2].Location.Y)
                    {
                        if (head.Location.Y == 0)
                        {
                            head.Location = new Point(head.Location.X, 450);
                        }
                        else
                        {
                            head.Location = new Point(head.Location.X, head.Location.Y - 30);
                        }
                    }
                    else
                    {
                        K = Keys.Down;
                        head.Location = new Point(head.Location.X, head.Location.Y + 30);
                    }

                    break;

                case Keys.Down:
                    if (head.Location.Y + 30 != Snake[2].Location.Y)
                    {
                        if (head.Location.Y == 450)
                        {
                            head.Location = new Point(head.Location.X, 0);
                        }
                        else
                        {
                            head.Location = new Point(head.Location.X, head.Location.Y + 30);
                        }
                    }
                    else
                    {
                        K = Keys.Up;
                        head.Location = new Point(head.Location.X, head.Location.Y - 30);
                    }
                    break;

                case Keys.Left:
                    if (head.Location.X - 30 != Snake[2].Location.X)
                    {
                        if (head.Left <= 0)
                        {
                            head.Location = new Point(510, head.Location.Y);
                        }
                        else
                        {
                            head.Location = new Point(head.Location.X - 30, head.Location.Y);
                        }
                    }
                    else
                    {
                        K = Keys.Right;
                        head.Location = new Point(head.Location.X + 30, head.Location.Y);
                    }


                    break;

                case Keys.Right:
                    if (head.Location.X + 30 != Snake[2].Location.X)
                    {
                        if (head.Location.X == 510)
                        {
                            head.Location = new Point(0, head.Location.Y);
                        }
                        else
                        {
                            head.Location = new Point(head.Location.X + 30, head.Location.Y);
                        }
                    }
                    else
                    {
                        K = Keys.Left;
                        head.Location = new Point(head.Location.X - 30, head.Location.Y);
                    }

                    break;
            }
        }
        // -------------------------------------------------------------

        // For Game Over
        private void Game_Over()
        {
            // For Eat The Body
            for (int i = Snake_Size; i > 0; i--)
            {
                if (head.Location == Snake[i].Location)
                {
                    T1.Enabled = false;
                    this.Close();
                    new Game_Over().ShowDialog();
                }
            }

            // For By Wall
            if (By_Wall.Checked == true)
            {
                if (head.Location.Y == 0)
                {
                    T1.Enabled = false;
                    this.Close();
                    new Game_Over().ShowDialog();
                }
                if (head.Location.Y == 450)
                {
                    T1.Enabled = false;
                    this.Close();
                    new Game_Over().ShowDialog();
                }
                if (head.Left <= 0)
                {
                    T1.Enabled = false;
                    this.Close();
                    new Game_Over().ShowDialog();
                }
                if (head.Location.X == 510)
                {
                    T1.Enabled = false;
                    this.Close();
                    new Game_Over().ShowDialog();
                }
            }
        }
        // -------------------------------------------------------------

        // For Eat Apple
        private void Eat_Apple()
        {
            if (head.Location == Apple.Location)
            {
                // For Add Snake
                Snake[++Snake_Size] = new PictureBox();
                Snake[Snake_Size].Size = new Size(23, 23);
                Snake[Snake_Size].BorderStyle = BorderStyle.None;
                Snake[Snake_Size].BackgroundImageLayout = ImageLayout.Stretch;
                Snake[Snake_Size].BackColor = Color.Transparent;
                Snake[Snake_Size].BackgroundImage = Properties.Resources.body;
                Snake[Snake_Size].Location = Snake[Snake_Size - 1].Location;
                this.Controls.Add(Snake[Snake_Size]);

                // For Add Score
                Scoure++;
                lbl_Score.Text = Scoure.ToString();

                // For Add New Apple
                Random Rnd = new Random();
                int X = Rnd.Next(2, 10);
                int Y = Rnd.Next(2, 6);

                bool Loop = true;
                do
                {
                    for (int i = Snake_Size; i >= 0; i--)
                    {
                        if (Snake[i].Location == new Point(X * 30, Y * 30))
                        {
                            X = Rnd.Next(2, 17);
                            Y = Rnd.Next(2, 14);
                        }
                        else if (X * 30 > 500 || Y * 30 > 430)
                        {
                            X = Rnd.Next(2, 17);
                            Y = Rnd.Next(2, 14);
                        }
                        else
                        {
                            Loop = false;
                        }
                    }
                } while (Loop);
                
                // New Location Apple
                Apple.Location = new Point(X * 30, Y * 30);
            }
        }
        // -------------------------------------------------------------

        // For Exit Game
        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            this.Close(); // Exit Game
        }
        // -------------------------------------------------------------

        // For Start Game
        private void Btn_Start_Click(object sender, EventArgs e)
        {

            By_Edge.Enabled = false;
            By_Wall.Enabled = false;

            btn_Menu.Enabled = false;
            btn_Start.Enabled = false;
        }
        // -------------------------------------------------------------

        // For Keys Move
        private void Game_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                K = e.KeyCode;
            }
            if (T1.Enabled == false && K != null) // First Move
            {
                T1.Enabled = true;
            }
            if (e.KeyCode == Keys.Escape) // Exit Game
            {
                this.Close();
            }
        }
        // -------------------------------------------------------------

    }
}
