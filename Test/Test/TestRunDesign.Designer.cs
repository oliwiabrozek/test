namespace Test
{
    partial class TestRunDesign
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNextQuestion = new System.Windows.Forms.Button();
            this.labelQuestionValue = new System.Windows.Forms.Label();
            this.checkBoxA = new System.Windows.Forms.CheckBox();
            this.checkBoxB = new System.Windows.Forms.CheckBox();
            this.checkBoxC = new System.Windows.Forms.CheckBox();
            this.checkBoxD = new System.Windows.Forms.CheckBox();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelTestNameValue = new System.Windows.Forms.Label();
            this.labelTextName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNextQuestion
            // 
            this.buttonNextQuestion.Location = new System.Drawing.Point(5, 245);
            this.buttonNextQuestion.Name = "buttonNextQuestion";
            this.buttonNextQuestion.Size = new System.Drawing.Size(108, 47);
            this.buttonNextQuestion.TabIndex = 2;
            this.buttonNextQuestion.Text = "Kolejne pytanie";
            this.buttonNextQuestion.UseVisualStyleBackColor = true;
            this.buttonNextQuestion.Click += new System.EventHandler(this.buttonNextQuestion_Click);
            // 
            // labelQuestionValue
            // 
            this.labelQuestionValue.AutoSize = true;
            this.labelQuestionValue.Location = new System.Drawing.Point(77, 46);
            this.labelQuestionValue.Name = "labelQuestionValue";
            this.labelQuestionValue.Size = new System.Drawing.Size(42, 17);
            this.labelQuestionValue.TabIndex = 4;
            this.labelQuestionValue.Text = "value";
            // 
            // checkBoxA
            // 
            this.checkBoxA.AutoSize = true;
            this.checkBoxA.Location = new System.Drawing.Point(15, 83);
            this.checkBoxA.Name = "checkBoxA";
            this.checkBoxA.Size = new System.Drawing.Size(39, 21);
            this.checkBoxA.TabIndex = 5;
            this.checkBoxA.Text = "A";
            this.checkBoxA.UseVisualStyleBackColor = true;
            this.checkBoxA.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxB
            // 
            this.checkBoxB.AutoSize = true;
            this.checkBoxB.Location = new System.Drawing.Point(15, 121);
            this.checkBoxB.Name = "checkBoxB";
            this.checkBoxB.Size = new System.Drawing.Size(39, 21);
            this.checkBoxB.TabIndex = 6;
            this.checkBoxB.Text = "B";
            this.checkBoxB.UseVisualStyleBackColor = true;
            this.checkBoxB.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxC
            // 
            this.checkBoxC.AutoSize = true;
            this.checkBoxC.Location = new System.Drawing.Point(15, 158);
            this.checkBoxC.Name = "checkBoxC";
            this.checkBoxC.Size = new System.Drawing.Size(39, 21);
            this.checkBoxC.TabIndex = 7;
            this.checkBoxC.Text = "C";
            this.checkBoxC.UseVisualStyleBackColor = true;
            this.checkBoxC.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxD
            // 
            this.checkBoxD.AutoSize = true;
            this.checkBoxD.Location = new System.Drawing.Point(15, 195);
            this.checkBoxD.Name = "checkBoxD";
            this.checkBoxD.Size = new System.Drawing.Size(40, 21);
            this.checkBoxD.TabIndex = 8;
            this.checkBoxD.Text = "D";
            this.checkBoxD.UseVisualStyleBackColor = true;
            this.checkBoxD.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(12, 46);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(59, 17);
            this.labelQuestion.TabIndex = 3;
            this.labelQuestion.Text = "Pytanie:";
            // 
            // labelTestNameValue
            // 
            this.labelTestNameValue.AutoSize = true;
            this.labelTestNameValue.Location = new System.Drawing.Point(109, 17);
            this.labelTestNameValue.Name = "labelTestNameValue";
            this.labelTestNameValue.Size = new System.Drawing.Size(42, 17);
            this.labelTestNameValue.TabIndex = 1;
            this.labelTestNameValue.Text = "value";
            // 
            // labelTextName
            // 
            this.labelTextName.AutoSize = true;
            this.labelTextName.Location = new System.Drawing.Point(10, 17);
            this.labelTextName.Name = "labelTextName";
            this.labelTextName.Size = new System.Drawing.Size(93, 17);
            this.labelTextName.TabIndex = 0;
            this.labelTextName.Text = "Nazwa testu: ";
            // 
            // TestRunDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelTestNameValue);
            this.Controls.Add(this.labelTextName);
            this.Controls.Add(this.checkBoxD);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.checkBoxC);
            this.Controls.Add(this.checkBoxB);
            this.Controls.Add(this.checkBoxA);
            this.Controls.Add(this.labelQuestionValue);
            this.Controls.Add(this.buttonNextQuestion);
            this.Name = "TestRunDesign";
            this.Size = new System.Drawing.Size(491, 307);
            this.Load += new System.EventHandler(this.TestRunDesign_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonNextQuestion;
        private System.Windows.Forms.Label labelQuestionValue;
        private System.Windows.Forms.CheckBox checkBoxA;
        private System.Windows.Forms.CheckBox checkBoxB;
        private System.Windows.Forms.CheckBox checkBoxC;
        private System.Windows.Forms.CheckBox checkBoxD;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelTestNameValue;
        private System.Windows.Forms.Label labelTextName;
    }
}
