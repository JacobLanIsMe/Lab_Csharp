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
    public partial class Form_M07 : Form
    {
        public Form_M07()
        {
            InitializeComponent();
        }

        private void btnObjectInit_Click(object sender, EventArgs e)
        {
            Member mem1 = new Member();
            mem1.Name = "Jacob";
            mem1.Age = 35;
            MessageBox.Show($"我的名字是{mem1.Name}\n我的年齡是{mem1.Age}歲");
            Member mem2 = new Member()
            {
                Name = "藍紹瑋",
                Age = 35
            };
            MessageBox.Show($"我的名字是{mem2.Name}\n我的年齡是{mem2.Age}歲");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.button1.Click += new System.EventHandler(this.button1_Click);
            btnRegister01.Click += new EventHandler(btnRegister01_Click);
            btnRegister02.Click += BtnRegister02_Click;
        }

        private void BtnRegister02_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Register02");
        }

        private void btnRegister01_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Register01");
        }

        private void btnDeregister_Click(object sender, EventArgs e)
        {
            btnRegister01.Click -= btnRegister01_Click;
        }
    }
}
