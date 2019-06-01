using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Windows.Forms;
using TestLibrary;
namespace Test
{
    class XmlReader
    {
        public XmlDocument XmlDoc;
        public XDocument XmlDoc2;
        public XmlReader(String Path)
        {
            XmlDoc = new XmlDocument();
            if (File.Exists(Path))
            {
                XmlDoc.Load(Path); //Załadowanie pliku XML do pamięci przy pomocy gotowej metody klasy XmlDocument
                XmlDoc2 = XDocument.Load(Path);
            }
            else
            {
                MessageBox.Show("Something is wrong, file XMLTest.xml does not exist. ");
                System.Environment.Exit(0);
            }
            //Console.WriteLine("po załądowaniu pliku");
            //LoadQuestions();
        }

        public int GetNumberOfItems(string name) //zwraca liczbę interesujących mnie znaczników w dokumencie XML
        {
            return XmlDoc.DocumentElement.GetElementsByTagName(name).Count;
        }

        public string GetElementValue(int number, string name) //wyciagnięcie wartości ze znacznika o danym indeksie i nazwie
        {
            return XmlDoc.GetElementsByTagName(name).Item(number).InnerText;
        }

        public string GetAttributeValue(int number, string ElementName, string AttributeName) //zwróci wartość danego atrybutu dla danego znacznika o danym indeksie
        {
            XmlNode Node = XmlDoc.GetElementsByTagName(ElementName).Item(number);
            return Node.Attributes.GetNamedItem(AttributeName).InnerText;
        }

        public List<String> GetAnswersForSelectedQuestion(uint index)
        {
            List<String> ListOfAnswers = new List<String>();

            return ListOfAnswers;
        }

        /*public List<Question> LoadQuestions()
        {
            int n = GetNumberOfItems("question");
            if (n <= 0)
            {
                MessageBox.Show("There are no questions in the XML file.");
                System.Environment.Exit(0);
            }
            List<Question> question = new List<Question>();
            for (int k = 0; k < n; k++)
            {
                question.Add(new Question(GetAttributeValue(k, "question", "content"), uint.Parse(GetAttributeValue(k, "question", "index"))));
            }
            GetAnswersForSelectedQuestion(1);
            Console.WriteLine(question.Count);
            foreach (Question i in question)
            {
                Console.WriteLine("Pytanie: " + i.question + i.index);
            }
            return question;
        }*/

        public Question LoadQuestion(int index)
        {
            Console.WriteLine("halo alo");
            int n = GetNumberOfItems("question");
            if (n <= 0)
            {
                MessageBox.Show("There are no questions in the XML file.");
                System.Environment.Exit(0);
            }
            if(index == n)
            {
                MessageBox.Show("End.");
                System.Environment.Exit(0);
            }
            //List<Question> question = new List<Question>();
            Question tmp = new Question(GetAttributeValue(index, "question", "content"), uint.Parse(GetAttributeValue(index, "question", "index")));
            return tmp;
        }
    }
}
