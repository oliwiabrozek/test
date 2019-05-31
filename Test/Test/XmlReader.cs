using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace Test
{
    class XmlReader
    {
        public XmlDocument XmlDoc;
        public XmlReader(String Path)
        {
            XmlDoc = new XmlDocument();
            XmlDoc.Load(Path); //Załadowanie pliku XML do pamięci przy pomocy gotowej metody klasy XmlDocument
            Console.WriteLine("po załądowaniu pliku");
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
    }
}
