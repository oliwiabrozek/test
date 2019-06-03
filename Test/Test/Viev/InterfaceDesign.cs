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
        String CheckboxAValue { set; }
        String CheckboxBValue { set; }
        String CheckboxCValue { set; }
        String CheckboxDValue { set; }
        int AmountOfQuestions { set; }
        event Action LoadTestName, Summary;
        event Action<int> LoadQuestions, LoadAnswers;
        event Action<int, int> AddPoints;
    }
}
