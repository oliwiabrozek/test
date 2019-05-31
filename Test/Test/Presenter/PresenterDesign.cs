using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Model;
using Test.Viev;
namespace Test.Presenter
{
    class PresenterDesign
    {
        ModelTest model;
        InterfaceTest vievTest;
        InterfaceDesign vievDesign;
        public PresenterDesign(ModelTest model, InterfaceTest viev)
        {
            Console.WriteLine("Presenter konstruktor");
            this.model = model;
            this.vievTest = viev;
            this.vievTest.Design.LoadPath += VievLoadPath;
            this.vievTest.Design.LoadTestName += VievLoadTestName;
        }

        private void VievLoadPath()
        {
            Console.WriteLine("Presenter VievLoadPath");
            vievTest.Design.Path = ModelTest.ModelLoadPath();
        }

        private void VievLoadTestName()
        {
            vievTest.Design.TestName = model.LoadTestName();
        }
    }
}
