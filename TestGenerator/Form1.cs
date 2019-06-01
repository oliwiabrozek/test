using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using t = TestLibrary;


namespace TestGenerator
{
	public partial class Form1 : Form, IView
	{
		private t.Test generatedTest = new t.Test();


		public event Func<t.Author> GetAuthorEvent;
		public event Func<t.Question> GetQuestionEvent;
		public event Func<t.Answer> GetAnswerEvent;

		public Form1()
		{
			InitializeComponent();
		}
		
		public t.Author Author
		{
			get { return new t.Author(authorTextBox.Text); }
			set { Author.name = authorTextBox.Text; }
		}

		public t.Question Question
		{
			get { return new t.Question(questionTextBox.Text); }
			set { Question.question = questionTextBox.Text; }
		}

		public t.Answer Answer
		{ 
			get { return new t.Answer(questionTextBox.Text, 0); }
			set { Question.question = questionTextBox.Text; }
		}


		private void addAuthorButton_Click(object sender, EventArgs e)
		{
			Author = GetAuthorEvent();
			
			MessageBox.Show(Author.name);
		}

		private void testNameButton_Click(object sender, EventArgs e)
		{
			
		}

		private void addQuesionButton_Click(object sender, EventArgs e)
		{
			Question = GetQuestionEvent();
			generatedTest.addQuestion(Question);
		}

		private void addAsnwerButton_Click(object sender, EventArgs e)
		{
			Answer = GetAnswerEvent();
			//generatedTest.addAnswer()
		}
	}
}
