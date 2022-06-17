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
    public partial class Form_M04_OpenHelloForm : Form
    {
        public Form_M04_OpenHelloForm()
        {
            InitializeComponent();
        }

        private void btnOpenHelloForm_Click(object sender, EventArgs e)
        {
            Form_M02_HelloForm helloForm = new Form_M02_HelloForm();
            helloForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyFirstMethod();
        }
        void MyFirstMethod()
        {
            MessageBox.Show("My First Method!");
        }

        private void btnMethod_Click_1(object sender, EventArgs e)
        {
            MyFirstClass cs = new MyFirstClass();
            cs.Method03();
            cs.Method04();
            cs.Method05();
        }
        
        string BirthYear(int Age)
        {
            int birthYear = DateTime.Now.Year - Age;
            string result = birthYear.ToString();
            return result;
        }

        private void btnBirthYear_Click(object sender, EventArgs e)
        {
            string birthYear = BirthYear(100);
            MessageBox.Show($"你的出生年分為{birthYear}年");
        }

        private void btnEncapsulation_Click(object sender, EventArgs e)
        {
            MyFirstClass mc = new MyFirstClass();
            mc.Method06();
        }

        private void btnPartialClass_Click(object sender, EventArgs e)
        {
            MyFirstClass mc = new MyFirstClass();
            mc.Method07();
        }
    }
}
