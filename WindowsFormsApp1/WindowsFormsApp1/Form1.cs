using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(sTop.Text=="" || sBott.Text == "" || sRight.Text == "" || sLeft.Text == "" ))
            {
                Shape shape = new Shape(sTop.Text, sBott.Text, sLeft.Text, sRight.Text);
                MessageBox.Show(shape.determineShape());
            }
           

        }
    }
}
