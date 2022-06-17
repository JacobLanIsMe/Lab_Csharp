using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class MyFirstClass
    {
        private void Method01()
        {
            MessageBox.Show("Method01, private");
        }
        protected void Method02()
        {
            MessageBox.Show("Method02, protected");
        }
        public void Method03()
        {
            MessageBox.Show("Method03, public");
        }
        internal void Method04()
        {
            MessageBox.Show("Method04, internal");
        }
        protected internal void Method05()
        {
            MessageBox.Show("Method05, protected internal");
        }
        public void Method06()
        {
            Method01();
        }
    }
}
