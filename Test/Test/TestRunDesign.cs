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
        public event Action LoadTestName;
        public event Action<int> LoadQuestions, LoadAnswers;
        int index = 0;
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

            if (LoadQuestions != null)
            {
                LoadQuestions(index);
            }
            if(LoadAnswers != null)
            {
                LoadAnswers(index);
            }
            index++;
        }
    }
}
