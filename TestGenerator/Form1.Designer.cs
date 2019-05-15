namespace TestGenerator
{
	partial class Form1
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.scoreNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.questionGroupBox = new System.Windows.Forms.GroupBox();
			this.answerPointsLabel = new System.Windows.Forms.Label();
			this.setAnswerPointsButton = new System.Windows.Forms.Button();
			this.answerPointsNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.questionLabel = new System.Windows.Forms.Label();
			this.questionTextBox = new System.Windows.Forms.TextBox();
			this.answersCheckedListBox = new System.Windows.Forms.CheckedListBox();
			this.scoreAddButton = new System.Windows.Forms.Button();
			this.scoreLabel = new System.Windows.Forms.Label();
			this.saveTestButton = new System.Windows.Forms.Button();
			this.deleteQuestionButton = new System.Windows.Forms.Button();
			this.addQuesionButton = new System.Windows.Forms.Button();
			this.questionsTabControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.testNameButton = new System.Windows.Forms.Button();
			this.addAuthorButton = new System.Windows.Forms.Button();
			this.testNameTextBox = new System.Windows.Forms.TextBox();
			this.authorTextBox = new System.Windows.Forms.TextBox();
			this.testNameLabel = new System.Windows.Forms.Label();
			this.authorLabel = new System.Windows.Forms.Label();
			this.addAsnwerButton = new System.Windows.Forms.Button();
			this.deleteAnswerButton = new System.Windows.Forms.Button();
			this.changeAnswerButton = new System.Windows.Forms.Button();
			this.changeQuestionButton = new System.Windows.Forms.Button();
			this.questionsListBox = new System.Windows.Forms.ListBox();
			this.pointsListBox = new System.Windows.Forms.ListBox();
			this.questionContentLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.scoreNumericUpDown)).BeginInit();
			this.questionGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.answerPointsNumericUpDown)).BeginInit();
			this.questionsTabControl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// scoreNumericUpDown
			// 
			this.scoreNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.scoreNumericUpDown.Location = new System.Drawing.Point(133, 94);
			this.scoreNumericUpDown.Name = "scoreNumericUpDown";
			this.scoreNumericUpDown.Size = new System.Drawing.Size(100, 20);
			this.scoreNumericUpDown.TabIndex = 29;
			this.scoreNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// questionGroupBox
			// 
			this.questionGroupBox.Controls.Add(this.answerPointsLabel);
			this.questionGroupBox.Controls.Add(this.setAnswerPointsButton);
			this.questionGroupBox.Controls.Add(this.answerPointsNumericUpDown);
			this.questionGroupBox.Controls.Add(this.questionLabel);
			this.questionGroupBox.Controls.Add(this.questionTextBox);
			this.questionGroupBox.Controls.Add(this.answersCheckedListBox);
			this.questionGroupBox.Location = new System.Drawing.Point(42, 119);
			this.questionGroupBox.Name = "questionGroupBox";
			this.questionGroupBox.Size = new System.Drawing.Size(269, 343);
			this.questionGroupBox.TabIndex = 28;
			this.questionGroupBox.TabStop = false;
			// 
			// answerPointsLabel
			// 
			this.answerPointsLabel.AutoSize = true;
			this.answerPointsLabel.Location = new System.Drawing.Point(6, 298);
			this.answerPointsLabel.Name = "answerPointsLabel";
			this.answerPointsLabel.Size = new System.Drawing.Size(210, 13);
			this.answerPointsLabel.TabIndex = 5;
			this.answerPointsLabel.Text = "Podaj punktację dla zaznaczonego pytania";
			// 
			// setAnswerPointsButton
			// 
			this.setAnswerPointsButton.Location = new System.Drawing.Point(141, 314);
			this.setAnswerPointsButton.Name = "setAnswerPointsButton";
			this.setAnswerPointsButton.Size = new System.Drawing.Size(75, 23);
			this.setAnswerPointsButton.TabIndex = 4;
			this.setAnswerPointsButton.Text = "Ustaw";
			this.setAnswerPointsButton.UseVisualStyleBackColor = true;
			// 
			// answerPointsNumericUpDown
			// 
			this.answerPointsNumericUpDown.Location = new System.Drawing.Point(9, 317);
			this.answerPointsNumericUpDown.Name = "answerPointsNumericUpDown";
			this.answerPointsNumericUpDown.Size = new System.Drawing.Size(120, 20);
			this.answerPointsNumericUpDown.TabIndex = 3;
			// 
			// questionLabel
			// 
			this.questionLabel.AutoSize = true;
			this.questionLabel.Location = new System.Drawing.Point(6, 22);
			this.questionLabel.Name = "questionLabel";
			this.questionLabel.Size = new System.Drawing.Size(60, 13);
			this.questionLabel.TabIndex = 2;
			this.questionLabel.Text = "Podaj treść";
			// 
			// questionTextBox
			// 
			this.questionTextBox.Location = new System.Drawing.Point(88, 19);
			this.questionTextBox.Name = "questionTextBox";
			this.questionTextBox.Size = new System.Drawing.Size(151, 20);
			this.questionTextBox.TabIndex = 1;
			// 
			// answersCheckedListBox
			// 
			this.answersCheckedListBox.FormattingEnabled = true;
			this.answersCheckedListBox.Location = new System.Drawing.Point(0, 45);
			this.answersCheckedListBox.Name = "answersCheckedListBox";
			this.answersCheckedListBox.Size = new System.Drawing.Size(257, 244);
			this.answersCheckedListBox.TabIndex = 0;
			// 
			// scoreAddButton
			// 
			this.scoreAddButton.Location = new System.Drawing.Point(239, 90);
			this.scoreAddButton.Name = "scoreAddButton";
			this.scoreAddButton.Size = new System.Drawing.Size(75, 23);
			this.scoreAddButton.TabIndex = 27;
			this.scoreAddButton.Text = "Zmień";
			this.scoreAddButton.UseVisualStyleBackColor = true;
			// 
			// scoreLabel
			// 
			this.scoreLabel.AutoSize = true;
			this.scoreLabel.Location = new System.Drawing.Point(42, 94);
			this.scoreLabel.Name = "scoreLabel";
			this.scoreLabel.Size = new System.Drawing.Size(78, 13);
			this.scoreLabel.TabIndex = 26;
			this.scoreLabel.Text = "Próg zaliczenia";
			// 
			// saveTestButton
			// 
			this.saveTestButton.Location = new System.Drawing.Point(608, 43);
			this.saveTestButton.Name = "saveTestButton";
			this.saveTestButton.Size = new System.Drawing.Size(82, 23);
			this.saveTestButton.TabIndex = 25;
			this.saveTestButton.Text = "Zapisz test";
			this.saveTestButton.UseVisualStyleBackColor = true;
			// 
			// deleteQuestionButton
			// 
			this.deleteQuestionButton.Location = new System.Drawing.Point(310, 193);
			this.deleteQuestionButton.Name = "deleteQuestionButton";
			this.deleteQuestionButton.Size = new System.Drawing.Size(97, 23);
			this.deleteQuestionButton.TabIndex = 24;
			this.deleteQuestionButton.Text = "Usuń pytanie";
			this.deleteQuestionButton.UseVisualStyleBackColor = true;
			// 
			// addQuesionButton
			// 
			this.addQuesionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.addQuesionButton.Location = new System.Drawing.Point(310, 164);
			this.addQuesionButton.Name = "addQuesionButton";
			this.addQuesionButton.Size = new System.Drawing.Size(97, 23);
			this.addQuesionButton.TabIndex = 23;
			this.addQuesionButton.Text = "Dodaj pytanie";
			this.addQuesionButton.UseVisualStyleBackColor = true;
			// 
			// questionsTabControl
			// 
			this.questionsTabControl.Controls.Add(this.tabPage1);
			this.questionsTabControl.Location = new System.Drawing.Point(409, 119);
			this.questionsTabControl.Name = "questionsTabControl";
			this.questionsTabControl.SelectedIndex = 0;
			this.questionsTabControl.Size = new System.Drawing.Size(285, 343);
			this.questionsTabControl.TabIndex = 22;
			// 
			// tabPage1
			// 
			this.tabPage1.AutoScroll = true;
			this.tabPage1.Controls.Add(this.questionContentLabel);
			this.tabPage1.Controls.Add(this.pointsListBox);
			this.tabPage1.Controls.Add(this.questionsListBox);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(277, 317);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Pytanie 1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// testNameButton
			// 
			this.testNameButton.Location = new System.Drawing.Point(239, 62);
			this.testNameButton.Name = "testNameButton";
			this.testNameButton.Size = new System.Drawing.Size(75, 23);
			this.testNameButton.TabIndex = 21;
			this.testNameButton.Text = "Zmień";
			this.testNameButton.UseVisualStyleBackColor = true;
			// 
			// addAuthorButton
			// 
			this.addAuthorButton.Location = new System.Drawing.Point(239, 33);
			this.addAuthorButton.Name = "addAuthorButton";
			this.addAuthorButton.Size = new System.Drawing.Size(75, 23);
			this.addAuthorButton.TabIndex = 20;
			this.addAuthorButton.Text = "Dodaj";
			this.addAuthorButton.UseVisualStyleBackColor = true;
			// 
			// testNameTextBox
			// 
			this.testNameTextBox.Location = new System.Drawing.Point(133, 63);
			this.testNameTextBox.Name = "testNameTextBox";
			this.testNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.testNameTextBox.TabIndex = 19;
			// 
			// authorTextBox
			// 
			this.authorTextBox.Location = new System.Drawing.Point(133, 36);
			this.authorTextBox.Name = "authorTextBox";
			this.authorTextBox.Size = new System.Drawing.Size(100, 20);
			this.authorTextBox.TabIndex = 18;
			this.authorTextBox.TextChanged += new System.EventHandler(this.authorTextBox_TextChanged);
			// 
			// testNameLabel
			// 
			this.testNameLabel.AutoSize = true;
			this.testNameLabel.Location = new System.Drawing.Point(39, 66);
			this.testNameLabel.Name = "testNameLabel";
			this.testNameLabel.Size = new System.Drawing.Size(66, 13);
			this.testNameLabel.TabIndex = 17;
			this.testNameLabel.Text = "Nazwa testu";
			// 
			// authorLabel
			// 
			this.authorLabel.AutoSize = true;
			this.authorLabel.Location = new System.Drawing.Point(73, 43);
			this.authorLabel.Name = "authorLabel";
			this.authorLabel.Size = new System.Drawing.Size(32, 13);
			this.authorLabel.TabIndex = 16;
			this.authorLabel.Text = "Autor";
			// 
			// addAsnwerButton
			// 
			this.addAsnwerButton.Location = new System.Drawing.Point(310, 315);
			this.addAsnwerButton.Name = "addAsnwerButton";
			this.addAsnwerButton.Size = new System.Drawing.Size(97, 23);
			this.addAsnwerButton.TabIndex = 30;
			this.addAsnwerButton.Text = "Dodaj odpowiedź";
			this.addAsnwerButton.UseVisualStyleBackColor = true;
			// 
			// deleteAnswerButton
			// 
			this.deleteAnswerButton.Location = new System.Drawing.Point(310, 344);
			this.deleteAnswerButton.Name = "deleteAnswerButton";
			this.deleteAnswerButton.Size = new System.Drawing.Size(97, 23);
			this.deleteAnswerButton.TabIndex = 31;
			this.deleteAnswerButton.Text = "Usuń odpowiedź";
			this.deleteAnswerButton.UseVisualStyleBackColor = true;
			// 
			// changeAnswerButton
			// 
			this.changeAnswerButton.Location = new System.Drawing.Point(310, 373);
			this.changeAnswerButton.Name = "changeAnswerButton";
			this.changeAnswerButton.Size = new System.Drawing.Size(102, 23);
			this.changeAnswerButton.TabIndex = 32;
			this.changeAnswerButton.Text = "Zmień odpowiedź";
			this.changeAnswerButton.UseVisualStyleBackColor = true;
			// 
			// changeQuestionButton
			// 
			this.changeQuestionButton.Location = new System.Drawing.Point(310, 222);
			this.changeQuestionButton.Name = "changeQuestionButton";
			this.changeQuestionButton.Size = new System.Drawing.Size(97, 23);
			this.changeQuestionButton.TabIndex = 33;
			this.changeQuestionButton.Text = "Zmień pytanie";
			this.changeQuestionButton.UseVisualStyleBackColor = true;
			// 
			// questionsListBox
			// 
			this.questionsListBox.FormattingEnabled = true;
			this.questionsListBox.Location = new System.Drawing.Point(6, 52);
			this.questionsListBox.Name = "questionsListBox";
			this.questionsListBox.Size = new System.Drawing.Size(123, 251);
			this.questionsListBox.TabIndex = 0;
			// 
			// pointsListBox
			// 
			this.pointsListBox.FormattingEnabled = true;
			this.pointsListBox.Location = new System.Drawing.Point(135, 52);
			this.pointsListBox.Name = "pointsListBox";
			this.pointsListBox.Size = new System.Drawing.Size(126, 251);
			this.pointsListBox.TabIndex = 1;
			// 
			// questionContentLabel
			// 
			this.questionContentLabel.AutoSize = true;
			this.questionContentLabel.Location = new System.Drawing.Point(12, 23);
			this.questionContentLabel.Name = "questionContentLabel";
			this.questionContentLabel.Size = new System.Drawing.Size(67, 13);
			this.questionContentLabel.TabIndex = 2;
			this.questionContentLabel.Text = "treść pytania";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(732, 494);
			this.Controls.Add(this.changeQuestionButton);
			this.Controls.Add(this.changeAnswerButton);
			this.Controls.Add(this.deleteAnswerButton);
			this.Controls.Add(this.addAsnwerButton);
			this.Controls.Add(this.scoreNumericUpDown);
			this.Controls.Add(this.questionGroupBox);
			this.Controls.Add(this.scoreAddButton);
			this.Controls.Add(this.scoreLabel);
			this.Controls.Add(this.saveTestButton);
			this.Controls.Add(this.deleteQuestionButton);
			this.Controls.Add(this.addQuesionButton);
			this.Controls.Add(this.questionsTabControl);
			this.Controls.Add(this.testNameButton);
			this.Controls.Add(this.addAuthorButton);
			this.Controls.Add(this.testNameTextBox);
			this.Controls.Add(this.authorTextBox);
			this.Controls.Add(this.testNameLabel);
			this.Controls.Add(this.authorLabel);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.scoreNumericUpDown)).EndInit();
			this.questionGroupBox.ResumeLayout(false);
			this.questionGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.answerPointsNumericUpDown)).EndInit();
			this.questionsTabControl.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown scoreNumericUpDown;
		private System.Windows.Forms.GroupBox questionGroupBox;
		private System.Windows.Forms.Label answerPointsLabel;
		private System.Windows.Forms.Button setAnswerPointsButton;
		private System.Windows.Forms.NumericUpDown answerPointsNumericUpDown;
		private System.Windows.Forms.Label questionLabel;
		private System.Windows.Forms.TextBox questionTextBox;
		private System.Windows.Forms.CheckedListBox answersCheckedListBox;
		private System.Windows.Forms.Button scoreAddButton;
		private System.Windows.Forms.Label scoreLabel;
		private System.Windows.Forms.Button saveTestButton;
		private System.Windows.Forms.Button deleteQuestionButton;
		private System.Windows.Forms.Button addQuesionButton;
		private System.Windows.Forms.TabControl questionsTabControl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button testNameButton;
		private System.Windows.Forms.Button addAuthorButton;
		private System.Windows.Forms.TextBox testNameTextBox;
		private System.Windows.Forms.TextBox authorTextBox;
		private System.Windows.Forms.Label testNameLabel;
		private System.Windows.Forms.Label authorLabel;
		private System.Windows.Forms.Label questionContentLabel;
		private System.Windows.Forms.ListBox pointsListBox;
		private System.Windows.Forms.ListBox questionsListBox;
		private System.Windows.Forms.Button addAsnwerButton;
		private System.Windows.Forms.Button deleteAnswerButton;
		private System.Windows.Forms.Button changeAnswerButton;
		private System.Windows.Forms.Button changeQuestionButton;
	}
}

