using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Form_M15 : Form
    {
        public Form_M15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A = 100;
            MessageBox.Show("A: " + A.ToString());
            int B = A;
            MessageBox.Show("A; " + A.ToString() + " B: " + B.ToString());
            B = 200;
            MessageBox.Show("A; " + A.ToString() + " B: " + B.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox tb = textBoxReferenceType;
            tb.Text = "Reference Type";
            tb.TextAlign = HorizontalAlignment.Right;
        }
    }
}
