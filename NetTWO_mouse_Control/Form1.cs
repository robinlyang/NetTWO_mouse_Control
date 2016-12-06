using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetTWO_mouse_Control
{
    public partial class Form1 : Form
    {
        public string number1 = "", number2 = "", oper = "";
        public double total, value1, value2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //textBox1.Text = e.X.ToString();
            //textBox2.Text = e.Y.ToString();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //textBox1.Text = e.X.ToString();
            //textBox2.Text = e.Y.ToString();

            //all the calculator code is within the picturbox
            //check for operator
            //+ = (381, 329), (473, 383)
            if (e.X >=381 && e.X <= 473 && e.Y >=329 && e.Y <=383)
            {
                oper = "+";
            }
            //check for equal
            //= = (200, 329), (597, 386)
            if (e.X >= 200 && e.X <= 597 && e.Y >= 329 && e.Y <= 386)
            {
                value1 = Convert.ToDouble(number1);
                value2 = Convert.ToDouble(number2);
                if (oper=="+")
                {
                    total = value1 + value2;
                }

                output.Text = total.ToString();
                number1 = "";
                number2 = "";
                oper = "";
            }
            //check for 1 pressed
            //1 = (20, 259), (115, 316)
            if (e.X >= 20 && e.X <= 259 && e.Y >= 115 && e.Y <= 316)
            {
                if(oper=="")
                {
                    number1 = number1 + "1";
                    output.Text = number1;
                }
                else
                {
                    number2 = number2 + "1";
                    output.Text = number2;
                }
                
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
