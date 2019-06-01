using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TestLibrary;
using System.Xml;

namespace Test.Model
{
    class ModelTest
    {
        XmlReader xml = new XmlReader(ModelLoadPath());
        TestLibrary.Test libraryT = new TestLibrary.Test();
        Question libraryQ = new Question();

        public  static String ModelLoadPath()
        {
            //Console.WriteLine("Model ModelLoadPath()");
            string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory.ToString()).ToString()).ToString()).ToString() + @"\XMLTest.xml";
            return path;
		}

        public String LoadTestName()
        {
           // Console.WriteLine("Model LoadTestName()");
            libraryT.testName = xml.GetAttributeValue(0, "test", "name");
            return libraryT.testName;
        }

        public String LoadQuestion(int index)
        {
            Question tmp = xml.LoadQuestion(index);
            Console.WriteLine("pustka?: " + tmp.question);
            return tmp.question;
        }

        /*public List<Question> LoadQuestions()
        {
            XmlDocument xmll =  
            List<Question> question = (
                from question in )

            return question;
        } */
    }

}
