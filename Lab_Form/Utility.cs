using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    partial class MyFirstClass
    {
        public void Method07()
        {
            MessageBox.Show("Method07 partial class");
        }
    }
    public class Member
    {
        public string Name;
        public int Age;
    }
    public class InstanceStatic
    {
        public int instanceCount;
        public static int staticCount;
    }
}
