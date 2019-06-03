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
			get { return new t.Answer(answerTextBox.Text, 0.0); }
			set {  }
		}


		private void addAuthorButton_Click(object sender, EventArgs e)
		{
			Author = GetAuthorEvent();
			generatedTest.SetAuthor = Author;
			
			MessageBox.Show(Author.Name);
		}

		private void testNameButton_Click(object sender, EventArgs e)
		{
			var n = testNameTextBox.Text;
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

			generatedTest.GetQuestsionListElement(index - 1).QuestionIndex = index - 1;
			//MessageBox.Show(generatedTest.ShowQuestions());
		}

		private void addAsnwerButton_Click(object sender, EventArgs e)
		{
			
			if (questionsTabControl.TabPages.Count != 0)
			{
				//var v =
					//generatedTest.GetQuestsionListElement(questionsTabControl.SelectedIndex).GetAnswersListCount();
				var v = questionsTabControl.SelectedIndex;
				Answer = GetAnswerEvent();
				generatedTest.AddAnswers(v, Answer);
				foreach (ListBox c in questionsTabControl.SelectedTab.Controls)
				{
					if(c is ListBox)
					{
						c.Items.Add((c.Items.Count).ToString() + ". " + Answer.GetAnswer + "\t (Punkty: "
							+ Answer.Points.ToString() + ")");
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
	
			foreach (ListBox c in questionsTabControl.SelectedTab.Controls)
			{
				if (c is ListBox)
				{
					if (c.SelectedIndex > 0)
					{
						generatedTest.changeAnswer(generatedTest.QuestionsList, questionsTabControl.SelectedIndex,
						c.SelectedIndex-1, answerTextBox.Text);
						c.Items[c.SelectedIndex] = c.SelectedIndex.ToString() + ". " +
							generatedTest.GetQuestsionListElement(questionsTabControl.SelectedIndex).GetAnswerListElement(c.SelectedIndex - 1).GetAnswer.ToString()
							+ "\t(Punkty: " + generatedTest.GetPoints(questionsTabControl.SelectedIndex, c.SelectedIndex - 1).ToString()
							+ ")";
					}
					else
						MessageBox.Show("Proszę zaznaczyć odpowiedź!");
					
				}
			}


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
						c.Items[c.SelectedIndex] = c.SelectedIndex.ToString() + ". "+
							generatedTest.GetQuestsionListElement(questionsTabControl.SelectedIndex).GetAnswerListElement(c.SelectedIndex-1).GetAnswer
							+"\t(Punkty: " + answerPointsNumericUpDown.Value.ToString() + ")";
						//c.Update();
					}
					else
						MessageBox.Show("Zaznacz odpowiedź!!!");
				}
			}
		}

		private void changeQuestionButton_Click(object sender, EventArgs e)
		{
			generatedTest.changeQuestion(generatedTest.QuestionsList, questionsTabControl.SelectedIndex,
				questionTextBox.Text);
			

			foreach (ListBox c in questionsTabControl.SelectedTab.Controls)
			{
				if (c is ListBox)
				{
					c.Items[0] = "Pytanie: " + generatedTest.GetQuestsionListElement(questionsTabControl.SelectedIndex).GetQuestion();
					
				}
			}

		}

		private void deleteQuestionButton_Click(object sender, EventArgs e)
		{
			generatedTest.QuestionsList.RemoveAt(questionsTabControl.SelectedIndex);
			questionsTabControl.TabPages.RemoveAt(questionsTabControl.SelectedIndex);
			int i = 1;

			foreach(TabPage tp in questionsTabControl.TabPages)
			{
				tp.Text = "Pytanie " + i.ToString();
				generatedTest.GetQuestsionListElement(i - 1).QuestionIndex = i - 1;
				i++;
			}
		}

		private void deleteAnswerButton_Click(object sender, EventArgs e)
		{
			
			foreach (ListBox c in questionsTabControl.SelectedTab.Controls)
			{
				if (c is ListBox)
				{
					if (c.SelectedIndex > 0)
					{
						var selInd = c.SelectedIndex;
						generatedTest.GetQuestsionListElement(questionsTabControl.SelectedIndex).AnswersList.RemoveAt(c.SelectedIndex - 1);
						c.Items.RemoveAt(selInd);
						c.Update();

						for (int i = 0; i < c.Items.Count - 1; i++)
						{
							c.Items[i + 1] = (i + 1).ToString() + ". " +
							generatedTest.GetQuestsionListElement(questionsTabControl.SelectedIndex).GetAnswerListElement(i).GetAnswer
							+ "\t(Punkty: " +
							generatedTest.GetPoints(questionsTabControl.SelectedIndex, i) + ")";
							
						}
					}
					else
						MessageBox.Show("Proszę zaznaczyć odpowiedź!");

					

				}
			}
			
		}

		private void saveTestButton_Click(object sender, EventArgs e)
		{
			generatedTest.SaveToFile("e:");
		}
	}
}
