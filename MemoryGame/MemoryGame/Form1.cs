using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        bool[] if_buttons_have_a_color = new bool[17];
        Color[] colors = new Color[17];
        bool[] covered = new bool[17];
        bool first_click = true;
        int moves = 0;
        int number_of_first = 0;
        int number_of_second = 0;

        public Form1()
        {
            InitializeComponent();
            draw_button(Color.Red);
            draw_button(Color.Red);
            draw_button(Color.Blue);
            draw_button(Color.Blue);
            draw_button(Color.Pink);
            draw_button(Color.Pink);
            draw_button(Color.Green);
            draw_button(Color.Green);
            draw_button(Color.LightCoral);
            draw_button(Color.LightCoral);
            draw_button(Color.Gold);
            draw_button(Color.Gold);
            draw_button(Color.Khaki);
            draw_button(Color.Khaki);
            draw_button(Color.White);
            draw_button(Color.White);

            for (int i = 0; i < 17; i++)
            {
                covered[i] = true;
            }
        }

        private void draw_button(Color color)
        {
            Random gen = new Random();
            int field_number = gen.Next(1, 17);
            while (if_buttons_have_a_color[field_number] == true)
            {
                field_number = gen.Next(1, 17);
            }
            if_buttons_have_a_color[field_number] = true;
            colors[field_number] = color;
        }

        private void check()
        {
            moves++;
            if (colors[number_of_first] == colors[number_of_second])
            {
                MessageBox.Show("Well done! You got the pair! Number of moves: " + moves);
                covered[number_of_first] = false;
                covered[number_of_second] = false;
            }
            else
            {
                MessageBox.Show("Nope. Try again.");
            }

            int uncovered = 0;
            for (int i = 0; i < 17; i++)
            {
                if (covered[i] == false)
                {
                    uncovered++;
                }
            }
            if (uncovered == 16)
            {
                MessageBox.Show("You got all the pairs, congratulations!");
            }
        }

        private void color_buttons()
        {
            if (covered[1] == false) { button1.BackColor = colors[1]; } else { button1.BackColor = Color.Gray; }
            if (covered[2] == false) { button2.BackColor = colors[2]; } else { button2.BackColor = Color.Gray; }
            if (covered[3] == false) { button3.BackColor = colors[3]; } else { button3.BackColor = Color.Gray; }
            if (covered[4] == false) { button4.BackColor = colors[4]; } else { button4.BackColor = Color.Gray; }
            if (covered[5] == false) { button5.BackColor = colors[5]; } else { button5.BackColor = Color.Gray; }
            if (covered[6] == false) { button6.BackColor = colors[6]; } else { button6.BackColor = Color.Gray; }
            if (covered[7] == false) { button7.BackColor = colors[7]; } else { button7.BackColor = Color.Gray; }
            if (covered[8] == false) { button8.BackColor = colors[8]; } else { button8.BackColor = Color.Gray; }
            if (covered[9] == false) { button9.BackColor = colors[9]; } else { button9.BackColor = Color.Gray; }
            if (covered[10] == false) { button10.BackColor = colors[10]; } else { button10.BackColor = Color.Gray; }
            if (covered[11] == false) { button11.BackColor = colors[11]; } else { button11.BackColor = Color.Gray; }
            if (covered[12] == false) { button12.BackColor = colors[12]; } else { button12.BackColor = Color.Gray; }
            if (covered[13] == false) { button13.BackColor = colors[13]; } else { button13.BackColor = Color.Gray; }
            if (covered[14] == false) { button14.BackColor = colors[14]; } else { button14.BackColor = Color.Gray; }
            if (covered[15] == false) { button15.BackColor = colors[15]; } else { button15.BackColor = Color.Gray; }
            if (covered[16] == false) { button16.BackColor = colors[16]; } else { button16.BackColor = Color.Gray; }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor != colors[1])
            {
                button1.BackColor = colors[1];
                if (first_click == true)
                {
                    number_of_first = 1;
                    first_click = false;
                }
                else
                {
                    number_of_second = 1;
                    first_click = true;
                    check();
                    color_buttons();
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor != colors[2])
            {
                button2.BackColor = colors[2];
                if (first_click == true)
                {
                    number_of_first = 2;
                    first_click = false;
                }
                else
                {
                    number_of_second = 2;
                    first_click = true;
                    check();
                    color_buttons();
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor != colors[3])
            {
                button3.BackColor = colors[3];
                if (first_click == true)
                {
                    number_of_first = 3;
                    first_click = false;
                }
                else
                {
                    number_of_second = 3;
                    first_click = true;
                    check();
                    color_buttons();
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor != colors[4])
            {
                button4.BackColor = colors[4];
                if (first_click == true)
                {
                    number_of_first = 4;
                    first_click = false;
                }
                else
                {
                    number_of_second = 4;
                    first_click = true;
                    check();
                    color_buttons();
                }
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (button5.BackColor != colors[5])
            {
                button5.BackColor = colors[5];
                if (first_click == true)
                {
                    number_of_first = 5;
                    first_click = false;
                }
                else
                {
                    number_of_second = 5;
                    first_click = true;
                    check();
                    color_buttons();
                }
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (button6.BackColor != colors[6])
            {
                button6.BackColor = colors[6];
                if (first_click == true)
                {
                    number_of_first = 6;
                    first_click = false;
                }
                else
                {
                    number_of_second = 6;
                    first_click = true;
                    check();
                    color_buttons();
                }
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (button7.BackColor != colors[7])
            {
                button7.BackColor = colors[7];
                if (first_click == true)
                {
                    number_of_first = 7;
                    first_click = false;
                }
                else
                {
                    number_of_second = 7;
                    first_click = true;
                    check();
                    color_buttons();
                }
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (button8.BackColor != colors[8])
            {
                button8.BackColor = colors[8];
                if (first_click == true)
                {
                    number_of_first = 8;
                    first_click = false;
                }
                else
                {
                    number_of_second = 8;
                    first_click = true;
                    check();
                    color_buttons();
                }
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (button9.BackColor != colors[9])
            {
                button9.BackColor = colors[9];
                if (first_click == true)
                {
                    number_of_first = 9;
                    first_click = false;
                }
                else
                {
                    number_of_second = 9;
                    first_click = true;
                    check();
                    color_buttons();
                }
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (button10.BackColor != colors[10])
            {
                button10.BackColor = colors[10];
                if (first_click == true)
                {
                    number_of_first = 10;
                    first_click = false;
                }
                else
                {
                    number_of_second = 10;
                    first_click = true;
                    check();
                    color_buttons();
                }
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (button11.BackColor != colors[11])
            {
                button11.BackColor = colors[11];
                if (first_click == true)
                {
                    number_of_first = 11;
                    first_click = false;
                }
                else
                {
                    number_of_second = 11;
                    first_click = true;
                    check();
                    color_buttons();
                }
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (button12.BackColor != colors[12])
            {
                button12.BackColor = colors[12];
                if (first_click == true)
                {
                    number_of_first = 12;
                    first_click = false;
                }
                else
                {
                    number_of_second = 12;
                    first_click = true;
                    check();
                    color_buttons();
                }
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (button13.BackColor != colors[13])
            {
                button13.BackColor = colors[13];
                if (first_click == true)
                {
                    number_of_first = 13;
                    first_click = false;
                }
                else
                {
                    number_of_second = 13;
                    first_click = true;
                    check();
                    color_buttons();
                }
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            if (button14.BackColor != colors[14])
            {
                button14.BackColor = colors[14];
                if (first_click == true)
                {
                    number_of_first = 14;
                    first_click = false;
                }
                else
                {
                    number_of_second = 14;
                    first_click = true;
                    check();
                    color_buttons();
                }
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            if (button15.BackColor != colors[15])
            {
                button15.BackColor = colors[15];
                if (first_click == true)
                {
                    number_of_first = 15;
                    first_click = false;
                }
                else
                {
                    number_of_second = 15;
                    first_click = true;
                    check();
                    color_buttons();
                }
            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            if (button16.BackColor != colors[16])
            {
                button16.BackColor = colors[16];
                if (first_click == true)
                {
                    number_of_first = 16;
                    first_click = false;
                }
                else
                {
                    number_of_second = 16;
                    first_click = true;
                    check();
                    color_buttons();
                }
            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
                        
        }
    }
}
