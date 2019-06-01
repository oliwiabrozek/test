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
            string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory.ToString()).ToString()).ToString()).ToString() + @"\XMLTest.xml";
            return path;
		}

        public TestLibrary.Test TestObiektów()
        {
            TestLibrary.Test tmp = new TestLibrary.Test(xml.GetAttributeValue(0, "test", "name"), 12, xml.LoadQuestions());
            return tmp;
        }

    }

}
