using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGenerator
{
	static class Program
	{
		//TestGenerator

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Model model = new Model();
			Form1 form = new Form1();
			Presenter p = new Presenter(model, form);
			Application.Run(form);
		}
	}
}
