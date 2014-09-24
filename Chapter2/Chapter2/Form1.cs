using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chapter2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtBoxX.Text = "0";
            txtBoxY.Text = "0";
        }
        // Get min x,y
        private void minToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtBoxX.Text);
            double y = double.Parse(txtBoxY.Text);
            lbResult.Text = "Min x,y is";
            txtReslut.Text = Arithmetic_func.Min(x,y).ToString();
        }
        // Get max x,y
        private void maxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtBoxX.Text);
            double y = double.Parse(txtBoxY.Text);
            lbResult.Text = "Max x,y is";
            txtReslut.Text = Arithmetic_func.Max(x, y).ToString();
        }
        // Get x^y
        private void powToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtBoxX.Text);
            double y = double.Parse(txtBoxY.Text);
            lbResult.Text = "x^y is";
            txtReslut.Text = Arithmetic_func.Pow(x, y).ToString();
        }
        // Get e^x
        private void exponentialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtBoxX.Text);
            lbResult.Text = "e^x is";
            txtReslut.Text = Arithmetic_func.Exp(x).ToString();
        }
        // Get ln(x)
        private void logarithmicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtBoxX.Text);
            lbResult.Text = "ln(x) is";
            txtReslut.Text = Arithmetic_func.Log(x).ToString();
        }
        // Get log10(x)
        private void log10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtBoxX.Text);
            lbResult.Text = "log10(x) is";
            txtReslut.Text = Arithmetic_func.Log10(x).ToString();
        }
        // Get sin(x)
        private void sinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtBoxX.Text);
            lbResult.Text = "sin(x) is";
            txtReslut.Text = Trigonometric_func.sin(x).ToString();
        }
        // Get cos(x)
        private void cosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtBoxX.Text);
            lbResult.Text = "cos(x) is";
            txtReslut.Text = Trigonometric_func.cos(x).ToString();
        }
        // Get tan(x)
        private void tanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtBoxX.Text);
            lbResult.Text = "tan(x) is";
            txtReslut.Text = Trigonometric_func.tan(x).ToString();
        }
        // Get sec(x)
        private void secToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtBoxX.Text);
            lbResult.Text = "sec(x) is";
            txtReslut.Text = Trigonometric_func.sec(x).ToString();
        }
        // Get csc(x)
        private void cscToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtBoxX.Text);
            lbResult.Text = "csc(x) is";
            txtReslut.Text = Trigonometric_func.csc(x).ToString();
        }
        // Get cotan(x)
        private void cotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtBoxX.Text);
            lbResult.Text = "cot(x) is";
            txtReslut.Text = Trigonometric_func.cot(x).ToString();
        }
    }
}
