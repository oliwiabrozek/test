using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Model;
using Test.Viev;
using TestLibrary;
using System.Windows.Forms;
namespace Test.Presenter
{
    class PresenterDesign
    {
        ModelTest model;
        InterfaceTest vievTest;
        InterfaceDesign vievDesign;
        TestLibrary.Test testLibrary;
        public PresenterDesign(ModelTest model, InterfaceTest viev)
        {
            this.model = model;
            this.vievTest = viev;
            this.vievTest.Design.LoadTestName += VievLoadTestName;
            this.vievTest.Design.LoadQuestions += VievLoadQuestions;
            
        }

        private void VievLoadTestName()
        {
            testLibrary = model.CreateTest();
            vievTest.Design.TestName = testLibrary.GetTestName(); 
        }
        public void VievLoadQuestions(int index)
        {
            if (model.AmountOfQuestions() > index)
                vievTest.Design.QuestionValue = testLibrary.GetQuestsionListElement(index).GetQuestion();
            else
                MessageBox.Show("Tu będzie zdarzenie wyświetlające podsumowanie testu.");
        }
    }
}
