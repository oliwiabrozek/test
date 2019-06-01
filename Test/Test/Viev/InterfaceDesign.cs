using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Viev
{
    interface InterfaceDesign
    {
       //String Path { set; } //odkomentować jeszcze Form1.Designer.cs
        String TestName { set; }
        String QuestionValue { set; }
        event Action LoadTestName;
        event Action<int> LoadQuestions;
    }
}
