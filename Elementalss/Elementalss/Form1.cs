using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elementalss
{
    public partial class Form1 : Form
    {
        int X = 0;
        int e1, e2, e3, e4, e5 = 0;
        int x = 0;
        int r1, r2,r3, r4, r5 = 0;
        int AX = 0;
        int E = 0;
        string[,] valence =
            {
                {"O","6" },
                {"S","6" },
                {"Se","6" },
                {"Te","6" },
                {"N","5" },
                {"P","5" },
                {"As","5" },
                {"C","4" },
                {"Si","4" },
                {"B","3" },
                {"Be","2" },

            };
        string[,] arm =
        {
                {"H","1","1" },
                {"F","1","1" },
                {"Cl","1","1" },
                {"Br","1","1" },
                {"I","1","1" },
                {"O","2","1" },
                {"S","2","1" },
                {"Se","2","1" },
                {"Te","2","1" },
                {"N","3","1" },
                {"P","3","1" },
                {"As","3","1" },
                {"C","4","1" },
                {"Si","4","1" },
                {"KFC","0","0" }
            };
      
public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           for (int i = 0; i < 11; i++)
            {
                if (textBox1.Text == valence[i, 0])
                {
                    X = int.Parse(valence[i, 1]) ;
                }
            }
            if (X == 6)
            {
                panel2.Visible = true;
            }
            if (X == 5)
            {
                panel3.Visible = true;
            }
            if (X == 4)
            {
                panel4.Visible = true;
            }
            if (X == 3)
            {
                panel5.Visible = true;
            }
            for (int i = 0; i < 11; i++)
            {
                if (textBox1.Text == valence[i, 0])
                {
                    X = int.Parse(valence[i, 1]);
                }
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 13; i++)
            {
                if (textBox21.Text == arm[i, 0])
                {
                    e1 = i;
                }
                if (textBox22.Text == arm[i, 0])
                {
                    e2 = i;
                }

            }
            x = int.Parse(valence[X, 1]);
            r1 = int.Parse(arm[e1, 1]);
            r2 = int.Parse(arm[e2, 1]);
            AX = 8 - X;
            E = (X - r1 - r2) / 2;
            MessageBox.Show("AX" + AX + "E" + E);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 13; i++)
            {
                if (textBox31.Text == arm[i, 0])
                {
                    e1 = i;
                }
                if (textBox32.Text == arm[i, 0])
                {
                    e2 = i;
                }
                if (textBox33.Text == arm[i, 0])
                {
                    e3 = i;
                }
            }
            x = int.Parse(valence[X, 1]);
            r1 = int.Parse(arm[e1, 1]);
            r2 = int.Parse(arm[e2, 1]);
            r3 = int.Parse(arm[e3, 1]);
            AX = 8 - X;
            E = (X - r1 - r2 - r3) / 2;
            MessageBox.Show("AX" + AX + "E" + E);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 13; i++)
            {
                if (textBox41.Text == arm[i, 0])
                {
                    e1 = i;
                }
                if (textBox42.Text == arm[i, 0])
                {
                    e2 = i;
                }
                if (textBox43.Text == arm[i, 0])
                {
                    e3 = i;
                }
                if (textBox44.Text == arm[i, 0])
                {
                    e4 = i;
                }
            }
            if (string.IsNullOrEmpty(textBox41.Text))
            {
                e1 = 14;
            }
            if (string.IsNullOrEmpty(textBox42.Text))
            {
                e2 = 14;
            }
            if (string.IsNullOrEmpty(textBox43.Text))
            {
                e3 = 14;
            }
            if (string.IsNullOrEmpty(textBox44.Text))
            {
                e4 = 14;
            }
            //x = int.Parse(valence[X, 1]);
            r1 = int.Parse(arm[e1, 1]);
            r2 = int.Parse(arm[e2, 1]);
            r3 = int.Parse(arm[e3, 1]);
            r4 = int.Parse(arm[e4, 1]);
            //AX = 8 - X;
            AX = int.Parse(arm[e1, 2]) + int.Parse(arm[e2, 2]) + int.Parse(arm[e3, 2]) + int.Parse(arm[e4, 2]);
            E = (X - r1 - r2 - r3 -r4) / 2;
            MessageBox.Show("AX" + AX + "E" + E);
            MessageBox.Show("" + X + r1 + r2+r3+r4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 13; i++)
            {
                if (textBox51.Text == arm[i, 0])
                {
                    e1 = i;
                }
                if (textBox52.Text == arm[i, 0])
                {
                    e2 = i;
                }
                if (textBox53.Text == arm[i, 0])
                {
                    e3 = i;
                }
                if (textBox54.Text == arm[i, 0])
                {
                    e4 = i;
                }
                if (textBox55.Text == arm[i, 0])
                {
                    e5 = i;
                }
            }
            x = int.Parse(valence[X, 1]);
            r1 = int.Parse(arm[e1, 1]);
            r2 = int.Parse(arm[e2, 1]);
            r3 = int.Parse(arm[e3, 1]);
            r4 = int.Parse(arm[e4, 1]);
            r5 = int.Parse(arm[e5, 1]);
            AX = 8 - X;
            E = (X - r1 - r2 - r3 - r4 - r5) / 2;
            MessageBox.Show("AX" + AX + "E" + E);
        }
    }
}
