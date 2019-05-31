using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Viev
{
    interface InterfaceDesign
    {
        String Path { set; }
        String TestName { set; }
        //String TestName { set; get; }
        event Action LoadPath, LoadTestName;
    }
}
