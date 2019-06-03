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
        private double maxAmountOfPoints;
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

		public string TestName
		{
			get { return this.testName; }
			set { testName = value; }
		}

		public double PercentToPass
		{
			get { return this.percentToPass; }
			set { percentToPass = value; }
		}


		public bool checkIfQuesInList(Question q)
		{
			if (questionsList.Contains(q))
			{
				return true;
			}
			else
				return false;
		}

		public void AddAnswers(int i, Answer a)
		{
			questionsList[i].AnswersList.Add(a);
		}

		public String GetTestName()
        {
            return testName;
        }

        public Question GetQuestsionListElement(int index)
        {
            return questionsList[index];
        }

        public List<Question> GetQUestionList()
        {
            return questionsList;
        }

		public void SetPoints(int questionIndex, int answerIndex, double points)
		{
			questionsList[questionIndex].AnswersList[answerIndex-1].Points = points;
		}

	}

	public class Author
	{
		private string name;

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
        private List<Answer> answersList;
        private uint index;
        public Question () {}
        public Question(String question)
        {
			this.answersList = new List<Answer> { };
            this.question = question;
        }
        public Question(String question, List<Answer> answerList, uint index)
        {
			this.answersList = new List<Answer> { };
            this.answersList = answerList;
			this.question = question;
            this.index = index;
        }

        public String GetQuestion()
        {
            return question;
        }

		public string GetterQuestion
		{
			get { return this.question; }
		}

		public List<Answer> AnswersList
		{
			get { return this.answersList; }
		}

        public Answer GetAnswerListElement(int index)
        {
            return answersList[index];
        }


    }

	public class Answer
	{
        private string answer;
        private double points; // dla tego konkretnego pytania

		//mój konstruktor - Oliwia
		public Answer(string answer, uint questionIndex)
		{
			this.answer = answer;
			
		}

        public Answer(string answer, double points)
        {
            this.answer = answer;
            this.points = points;
        }


        public string GetAnswer
		{
			get { return this.answer; }
			set { this.answer = value; }
		}

        public string GetAnswerr()
        {
            return answer;
        }

        public double Points
		{
			get { return this.points; }
			set { this.points = value; }
		}
	}

	public class Score
	{
        private double points = 0;
        public double Points
        {
            get { return this.points; }
            set { this.points = value; }
        }
        // liczy wynik dla całego testu? 
    }
}
