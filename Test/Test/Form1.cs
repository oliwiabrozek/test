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
        public event Action<string> LoadPath;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            testRunDesign.Visible = false;
        }

        private void buttonTestChoice_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LoadPath(openFileDialog1.FileName);
                Console.WriteLine(openFileDialog1.FileName);
                testRunDesign.StartTest();
                testRunDesign.Visible = true;
            }
        }
    }
}
