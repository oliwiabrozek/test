using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
	public class T
	{
		List<Question> questionsList;
		double percentToPass;
		String testName;
	}

	public class Author
	{
		string name;
	}

    public class Question
    {
		String question;
		List<Answer> answersList;
		uint index;
		// czas na odpowiedź
    }

	public class Answer
	{
		public string answer;
		double points; // dla tego konkretnego pytania
		public void pytaj()
		{

		}
	}

	public class Score
	{
		// liczy wynik dla całego testu? 
	}
}
