using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
	public class Test
	{

		private List<Question> questionsList;
        private double percentToPass;
		private String testName;
        public Test()
		{
			questionsList = new List<Question> { };
		}
        public Test(String name, double percentToPass, List<Question> questionList)
        {
			questionsList = new List<Question> { };
            this.testName = name;
            this.percentToPass = percentToPass;
            this.questionsList = questionList;
        }

		public void addQuestion(Question question)
		{
			questionsList.Add(question);
		}

		public void addAnswer(int questionIndex, Answer answer)
		{
			//questionsList[questionIndex].
		}

        public String GetTestName()
        {
            return testName;
        }

        public Question GetQuestsionListElement(int index)
        {
            return questionsList[index];
        }


	}

	public class Author
	{
		public string name;

		public Author(string name)
		{
			this.name = name;
		}

		public string Name
		{
			get { return this.name;}
			set { name = value; }
		}

	}

    public class Question
    {
        private String question;
        public List<Answer> answersList;
        public uint index;
        public Question () {}
        public Question(String question)
        {
			this.answersList = new List<Answer> { };
            this.question = question;
        }
        public Question(String question,/* List<Answer> answerList,*/ uint index)
        {
			this.answersList = new List<Answer> { };
			this.question = question;
            this.index = index;
        }

        public String GetQuestion()
        {
            return question;
        }


		
		
		// czas na odpowiedź
    }

	public class Answer
	{
        public string answer;
        public double points; // dla tego konkretnego pytania
		private uint index;
		private uint questionIndex; //indeks pytania dla tej odpowiedzi

		//mój konstruktor - Oliwia
		public Answer(string answer, uint questionIndex)
		{
			this.answer = answer;
			this.questionIndex = questionIndex;
		}
	}

	public class Score
	{
		// liczy wynik dla całego testu? 
	}
}
