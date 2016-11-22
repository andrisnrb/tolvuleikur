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
        int teljari1 = 0, teljari2 = 1, teljari3 = 1;
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
                teljari2++;
                if (teljari2==63)
                {
                    teljari2 = 1;
                    teljari3++;
                }
                World[i] = new Button();
                World[i].Size = new Size(15, 15);
                World[i].Location = new Point(x, y);
                World[i].BackColor = Color.LightGreen;
                World[i].Name =  (currentX + ":" + currentY);
                World[i].ForeColor = World[i].BackColor;
                
                //startPositioning
                if (World[i].Name == "39:10" )
                {
                    World[i].BackColor = Color.Black;
                    World[i].ForeColor = World[i].BackColor;
                }
               
                x = x + 15;
                if (teljari1==62)
                {
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

            Tré1(12, 12);
            Tré1(13, 20);
            Tré1(32, 10);
            
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
                if (World[i].Name == x + ":" + y || World[i].Name == (x + 1) + ":" + y || World[i].Name == (x + 1) + ":" + (y+1) || World[i].Name == (x + 1) + ":" + (y-1) || World[i].Name == (x+2) + ":" + y || World[i].Name == x + ":" + (y+1) ||
                    World[i].Name == x + ":" + (y+2) || World[i].Name == (x-1) + ":" + y || World[i].Name == (x-2) + ":" + y || World[i].Name == x + ":" + (y-1) || World[i].Name == x + ":" + (y-2) || World[i].Name == (x-1) + ":" + (y-1) ||
                    World[i].Name == (x-1) + ":" + (y+1))
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
        public void Hús1(int x, int y)
        {

        }
        public void Hús2(int x, int y)
        {

        }
        public void Hús3(int x, int y)
        {

        }

    }
}
