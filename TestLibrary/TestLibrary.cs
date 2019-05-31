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
