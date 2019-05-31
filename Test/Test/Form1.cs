using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Test.Viev;
namespace Test
{
	public partial class Form1 : Form, InterfaceTest
	{
		public Form1()
		{
			InitializeComponent();
		}

        InterfaceDesign InterfaceTest.Design
        {
            get
            {
                return testRunDesign;
            }
        }
    }
}
