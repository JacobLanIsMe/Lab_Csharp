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

        delegate double Payment(double money);

        double Discount50off(double money)
        {
            return money * 0.5;
        }
        double Discount20off(double money)
        {
            return money * 0.8;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Payment pay;
            if (comboBox1.Text == "50%off")
            {
                pay = Discount50off;
            }
            else
            {
                pay = Discount20off;
            }
            double finalPrice = pay(double.Parse(textBox1.Text));
            MessageBox.Show(finalPrice.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Text = "Form_M07_SetProperty";
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("今天是星期二嗎?", "請問", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("今天不是星期二!");
            }
            else if (result == DialogResult.No)
            {
                DialogResult result2 = MessageBox.Show("不然今天是星期一嗎?", "請問", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result2 == DialogResult.Yes)
                {
                    MessageBox.Show("是的");
                }
                else
                {
                    MessageBox.Show("今天不是禮拜二也不是禮拜三");
                }
            }
        }

        private void btnDialog_Click(object sender, EventArgs e)
        {
            Form_M02_HelloForm form02 = new Form_M02_HelloForm();
            form02.ShowDialog();
        }
    }
}
