using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Viev;
using System.IO;
namespace Test
{
    public partial class TestRunDesign : UserControl, InterfaceDesign
    {
        public event Action LoadTestName, Summary;
        public event Action<int> LoadQuestions, LoadAnswers;
        public event Action<int, int> AddPoints;
        int index = 0; int anountOfQ;
        public TestRunDesign()
        {
            InitializeComponent();

        }

        public String TestName
        {
            set
            {
                if(value != null)
                    labelTestNameValue.Text = value;
            }
        }

        public String QuestionValue
        {
            set
            {
                if (value != null)
                    labelQuestionValue.Text = value;
            }
        }

        public String CheckboxAValue
        {
            set
            {
                if(value != null)
                    checkBoxA.Text = value;
            }
        }
        public String CheckboxBValue
        {
            set
            {
                if (value != null)
                    checkBoxB.Text = value;
            }
        }
        public String CheckboxCValue
        {
            set
            {
                if (value != null)
                    checkBoxC.Text = value;
            }
        }
        public String CheckboxDValue
        {
            set
            {
                if (value != null)
                    checkBoxD.Text = value;
            }
        }

        public int AmountOfQuestions
        {
            set
            {
                if (value != null)
                    anountOfQ = value;
            }
        }

        private void TestRunDesign_Load(object sender, EventArgs e)
        {
            if (LoadTestName != null)
                LoadTestName();
            if (LoadQuestions != null) //pierwsze pytanie
            {
                LoadQuestions(index);
            }
            if (LoadAnswers != null)
                LoadAnswers(index);
            index++;
        }

        public void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkedElement = (CheckBox)sender;
            if (checkedElement.Name.Equals(checkBoxA.Name) && checkedElement.Checked == true)
            {
                checkBoxB.Checked = false;
                checkBoxC.Checked = false;
                checkBoxD.Checked = false;
            }
            else if (checkedElement.Name.Equals(checkBoxB.Name) && checkedElement.Checked == true)
            {
                checkBoxA.Checked = false;
                checkBoxC.Checked = false;
                checkBoxD.Checked = false;
            }
            else if (checkedElement.Name.Equals(checkBoxC.Name) && checkedElement.Checked == true)
            {
                checkBoxA.Checked = false;
                checkBoxB.Checked = false;
                checkBoxD.Checked = false;
            }
            else if (checkedElement.Name.Equals(checkBoxD.Name) && checkedElement.Checked == true)
            {
                checkBoxA.Checked = false;
                checkBoxB.Checked = false;
                checkBoxC.Checked = false;
            }

        }


        private void buttonNextQuestion_Click(object sender, EventArgs e)
        {
            if (checkBoxA.Checked)
            {
                if (AddPoints != null)
                    AddPoints(index, 0);
            }
            else if (checkBoxB.Checked)
            {
                if (AddPoints != null)
                    AddPoints(index, 1);
            }
            else if(checkBoxC.Checked)
            {
                if (AddPoints != null)
                    AddPoints(index, 2);
            }
            else if (checkBoxD.Checked)
            {
                if (AddPoints != null)
                    AddPoints(index, 3);
            }
            else
            {
                Console.WriteLine("Nie znaznaczono żadnej odpowiedzi");
            }
            if (index < anountOfQ)
            {
                if (LoadQuestions != null)
                {
                    LoadQuestions(index);
                }
                if (LoadAnswers != null)
                {
                    LoadAnswers(index);
                }
                index++;
            }
            else
            {
                if(Summary != null)
                    Summary();
            }

            checkBoxA.Checked = false;
            checkBoxB.Checked = false;
            checkBoxC.Checked = false;
            checkBoxD.Checked = false;
        }
    }
}
