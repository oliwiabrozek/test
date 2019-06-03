using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TestLibrary
{
	public class Test
	{

		private List<Question> questionsList;
        private double percentToPass;
		private String testName;
		private Author author;
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

		public Test(String name, double percentToPass, List<Question> questionList, Author author)
		{
			questionsList = new List<Question> { };
			this.testName = name;
			this.percentToPass = percentToPass;
			this.questionsList = questionList;
			this.author = author;
		}

		public Author SetAuthor
		{
			//get { return this.author; }
			set { this.author = value; }
		}

		public void addQuestion(Question question)
		{
			questionsList.Add(question);
		}
		
		public List<Question> QuestionsList
		{
			get { return this.questionsList; }
		}

		public void changeQuestion(List<Question> questionsList, int questionTabIndex, string question)
		{
			questionsList[questionTabIndex].QuestionContent = question;
		}

		public void changeAnswer(List<Question> quesList, int quesTabIndex, int ansIndex, string answer)
		{
			questionsList[quesTabIndex].GetAnswerListElement(ansIndex).GetAnswer = answer;
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

		public void SetPoints(int questionIndex, int answerIndex, double points)
		{
			questionsList[questionIndex].AnswersList[answerIndex-1].Points = points;
		}
		public double GetPoints(int questionIndex, int answerIndex)
		{
			return questionsList[questionIndex].GetAnswerListElement(answerIndex).Points;
		}

		public XmlElement questionsListToXmlElement(XmlDocument doc)
		{
			XmlElement element = doc.CreateElement("questions");
			foreach (Question question in questionsList)
			{
				element.AppendChild(question.ToXmlElement(doc));
			}
			return element;
		}

		public XmlElement ToXmlElement(XmlDocument doc)
		{
			XmlElement element = doc.CreateElement("test");
			element.AppendChild(this.author.ToXmlElement(doc));
			element.AppendChild(this.questionsListToXmlElement(doc));
			XmlAttribute nameAttribute = doc.CreateAttribute("name");
			nameAttribute.InnerText = this.testName;
			element.Attributes.Append(nameAttribute);
			XmlAttribute percentToPassAttribute = doc.CreateAttribute("percent_to_pass");
			percentToPassAttribute.InnerText = this.PercentToPass.ToString();
			element.Attributes.Append(percentToPassAttribute);
			return element;
		}
		public void SaveToFile(string path)
		{
			XmlDocument doc = new XmlDocument();
			doc.AppendChild(ToXmlElement(doc));
			doc.Save(path + "\\" + GetTestName() + ".xml");
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

		public XmlElement ToXmlElement(XmlDocument doc)
		{
			XmlElement element = doc.CreateElement("author");
			element.InnerText = this.name;
			return element;
		}

	}

    public class Question
    {
        private String question;
        private List<Answer> answersList;
        private uint index;
		private int questionIndex;

		public int QuestionIndex
		{
			get { return this.questionIndex; }
			set { this.questionIndex = value; }
		}

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

		public Answer GetAnswerListElement(int index)
		{
			return answersList[index];
		}

		public int GetAnswersListCount()
		{
			return answersList.Count();
		}

		public void SetAnswerListElement(int index, string answer)
		{
			answersList[index].GetAnswer = answer;
		}

		public String GetQuestion()
        {
            return question;
        }

		public string QuestionContent
		{
			get { return this.question; }
			set { this.question = value; }
		}

		public string GetterQuestion
		{
			get { return this.question; }
		}

		public List<Answer> AnswersList
		{
			get { return this.answersList; }
		}



		public XmlElement ToXmlElement(XmlDocument doc)
		{
			XmlElement element = doc.CreateElement("question");
			foreach (Answer answer in answersList)
			{
				element.AppendChild(answer.ToXMLElement(doc));
			}
			XmlAttribute contentAttribute = doc.CreateAttribute("content");
			contentAttribute.InnerText = question;
			element.Attributes.Append(contentAttribute);
			XmlAttribute indexAttribute = doc.CreateAttribute("index");
			indexAttribute.InnerText = questionIndex.ToString();
			element.Attributes.Append(indexAttribute);
			return element;
		}


	}

	public class Answer
	{
        private string answer;
        private double points; // dla tego konkretnego pytania

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

        public double Points
		{
			get { return this.points; }
			set { this.points = value; }
		}

		public XmlElement ToXMLElement(XmlDocument doc)
		{
			XmlElement element = doc.CreateElement("answer");
			element.InnerText = this.answer;
			XmlAttribute attribute = doc.CreateAttribute("points");
			attribute.InnerText = this.points.ToString();
			element.Attributes.Append(attribute);
			return element;
		}

	}


}
