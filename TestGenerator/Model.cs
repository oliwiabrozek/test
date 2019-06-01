using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using t = TestLibrary;

namespace TestGenerator
{
	public class Model
	{
		private t.Author author;
		private t.Question question;
		private t.Answer answer;

		public Model() { }

		public t.Author Author
		{
			get { return author; }
			set { author = value; }
		}
		public t.Question Question
		{
			get { return question; }
			set { question = value; }
		}
		public t.Answer Answer
		{
			get { return answer; }
			set { answer = value; }
		}
	}
}
