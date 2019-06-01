using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using t = TestLibrary;

namespace TestGenerator
{
	public interface IView
	{
		//events
		event Func<t.Author> GetAuthorEvent;
		event Func<t.Question> GetQuestionEvent;
		event Func<t.Answer> GetAnswerEvent;
		//getters & setters
		t.Author Author { get; set; }
		t.Question Question { get; set; }
		t.Answer Answer { get; set; }
		

	}  
}
