using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Model;
using Test.Viev;
using TestLibrary;
namespace Test.Presenter
{
    class PresenterDesign
    {
        ModelTest model;
        InterfaceTest vievTest;
        InterfaceDesign vievDesign;
        TestLibrary.Test tmp;
        public PresenterDesign(ModelTest model, InterfaceTest viev)
        {
            this.model = model;
            this.vievTest = viev;
            this.vievTest.Design.LoadTestName += VievLoadTestName;
            this.vievTest.Design.LoadQuestions += VievLoadQuestions;
            
        }

        private void VievLoadTestName()
        {
            tmp = model.TestObiektów();
            vievTest.Design.TestName = tmp.testName; 
        }
        public void VievLoadQuestions(int index)
        {
            Console.WriteLine("Pierwszy obieg");
            vievTest.Design.QuestionValue = tmp.questionsList[index].question;
        }
    }
}
