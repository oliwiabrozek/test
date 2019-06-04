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
        int IndexForValueOfPointsInNextQuesiotn = 0;
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
                    {
                        Answers.Add(item.InnerText);
                        Console.WriteLine("DODAJE: " + item.InnerText);
                    }
                }
            }
            return Answers;
        }

        public List<double> GetPointForCurrentAnswers(uint index) //tu tego i nie powinno byc, pobier mi wszystkie punkty dla wszystkich pytan zamiast dla konkretnego
        {//zrób tak, żw pobiera od indeksu do ilości odpowiedzi
            List<double> ListOfPoints = new List<double>();
            XmlNodeList points = XmlDoc.SelectNodes("/test/questions/question[@index = '" + index + "']/answer[@points]");
            
            foreach (XmlNode node in points)
            {
                foreach (XmlNode item in node)
                {
                    ListOfPoints.Add(double.Parse(GetAttributeValue(IndexForValueOfPointsInNextQuesiotn, "answer", "points")));
                    IndexForValueOfPointsInNextQuesiotn++;
                }
            }
            return ListOfPoints;
        }

        public double GetPercentToPass()
        {
            return double.Parse(GetAttributeValue(0, "test", "percent_to_pass"));
        }
    }
}
