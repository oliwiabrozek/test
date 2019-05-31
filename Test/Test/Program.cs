using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Test.Model;
using Test.Viev;
using Test.Presenter;
namespace Test
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
            Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
            ModelTest model = new ModelTest();
            InterfaceTest viev = new Form1();
            PresenterDesign presenter = new PresenterDesign(model, viev);
			Application.Run((Form)viev);
            
		}
	}
}
