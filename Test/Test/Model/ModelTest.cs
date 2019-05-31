using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TestLibrary;

namespace Test.Model
{
    class ModelTest
    {
        XmlReader XmlReader = new XmlReader(ModelLoadPath());
        TestLibrary.Test test = new TestLibrary.Test();
		
		
        
        public  static String ModelLoadPath()
        {
            string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory.ToString()).ToString()).ToString()).ToString() + @"\XMLTest.xml";
            return path;
		}

        public String LoadTestName()
        { 
            test.testName = XmlReader.GetAttributeValue(0, "test", "name");
            return test.testName;
        }
    }

}
