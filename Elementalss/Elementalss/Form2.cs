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
    public partial class Form2 : Form
    {
        
        int X = 0;
        int p = 0;
        int c = 0;
        int e1, e2, e3, e4, e5 = 0;
        int x = 0;
        int r1, r2, r3, r4, r5 = 0;

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
            if (string.IsNullOrEmpty(textBox31.Text))
            {
                e1 = 14;
            }
            if (string.IsNullOrEmpty(textBox32.Text))
            {
                e2 = 14;
            }
            if (string.IsNullOrEmpty(textBox33.Text))
            {
                e3 = 14;
            }
            x = int.Parse(valence[X, 1]);
            r1 = int.Parse(arm[e1, 1]);
            r2 = int.Parse(arm[e2, 1]);
            r3 = int.Parse(arm[e3, 1]);
            AX = int.Parse(arm[e1, 2]) + int.Parse(arm[e2, 2]) + int.Parse(arm[e3, 2]);
            if (textBox1.Text == "B")
            {
                E = 0;
            }
            else
            {
                E = (X - r1 - r2 - r3) / 2;
            }
            MessageBox.Show("AX" + AX + "E" + E);
            label20.Text = (AX + "");
            label19.Text = (E + "");
            panel3.Visible = false;
            panel1.Visible = true;
            c = 0;
            panel7.Visible = true;
            panel7.Location = new System.Drawing.Point(29, 21);
            if (AX == 3)
                if (E == 2)
                {

                    ax3e2.Location = new System.Drawing.Point(68, 114);
                    ax3e2.Visible = true;
                }
            if (AX == 3)
                if (E == 0)
                {
                    ax3e0.Location = new System.Drawing.Point(68, 114);
                    ax3e0.Visible = true;
                }
            if (AX == 3)
                if (E == 1)
                {
                    ax3e1.Location = new System.Drawing.Point(68, 114);
                    ax3e1.Visible = true;
                }
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
            r1 = int.Parse(arm[e1, 1]);
            r2 = int.Parse(arm[e2, 1]);
            r3 = int.Parse(arm[e3, 1]);
            r4 = int.Parse(arm[e4, 1]);
            AX = int.Parse(arm[e1, 2]) + int.Parse(arm[e2, 2]) + int.Parse(arm[e3, 2]) + int.Parse(arm[e4, 2]);
            E = (X - r1 - r2 - r3 - r4) / 2;
            MessageBox.Show("AX" + AX + "E" + E);
            label20.Text = (AX + "");
            label19.Text = (E + "");
            panel4.Visible = false;
            panel1.Visible = true;
            c = 0;
            panel7.Visible = true;
            panel7.Location = new System.Drawing.Point(29, 21);
            if (AX == 4)
                if (E == 1)
                {
                    ax4e1.Location = new System.Drawing.Point(68, 114);
                    ax4e1.Visible = true;
                }
            if (AX == 4)
                if (E == 2)
                {
                    ax4e2.Location = new System.Drawing.Point(68, 114);
                    ax4e2.Visible = true;
                }
            if (AX == 4)
                if (E == 0)
                {
                    ax4e0.Location = new System.Drawing.Point(68, 114);
                    ax4e0.Visible = true;
                }
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
            if (string.IsNullOrEmpty(textBox51.Text))
            {
                e1 = 14;
            }
            if (string.IsNullOrEmpty(textBox52.Text))
            {
                e2 = 14;
            }
            if (string.IsNullOrEmpty(textBox53.Text))
            {
                e3 = 14;
            }
            if (string.IsNullOrEmpty(textBox54.Text))
            {
                e4 = 14;
            }
            if (string.IsNullOrEmpty(textBox55.Text))
            {
                e5 = 14;
            }
            x = int.Parse(valence[X, 1]);
            r1 = int.Parse(arm[e1, 1]);
            r2 = int.Parse(arm[e2, 1]);
            r3 = int.Parse(arm[e3, 1]);
            r4 = int.Parse(arm[e4, 1]);
            r5 = int.Parse(arm[e5, 1]);
            //AX = 8 - X;
            AX = int.Parse(arm[e1, 2]) + int.Parse(arm[e2, 2]) + int.Parse(arm[e3, 2]) + int.Parse(arm[e4, 2]) + int.Parse(arm[e5, 2]);
            E = (X - r1 - r2 - r3 - r4 - r5) / 2;
            MessageBox.Show("AX" + AX + "E" + E);
            label20.Text = (AX + "");
            label19.Text = (E + "");
            panel5.Visible = false;
            panel1.Visible = true;
            c = 0;
            panel7.Visible = true;
            panel7.Location = new System.Drawing.Point(29, 21);
            if (AX == 5)
                if (E == 0)
                {
                    ax5e0.Location = new System.Drawing.Point(68, 114);
                    ax5e0.Visible = true;
                }
            if (AX == 5)
                if (E == 1)
                {
                    ax5e1.Location = new System.Drawing.Point(68, 114);
                    ax5e1.Visible = true;
                }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel7.Visible = false;
            ax2e0.Visible = false;
            ax2e1.Visible = false;
            ax2e2.Visible = false;
            ax2e3.Visible = false;
            ax3e0.Visible = false;
            ax3e1.Visible = false;
            ax3e2.Visible = false;
            ax4e0.Visible = false;
            ax4e1.Visible = false;
            ax4e2.Visible = false;
            ax5e0.Visible = false;
            ax5e1.Visible = false;
            ax6e0.Visible = false;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ขอบเขตของโปรแกรม\n1.Hห้ามเป็นอะตอมกลาง\n2.สูตรโมเลกุลจะต้องไม่มีประจุ\n3.จะต้องครบออกเตบ\n4.จะต้องเป็นพันธะโคเวเลนต์");
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
            if (string.IsNullOrEmpty(textBox21.Text))
            {
                e1 = 14;
            }
            if (string.IsNullOrEmpty(textBox22.Text))
            {
                e2 = 14;
            }
            x = int.Parse(valence[X, 1]);
            r1 = int.Parse(arm[e1, 1]);
            r2 = int.Parse(arm[e2, 1]);
            AX = int.Parse(arm[e1, 2]) + int.Parse(arm[e2, 2]);
            if (textBox1.Text == "Be")
            {
                E = 0;
            }
            else
            {
                E = (X - r1 - r2) / 2;
            }

            MessageBox.Show("AX" + AX + "E" + E);
            label20.Text = (AX + "");
            label19.Text = (E + "");
            panel2.Visible = false;
            panel1.Visible = true;
            c = 0;
            panel7.Visible = true;
            panel7.Location = new System.Drawing.Point(29, 21);
            if (AX == 2)
                if (E == 2)
                {
                    ax2e2.Location = new System.Drawing.Point(68, 114);
                    ax2e2.Visible = true;
                }
            if (AX == 2)
                if (E == 0)
                {
                    ax2e0.Location = new System.Drawing.Point(68, 114);
                    ax2e0.Visible = true;
                }
            if (AX == 2)
                if (E == 1)
                {
                    ax2e1.Location = new System.Drawing.Point(68, 114);
                    ax2e1.Visible = true;
                    if (AX == 2)
                        if (E == 3)
                        {
                            ax2e3.Location = new System.Drawing.Point(68, 114);
                            ax2e3.Visible = true;
                        }
                }
        }

        int AX = 0;
        int E = 0;
        string[,] valence =
            {
                {"O","6" },
                {"S","6" },
                {"Se","6" },
                {"Te","6" },
                {"P","5" },
                {"N","5" },
                {"As","5" },
                {"C","4" },
                {"Si","4" },
                {"B","5" },
                {"Be","6" },

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
                {"KFC","0","0" },
        };
        public Form2()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(318, 365);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel7.Visible = false;
            ax2e0.Visible = false;
            ax2e1.Visible = false;
            ax2e2.Visible = false;
            ax2e3.Visible = false;
            ax3e0.Visible = false;
            ax3e1.Visible = false;
            ax3e2.Visible = false;
            ax4e0.Visible = false;
            ax4e1.Visible = false;
            ax4e2.Visible = false;
            ax5e0.Visible = false;
            ax5e1.Visible = false;
            ax6e0.Visible = false;
            panel2.Location = new System.Drawing.Point(29, 21);
            panel3.Location = new System.Drawing.Point(29, 21);
            panel4.Location = new System.Drawing.Point(29, 21);
            panel5.Location = new System.Drawing.Point(29, 21);
            panel7.Location = new System.Drawing.Point(29, 21);
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("กรุณาระบุอะตอมกลาง");
            }

            else
            {
                for (int i = 0; i < 10; i++)
                {
                    if (textBox1.Text == valence[i, 0])
                    {
                        X = int.Parse(valence[i, 1]);
                    }

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
            for (int i = 0; i < 10; i++)
            {
                if (textBox1.Text == valence[i, 0])
                {
                    X = int.Parse(valence[i, 1]);
                }
            }

        }
    }
    }

