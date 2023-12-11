using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritanceAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateRectangle_Click(object sender, EventArgs e)
        {   try
            {
                double length = double.Parse(txtLength.Text);
                double width = double.Parse(txtWidth.Text);
                Rectangle rectangle = new Rectangle(length, width);
                Display(rectangle);
            }
            catch
            {
                MessageBox.Show("Incorrect input", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Information );
            }

            
        }

        private void btnCreateBox_Click(object sender, EventArgs e)
        {
            try
            {
                double length = double.Parse(txtLength.Text);
                double width = double.Parse(txtWidth.Text);
                double height = double.Parse(txtHeight.Text);
                Box box = new Box(length, width, height);
                Display(box);
            }
            catch
            {
                MessageBox.Show("Incorrect input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCreatePyramid_Click(object sender, EventArgs e)
        {
            try
            {
                double length = double.Parse(txtLength.Text);
                double width = double.Parse(txtWidth.Text);
                double height = double.Parse(txtHeight.Text);
                RectangularPyramid rectangularPyramid = new RectangularPyramid(length, width, height);
                Display(rectangularPyramid);
            }
            catch
            {
                MessageBox.Show("Incorrect input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void Display(Rectangle rectangle)
        {
            double perimeter = rectangle.GetPerimeter();
            double area = rectangle.GetArea();
            double volume = rectangle.GetVolume();            
            richTextBox1.AppendText("Shape: " + rectangle.ToString() +"\n" +
                "Perimeter: " + perimeter.ToString("f2") + "\n" +
                "Area: " + area.ToString("f2") + "\n" +
                "Volume: " + volume.ToString("f2")+ "\n\n");


        }
    }
}
