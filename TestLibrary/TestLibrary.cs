using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
	public class Test
	{
        public List<Question> questionsList;
        public double percentToPass;
		public String testName;
        public Test() { }
        public Test(String name, double percentToPass, List<Question> questionList)
        {
            this.testName = name;
            this.percentToPass = percentToPass;
            this.questionsList = questionList;
        }
	}

	public class Author
	{
		public string name;
	}

    public class Question
    {
        public String question;
        public List<Answer> answersList;
        public uint index;
        public Question () {}
        public Question(String question)
        {
            this.question = question;
        }
        public Question(String question,/* List<Answer> answerList,*/ uint index)
        {
            this.question = question;
            //this.answersList = answersList;
            this.index = index;
        }
		// czas na odpowiedź
    }

	public class Answer
	{
        public string answer;
        public double points; // dla tego konkretnego pytania
		public void pytaj()
		{

		}
	}

	public class Score
	{
		// liczy wynik dla całego testu? 
	}
}
