using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Viev;
namespace Test
{
    public partial class TestRunDesign : UserControl, InterfaceDesign
    {
        public event Action LoadPath, LoadTestName;
        public TestRunDesign()
        {
            InitializeComponent();
            Console.WriteLine("TestRunDesigner konstruktor");
            if(LoadPath != null)
                LoadPath();
        }

        public String Path
        {
            set
            {
                Console.WriteLine("Path set");
                labelTestNameValue.Text = value;
            }
        }
        public String TestName
        {
            set
            {
                labelTestNameValue.Text = value;
            }
        }

        private void buttonNextQuestion_Click(object sender, EventArgs e)
        {
            if (LoadTestName != null)
                LoadTestName();
            //Next question implementation
        }
    }
}
