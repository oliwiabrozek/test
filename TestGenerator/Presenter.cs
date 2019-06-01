using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using t = TestLibrary;

namespace TestGenerator
{
	public class Presenter
	{
		Model model;
		IView view;

		public Presenter(Model model, IView view)
		{
			this.model = model;
			this.view = view;
			view.GetAuthorEvent += GetAuthor;
			view.GetQuestionEvent += GetQuestion;
			view.GetAnswerEvent += GetAnswer;
		}

		private t.Author GetAuthor()
		{
			return model.Author;
		}

		private t.Question GetQuestion()
		{
			return model.Question;
		}

		private t.Answer GetAnswer()
		{
			return model.Answer;
		}

	}
}
