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
    public partial class Form_M12 : Form
    {
        public Form_M12()
        {
            InitializeComponent();
        }
        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            count += 1;
            label1.Text = "Count: " + count;
        }
        InstanceStatic IS = new InstanceStatic();
        private void button3_Click(object sender, EventArgs e)
        {
            IS.instanceCount++;
            labelInstanceCount.Text = "Count: " + IS.instanceCount.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InstanceStatic.staticCount++;
            labelStaticCount.Text = "Count: " + InstanceStatic.staticCount.ToString();
        }

        private void btnCallHelloForm_Click(object sender, EventArgs e)
        {
            Form_M02_HelloForm form02 = new Form_M02_HelloForm();
            form02.Show();

        }
    }
}
