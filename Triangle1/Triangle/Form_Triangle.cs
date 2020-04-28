using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class Form_Triangle : Form
    {
        int side_A_base;
        int side_B;
        int side_C;
        double height;
        double Perimeter;
        double half_perimeter;
        double geron_triangle_area;
        double triangle_area;
        public Form_Triangle()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                side_A_base = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception) { textBox1.Text = "WRONG"; }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                if (side_A_base + side_B > side_C && side_A_base + side_C > side_B && side_B + side_C > side_A_base)
                {
                    MessageBox.Show("Трикутник існує!", "INFORMATION",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                
                    Perimeter = side_A_base + side_B + side_C;
                    half_perimeter = Perimeter / 2;
                    geron_triangle_area = Math.Sqrt(half_perimeter * (half_perimeter - side_A_base) * (half_perimeter - side_B) * (half_perimeter - side_C));
                    height = (2 * geron_triangle_area) / side_A_base;
                    triangle_area = (side_A_base * height) / 2;

                    //Labels for Triangle
                    lblSide_A_base.Text = Convert.ToString(side_A_base);
                    lblSide_C.Text = Convert.ToString(side_B);
                    lblSide_B.Text = Convert.ToString(side_C);
                    lblHeight_H.Text = Convert.ToString($"{height:N2}");

                    //Displaying results of Calculation
                    lblPerimeter.Text = Convert.ToString(Perimeter);
                    lblHalfPerimeter.Text = Convert.ToString($"{half_perimeter:N2}");
                    txtbHeight.Text = Convert.ToString($"{height:N2}");
                    lblAreaTriangle.Text = Convert.ToString($"{triangle_area:N2}");
                    lblAreaGeron.Text = Convert.ToString($"{geron_triangle_area:N2}");
                }
                else
                {
                    MessageBox.Show("Трикутник не може існувати. \nСума будь-яких двох сторін \nмає бути більше третьої",
                        "INFORMATION",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                Console.WriteLine("Возникло исключение!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try {
                side_B = Convert.ToInt32(textBox3.Text);
                }
            catch (Exception) { textBox3.Text = "WRONG"; }
}

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try {
                side_C = Convert.ToInt32(textBox4.Text);
                }
            catch (Exception) { textBox4.Text = "WRONG"; }
}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPerimeter_Click(object sender, EventArgs e)
        {

        }
    }
}
