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
        TestLibrary.Test xd = new TestLibrary.Test();
        Answer aa = new Answer();
        
        public  static String ModelLoadPath()
        {
            string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory.ToString()).ToString()).ToString()).ToString() + @"\XMLTest.xml";
            return path;
        }

        public String LoadTestName()
        {
            
            return XmlReader.GetAttributeValue(0, "test", "name");
        }
    }

}
