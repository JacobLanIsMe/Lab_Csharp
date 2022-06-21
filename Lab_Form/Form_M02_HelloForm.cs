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
    public partial class Form_M02_HelloForm : Form
    {
        public Form_M02_HelloForm()
        {
            InitializeComponent();
        }
        public string name;
        public string engName;
        public string gender;
        public string zodiac;
        private void btnHello_Click(object sender, EventArgs e)
        {
            name = textBoxChiName.Text;
            engName = textBoxEngName.Text;
            gender = textBoxGender.Text;
            zodiac = textBoxZodiac.Text;
            string helloResult = $"Hello, 我是{name}\n英文名字是{engName}\n性別是{gender}\n星座是{zodiac}\n很高興認識你。";
            MessageBox.Show(helloResult);
        }

        private void btnHi_Click(object sender, EventArgs e)
        {
            name = textBoxChiName.Text;
            engName = textBoxEngName.Text;
            gender = textBoxGender.Text;
            zodiac = textBoxZodiac.Text;
            string helloResult = $"Hi, 我是{name}\n英文名字是{engName}\n性別是{gender}\n星座是{zodiac}\n很高興認識你。";
            MessageBox.Show(helloResult);
            MessageBox.Show(InstanceStatic.staticCount.ToString());
        }
    }
}
