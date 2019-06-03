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
            //GetAnswersForCurrentQuestion(1);
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

        public List<string> GetAnswersForCurrentQuestion(uint index)
        {
            List<string> Answers = new List<string>();
            XmlNodeList answers = XmlDoc.SelectNodes("/test/questions/question[@index = '" + index + "']");
            foreach (XmlNode node in answers)
            {
                if (node.HasChildNodes)
                {
                    foreach (XmlNode item in node.ChildNodes)
                        Answers.Add(item.InnerText);
                }
            }
            return Answers;
        }

        public List<double> GetPointForCurrentAnswers(uint index)
        {
            List<double> ListOfPoints = new List<double>();
            XmlNodeList points = XmlDoc.SelectNodes("/test/questions/question[@index = '" + index + "']/answer[@points]");
            int i;
            if (index == 1)
                i = 0;
            else
                i = (int)(index * 4) - 4;
            foreach (XmlNode node in points)
            {
                foreach (XmlNode item in node)
                {
                    ListOfPoints.Add(double.Parse(GetAttributeValue(i, "answer", "points")));
                    i++;
                }
            }
            return ListOfPoints;
        }

        public double GetPointForSelectedAnswer(List<double> ListOfPoints, int selectedAnswer)
        {
            double pointsMAX = ListOfPoints[selectedAnswer];
            return pointsMAX;
        }

        public double GetPercentToPass()
        {
            return double.Parse(GetAttributeValue(0, "test", "percent_to_pass"));
        }
    }
}
