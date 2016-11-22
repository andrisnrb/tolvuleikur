using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tolvuleikur_test2
{
    public partial class Form1 : Form
    {
        int teljari1 = 0, teljari2 = 0, teljari3 = 1;
        int currentX = 0;
        int currentY = 0;


        Button[] World = new Button[1984];

        public Form1()
        {
            InitializeComponent();
            CreateWorld1();
        }

        public void CreateWorld1()
        {
            int y = 28;
            int x = 3;

            for (int i = 0; i < World.Length; i++)
            {
                currentX++;

                teljari1++;

                
                World[i] = new Button();
                World[i].Size = new Size(15, 15);
                World[i].Location = new Point(x, y);
                World[i].Name = (currentX + ":" + currentY);
                //temp
                if (teljari1 % 5 == 0 && teljari2 == 0)
                {
                    World[i].BackColor = Color.Red;
                }
                //temp
                else
                {
                    World[i].BackColor = Color.LightGreen;
                }
               

                //startPositioning
                if (World[i].Name == "39:10")
                {
                    World[i].BackColor = Color.Black;
                    World[i].ForeColor = World[i].BackColor;
                }

                x = x + 15;
                if (teljari1 == 62)
                {
                    teljari2++;
                    //temp
                    if (teljari2%5==0)
                    {
                        World[i].BackColor = Color.Red;
                    }
                    //temp
                    currentX = 0;
                    x = 3;
                    y = y + 15;
                    teljari1 = 0;
                    currentY++;
                }
                this.World[i].Click += Form1_Click;
                this.Controls.Add(World[i]);
            }

            //MapDesign

            Tré1(32, 10);
            Tré1(20, 25);
            Tré1(23, 5);
            Hús1v1(5, 10);
            Hús1v2(5, 17);
            Hús1v2(13, 12);
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        //MapDesignTools

        //tré
        public void Tré1(int x, int y)
        {
            for (int i = 0; i < World.Length; i++)
            {
                if (World[i].Name == x + ":" + y || World[i].Name == (x + 1) + ":" + y || World[i].Name == (x + 1) + ":" + (y + 1) || World[i].Name == (x + 1) + ":" + (y - 1) || World[i].Name == (x + 2) + ":" + y || World[i].Name == x + ":" + (y + 1) ||
                    World[i].Name == x + ":" + (y + 2) || World[i].Name == (x - 1) + ":" + y || World[i].Name == (x - 2) + ":" + y || World[i].Name == x + ":" + (y - 1) || World[i].Name == x + ":" + (y - 2) || World[i].Name == (x - 1) + ":" + (y - 1) ||
                    World[i].Name == (x - 1) + ":" + (y + 1))
                {
                    World[i].BackColor = Color.DarkGreen;
                }

            }


        }
        public void Tré2(int x, int y)
        {
            for (int i = 0; i < World.Length; i++)
            {
                if (World[i].Name == x + ":" + y)
                {
                    World[i].BackColor = Color.DarkGreen;
                }

            }
        }
        public void Tré3(int x, int y)
        {
            for (int i = 0; i < World.Length; i++)
            {
                if (World[i].Name == x + ":" + y)
                {
                    World[i].BackColor = Color.DarkGreen;
                }

            }
        }

        //Hús
        public void Hús1v1(int x, int y)
        {
            for (int i = 0; i < World.Length; i++)
            {
                if (World[i].Name == x + ":" + y || World[i].Name == (x + 4) + ":" + y ||
                    World[i].Name == x + ":" + (y + 1) || World[i].Name == x + ":" + (y + 2) || World[i].Name == x + ":" + (y + 3) || World[i].Name == x + ":" + (y + 4) || World[i].Name == x + ":" + (y + 5) ||
                    World[i].Name == (x + 4) + ":" + (y + 1) || World[i].Name == (x + 4) + ":" + (y + 2) || World[i].Name == (x + 4) + ":" + (y + 3) || World[i].Name == (x + 4) + ":" + (y + 4) || World[i].Name == (x + 4) + ":" + (y + 5))
                {

                    World[i].BackColor = Color.FromArgb(69, 36, 14);
                }
                if (World[i].Name == (x + 1) + ":" + y || World[i].Name == (x + 3) + ":" + y ||
                    World[i].Name == (x + 1) + ":" + (y + 1) || World[i].Name == (x + 1) + ":" + (y + 2) || World[i].Name == (x + 1) + ":" + (y + 3) || World[i].Name == (x + 1) + ":" + (y + 4) || World[i].Name == (x + 1) + ":" + (y + 5) ||
                    World[i].Name == (x + 3) + ":" + (y + 1) || World[i].Name == (x + 3) + ":" + (y + 2) || World[i].Name == (x + 3) + ":" + (y + 3) || World[i].Name == (x + 3) + ":" + (y + 4) || World[i].Name == (x + 3) + ":" + (y + 5))
                {
                    World[i].BackColor = Color.FromArgb(78, 47, 18);
                }
                if (World[i].Name == (x + 2) + ":" + y ||
                    World[i].Name == (x + 2) + ":" + (y + 1) || World[i].Name == (x + 2) + ":" + (y + 2) || World[i].Name == (x + 2) + ":" + (y + 3) || World[i].Name == (x + 2) + ":" + (y + 4) || World[i].Name == (x + 2) + ":" + (y + 5))
                {
                    World[i].BackColor = Color.FromArgb(86, 51, 20);
                }
            }

        }
        public void Hús1v2(int x, int y)
        {
            for (int i = 0; i < World.Length; i++)
            {
                if (World[i].Name == x + ":" + y || World[i].Name == (x+1) + ":" + y || World[i].Name == (x+2) + ":" + y || World[i].Name == (x+3) + ":" + y || World[i].Name == (x+4) + ":" + y || World[i].Name == (x+5) + ":" + y ||
                    World[i].Name == x + ":" + (y + 4) || World[i].Name == (x + 1) + ":" + (y + 4) || World[i].Name == (x + 2) + ":" + (y + 4) || World[i].Name == (x + 3) + ":" + (y + 4) || World[i].Name == (x + 4) + ":" + (y + 4) || World[i].Name == (x + 5) + ":" + (y + 4))
                {
                    World[i].BackColor = Color.FromArgb(69, 36, 14);
                }
                if (World[i].Name == x + ":" + (y+1) || World[i].Name == (x+1) + ":" + (y+1) || World[i].Name == (x+2) + ":" + (y+1) || World[i].Name == (x+3) + ":" + (y+1) || World[i].Name == (x+4) + ":" + (y+1) || World[i].Name == (x+5) + ":" + (y+1) ||
                    World[i].Name == x + ":" + (y + 3) || World[i].Name == (x + 1) + ":" + (y + 3) || World[i].Name == (x + 2) + ":" + (y + 3) || World[i].Name == (x + 3) + ":" + (y + 3) || World[i].Name == (x + 4) + ":" + (y + 3) || World[i].Name == (x + 5) + ":" + (y + 3))
                {
                    World[i].BackColor = Color.FromArgb(78, 47, 18);
                }
                if (World[i].Name == x + ":" + (y+2) || World[i].Name == (x+1) + ":" + (y+2) || World[i].Name == (x+2) + ":" + (y+2) || World[i].Name == (x+3) + ":" + (y+2) || World[i].Name == (x+4) + ":" + (y+2) || World[i].Name == (x+5) + ":" + (y+2))
                {
                    World[i].BackColor = Color.FromArgb(86, 51, 20);
                }

            }
        }
    }
}
