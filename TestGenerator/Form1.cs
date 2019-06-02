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
			set {  }
		}

		public t.Question Question
		{
			get { return new t.Question(questionTextBox.Text); }
			set {  }
		}

		public t.Answer Answer
		{ 
			get { return new t.Answer(answerTextBox.Text, 0); }
			set {  }
		}


		private void addAuthorButton_Click(object sender, EventArgs e)
		{
			Author = GetAuthorEvent();
			
			MessageBox.Show(Author.Name);
		}

		private void testNameButton_Click(object sender, EventArgs e)
		{
			var n = testNameLabel.Text;
			generatedTest.TestName = n;
		}

		private void addQuesionButton_Click(object sender, EventArgs e)
		{
			Question = GetQuestionEvent();
			generatedTest.addQuestion(Question);
			//questionsTabControl.TabPages.Add(Question.GetQuestion);
			int index = questionsTabControl.TabCount + 1;
			questionsTabControl.Controls.Add(new TabPage("Pytanie" + index.ToString()));
			questionsTabControl.SelectedTab = questionsTabControl.TabPages[index - 1];
			ListBox lb = new ListBox();
			
					
			lb.Dock = DockStyle.Fill;
			lb.Parent = questionsTabControl.TabPages[index - 1];
			lb.Items.Add("Pytanie: "+Question.GetterQuestion);
			//MessageBox.Show(generatedTest.ShowQuestions());
		}

		private void addAsnwerButton_Click(object sender, EventArgs e)
		{
			
			if (questionsTabControl.TabPages.Count != 0)
			{
				var v = questionsTabControl.SelectedIndex;
				Answer = GetAnswerEvent();
				generatedTest.AddAnswers(v, Answer);
				foreach (ListBox c in questionsTabControl.SelectedTab.Controls)
				{
					if(c is ListBox)
					{
						c.Items.Add((c.Items.Count).ToString()+". "+Answer.GetAnswer);
					}
				}

			}
			else
				MessageBox.Show("Brak pytań do których możesz dodać odpowiedź!");
		}

		private void scoreAddButton_Click(object sender, EventArgs e)
		{
			generatedTest.PercentToPass = (double)scoreNumericUpDown.Value;
			double a = (double)scoreNumericUpDown.Value;
			a += 10;
			MessageBox.Show(a.ToString());
		}

		private void changeAnswerButton_Click(object sender, EventArgs e)
		{

		}

		private void setAnswerPointsButton_Click(object sender, EventArgs e)
		{
			foreach (ListBox c in questionsTabControl.SelectedTab.Controls)
			{
				if (c is ListBox)
				{
					if (c.SelectedIndex > 0)
					{
						//public void SetPoints(int questionIndex, int answerIndex, double points);
						generatedTest.SetPoints(questionsTabControl.SelectedIndex, c.SelectedIndex, (double)answerPointsNumericUpDown.Value);
						c.Items[c.SelectedIndex] += "\t(Punkty: " + answerPointsNumericUpDown.Value.ToString() + ")";
						//c.Update();
					}
					else
						MessageBox.Show("Zaznacz odpowiedź!!!");
				}
			}
		}
	}
}
