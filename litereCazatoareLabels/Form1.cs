using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace litereCazatoareLabels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        public static int N = 250;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Random rndx = new Random(100);
        Random rndc = new Random(800);
        Random rndy = new Random(100);
        Random rndu = new Random(800);
        private void Form1_Shown(object sender, EventArgs e)
        {
           
            for (int i = 0; i < N; i++)
            {

                Label a = new Label();
                Controls.Add(a);
                Controls[i].Text = "X";// i.ToString();
                Controls[i].BackColor = Color.Transparent;
                Controls[i].ForeColor = Color.Green;
                Controls[i].Name = i.ToString();
                Controls[i].Left = rndx.Next(1,933) + rndc.Next(2,908);
                Controls[i].Top =    rndy.Next(2,700) + rndu.Next(1,880);
                Controls[i].Visible = true;
                Controls[i].Refresh();
                this.Refresh();
                Text = Controls[i].ToString();
                //Thread.Sleep(300);

            }

            timer1.Enabled = true;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < N; i++)
            {

                Controls[i].Top += rndc.Next(2, 13);
                Controls[i].Text = "X";// Controls[i].Top.ToString() + ":" + Controls[i].Left.ToString();
                Controls[i].Font = new System.Drawing.Font("Verdana", Controls[i].Top/40);
                
                Controls[i].Refresh();

                if (Controls[i].Top > 600)
                {
                    Controls[i].Top = 40;
                    Controls[i].Left = rndx.Next(1, 933) + rndc.Next(2, 908);
                    Controls[i].Refresh();
                }
            }
        }
    }
}
