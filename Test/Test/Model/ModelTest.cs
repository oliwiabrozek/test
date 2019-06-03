using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TestLibrary;

namespace Test.Model
{
    class ModelTest
    {
        XmlReader xml = new XmlReader(ModelLoadPath());
        TestLibrary.Test libraryT = new TestLibrary.Test();
        Score score = new Score();
        Question libraryQ = new Question();
        double max = 0;
        public static String ModelLoadPath()
        {
            string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory.ToString()).ToString()).ToString()).ToString() + @"\XMLTest.xml";
            return path;
        }

        public TestLibrary.Test CreateTest()
        {
            TestLibrary.Test tmp = new TestLibrary.Test(xml.GetAttributeValue(0, "test", "name"), PercentToPass(), CreateQuestion());
            return tmp;
        }

        public int AmountOfQuestions()
        {
            return xml.GetNumberOfItems("question");
        }

        public List<Question> CreateQuestion() //pobiera wszystkie pytania z pliku XML do listy
        {
            int n = xml.GetNumberOfItems("question");
            if (n <= 0)
            {
                Console.WriteLine("KONIEC PYTAN");
                System.Environment.Exit(0);
            }
            List<Question> question = new List<Question>();

            for (int k = 0; k < n; k++)
            {
                question.Add(new Question(xml.GetAttributeValue(k, "question", "content"), CreateAnswers((uint)(k)), uint.Parse(xml.GetAttributeValue(k, "question", "index"))));
            }
            return question;
        }

        public List<Answer> CreateAnswers(uint index)//tworzy obiekty z odpowiedziami dla pytania o zadanym indeksie
        {
            List<Answer> ListOfAnswers = new List<Answer>();
            List<string> answers = xml.GetAnswersForCurrentQuestion(index);
            List<double> points = xml.GetPointForCurrentAnswers(index);
            CountMaxScore(points);
            int x = 0;
            foreach (String element in answers)
            {
                ListOfAnswers.Add(new Answer(element, points[x]));
                x++;
            }
            return ListOfAnswers;
        }

        public void AddPoint(double point)
        { 
            score.Points = score.Points + point;
            Console.WriteLine("SCORE: " + score.Points);
        }

        public double Score()
        {
            return score.Points;
        }

        public double PercentToPass()
        {
            return xml.GetPercentToPass();
        }

        public void CountMaxScore(List<double> points)
        {
            /*foreach (double xd in points)
                Console.WriteLine("ASD: " + xd);*/
            max = max + points.Max();
            //Console.WriteLine("MAX: " + max);
        }

        public double GetMaxScore()
        {
            Console.WriteLine(max);
            return max;
        }

        public int AmountOfQuestions(List<Answer> listOfQuestions)
        {
            return listOfQuestions.Count();
        }

    }

}
