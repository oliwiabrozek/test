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
            this.vievTest.Design.AddPoints += VievAddPoints;
            this.vievTest.Design.Summary += VievSummary;
        }

        private void VievLoadTestName()
        {
            testLibrary = model.CreateTest();
            vievTest.Design.TestName = testLibrary.GetTestName();
            vievTest.Design.AmountOfQuestions = model.AmountOfQuestions(); //ilosc pytan do warunku
        }
        private void VievLoadQuestion(int index)
        {
            if (model.AmountOfQuestions() > index)
                vievTest.Design.QuestionValue = testLibrary.GetQuestsionListElement(index).GetQuestion();
            else
                MessageBox.Show("Tu będzie zdarzenie wyświetlające podsumowanie testu.");
        }

        private void VievLoadAnswers(int index)
        {   //te elementy powinny sie pobierać z modelu
            Console.WriteLine("ILOŚ PYTAŃ: " + model.AmountOfQuestions(testLibrary.GetQUestionList()));
            vievTest.Design.CheckboxAValue = testLibrary.GetQuestsionListElement(index).GetAnswerListElement(0).GetAnswer;
            vievTest.Design.CheckboxBValue = testLibrary.GetQuestsionListElement(index).GetAnswerListElement(1).GetAnswer;
            vievTest.Design.CheckboxCValue = testLibrary.GetQuestsionListElement(index).GetAnswerListElement(2).GetAnswer;
            vievTest.Design.CheckboxDValue = testLibrary.GetQuestsionListElement(index).GetAnswerListElement(3).GetAnswer;
        }

        private void VievAddPoints(int indexQue, int indexAns)
        {
           model.AddPoint(testLibrary.GetQuestsionListElement(indexQue-1).GetAnswerListElement(indexAns).Points);
        }

        private void VievSummary()
        {
            double percentToPass = model.PercentToPass();
            double score = model.Score();
            double maxScore = model.GetMaxScore();
            double percentScore;
            if (score <= 0)
                 percentScore = 0;
            else
                percentScore = Math.Round((score / maxScore), 2) * 100;

            String result;
            if (percentScore >= percentToPass)
                result = "pozytywny";
            else
                result = "negatywny";

            MessageBox.Show("Liczba uzyskanych punktów: " + score  + "\nLiczba maksymalna punktów: " + maxScore + "\n" + "Wynik procentowy: " + percentScore + "\nWymagana ilość procent do zdania: " + percentToPass + "\n\nWynik testu: " + result);
        }
    }
}
