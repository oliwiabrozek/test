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
        Question questionLibrary;
        List<Answer> answerLibrary;
        public PresenterDesign(ModelTest model, InterfaceTest viev)
        {
            this.model = model;
            this.vievTest = viev;
            this.vievTest.Design.LoadTestName += VievLoadTestName;
            this.vievTest.Design.LoadQuestions += VievLoadQuestion;
            this.vievTest.Design.LoadAnswers += VievLoadAnswers; 
            
        }

        private void VievLoadTestName()
        {
            testLibrary = model.CreateTest();
            vievTest.Design.TestName = testLibrary.GetTestName(); 
        }
        private void VievLoadQuestion(int index)
        {
            if (model.AmountOfQuestions() > index)
                vievTest.Design.QuestionValue = testLibrary.GetQuestsionListElement(index).GetQuestion();
            else
                MessageBox.Show("Tu będzie zdarzenie wyświetlające podsumowanie testu.");
        }

        private void VievLoadAnswers(int index)
        {
            vievTest.Design.CheckboxAValue = testLibrary.GetQuestsionListElement(index).GetAnswerListElement(0).GetAnswer();
            vievTest.Design.CheckboxBValue = testLibrary.GetQuestsionListElement(index).GetAnswerListElement(1).GetAnswer();
            vievTest.Design.CheckboxCValue = testLibrary.GetQuestsionListElement(index).GetAnswerListElement(2).GetAnswer();
            vievTest.Design.CheckboxDValue = testLibrary.GetQuestsionListElement(index).GetAnswerListElement(3).GetAnswer();
        }
    }
}
