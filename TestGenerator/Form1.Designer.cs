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
			this.answerPointsLabel = new System.Windows.Forms.Label();
			this.answerPointsNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.questionLabel = new System.Windows.Forms.Label();
			this.questionTextBox = new System.Windows.Forms.TextBox();
			this.scoreAddButton = new System.Windows.Forms.Button();
			this.scoreLabel = new System.Windows.Forms.Label();
			this.saveTestButton = new System.Windows.Forms.Button();
			this.deleteQuestionButton = new System.Windows.Forms.Button();
			this.addQuesionButton = new System.Windows.Forms.Button();
			this.questionsTabControl = new System.Windows.Forms.TabControl();
			this.testNameButton = new System.Windows.Forms.Button();
			this.addAuthorButton = new System.Windows.Forms.Button();
			this.testNameTextBox = new System.Windows.Forms.TextBox();
			this.authorTextBox = new System.Windows.Forms.TextBox();
			this.testNameLabel = new System.Windows.Forms.Label();
			this.authorLabel = new System.Windows.Forms.Label();
			this.changeQuestionButton = new System.Windows.Forms.Button();
			this.addAsnwerButton = new System.Windows.Forms.Button();
			this.deleteAnswerButton = new System.Windows.Forms.Button();
			this.changeAnswerButton = new System.Windows.Forms.Button();
			this.setAnswerPointsButton = new System.Windows.Forms.Button();
			this.answerTextBox = new System.Windows.Forms.TextBox();
			this.answerLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.scoreNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.answerPointsNumericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// scoreNumericUpDown
			// 
			this.scoreNumericUpDown.DecimalPlaces = 2;
			this.scoreNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.scoreNumericUpDown.InterceptArrowKeys = false;
			this.scoreNumericUpDown.Location = new System.Drawing.Point(112, 51);
			this.scoreNumericUpDown.Name = "scoreNumericUpDown";
			this.scoreNumericUpDown.Size = new System.Drawing.Size(100, 20);
			this.scoreNumericUpDown.TabIndex = 29;
			this.scoreNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// answerPointsLabel
			// 
			this.answerPointsLabel.AutoSize = true;
			this.answerPointsLabel.Location = new System.Drawing.Point(9, 189);
			this.answerPointsLabel.Name = "answerPointsLabel";
			this.answerPointsLabel.Size = new System.Drawing.Size(219, 13);
			this.answerPointsLabel.TabIndex = 5;
			this.answerPointsLabel.Text = "Podaj punktację dla zaznaczonej odpowiedzi";
			// 
			// answerPointsNumericUpDown
			// 
			this.answerPointsNumericUpDown.DecimalPlaces = 2;
			this.answerPointsNumericUpDown.Location = new System.Drawing.Point(12, 205);
			this.answerPointsNumericUpDown.Name = "answerPointsNumericUpDown";
			this.answerPointsNumericUpDown.Size = new System.Drawing.Size(120, 20);
			this.answerPointsNumericUpDown.TabIndex = 3;
			// 
			// questionLabel
			// 
			this.questionLabel.AutoSize = true;
			this.questionLabel.Location = new System.Drawing.Point(12, 96);
			this.questionLabel.Name = "questionLabel";
			this.questionLabel.Size = new System.Drawing.Size(97, 13);
			this.questionLabel.TabIndex = 2;
			this.questionLabel.Text = "Podaj treść pytania";
			// 
			// questionTextBox
			// 
			this.questionTextBox.Location = new System.Drawing.Point(112, 96);
			this.questionTextBox.Name = "questionTextBox";
			this.questionTextBox.Size = new System.Drawing.Size(131, 20);
			this.questionTextBox.TabIndex = 1;
			// 
			// scoreAddButton
			// 
			this.scoreAddButton.Location = new System.Drawing.Point(231, 54);
			this.scoreAddButton.Name = "scoreAddButton";
			this.scoreAddButton.Size = new System.Drawing.Size(75, 23);
			this.scoreAddButton.TabIndex = 27;
			this.scoreAddButton.Text = "Zmień";
			this.scoreAddButton.UseVisualStyleBackColor = true;
			this.scoreAddButton.Click += new System.EventHandler(this.scoreAddButton_Click);
			// 
			// scoreLabel
			// 
			this.scoreLabel.AutoSize = true;
			this.scoreLabel.Location = new System.Drawing.Point(12, 53);
			this.scoreLabel.Name = "scoreLabel";
			this.scoreLabel.Size = new System.Drawing.Size(78, 13);
			this.scoreLabel.TabIndex = 26;
			this.scoreLabel.Text = "Próg zaliczenia";
			// 
			// saveTestButton
			// 
			this.saveTestButton.Location = new System.Drawing.Point(624, 7);
			this.saveTestButton.Name = "saveTestButton";
			this.saveTestButton.Size = new System.Drawing.Size(82, 23);
			this.saveTestButton.TabIndex = 25;
			this.saveTestButton.Text = "Zapisz test";
			this.saveTestButton.UseVisualStyleBackColor = true;
			// 
			// deleteQuestionButton
			// 
			this.deleteQuestionButton.Location = new System.Drawing.Point(589, 202);
			this.deleteQuestionButton.Name = "deleteQuestionButton";
			this.deleteQuestionButton.Size = new System.Drawing.Size(97, 23);
			this.deleteQuestionButton.TabIndex = 24;
			this.deleteQuestionButton.Text = "Usuń pytanie";
			this.deleteQuestionButton.UseVisualStyleBackColor = true;
			// 
			// addQuesionButton
			// 
			this.addQuesionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.addQuesionButton.Location = new System.Drawing.Point(249, 94);
			this.addQuesionButton.Name = "addQuesionButton";
			this.addQuesionButton.Size = new System.Drawing.Size(97, 23);
			this.addQuesionButton.TabIndex = 23;
			this.addQuesionButton.Text = "Dodaj pytanie";
			this.addQuesionButton.UseVisualStyleBackColor = true;
			this.addQuesionButton.Click += new System.EventHandler(this.addQuesionButton_Click);
			// 
			// questionsTabControl
			// 
			this.questionsTabControl.Location = new System.Drawing.Point(302, 171);
			this.questionsTabControl.Name = "questionsTabControl";
			this.questionsTabControl.SelectedIndex = 0;
			this.questionsTabControl.Size = new System.Drawing.Size(281, 229);
			this.questionsTabControl.TabIndex = 22;
			// 
			// testNameButton
			// 
			this.testNameButton.Location = new System.Drawing.Point(231, 25);
			this.testNameButton.Name = "testNameButton";
			this.testNameButton.Size = new System.Drawing.Size(75, 23);
			this.testNameButton.TabIndex = 21;
			this.testNameButton.Text = "Zmień";
			this.testNameButton.UseVisualStyleBackColor = true;
			this.testNameButton.Click += new System.EventHandler(this.testNameButton_Click);
			// 
			// addAuthorButton
			// 
			this.addAuthorButton.Location = new System.Drawing.Point(231, 0);
			this.addAuthorButton.Name = "addAuthorButton";
			this.addAuthorButton.Size = new System.Drawing.Size(75, 23);
			this.addAuthorButton.TabIndex = 20;
			this.addAuthorButton.Text = "Dodaj";
			this.addAuthorButton.UseVisualStyleBackColor = true;
			this.addAuthorButton.Click += new System.EventHandler(this.addAuthorButton_Click);
			// 
			// testNameTextBox
			// 
			this.testNameTextBox.Location = new System.Drawing.Point(112, 2);
			this.testNameTextBox.Name = "testNameTextBox";
			this.testNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.testNameTextBox.TabIndex = 19;
			// 
			// authorTextBox
			// 
			this.authorTextBox.Location = new System.Drawing.Point(112, 28);
			this.authorTextBox.Name = "authorTextBox";
			this.authorTextBox.Size = new System.Drawing.Size(100, 20);
			this.authorTextBox.TabIndex = 18;
			// 
			// testNameLabel
			// 
			this.testNameLabel.AutoSize = true;
			this.testNameLabel.Location = new System.Drawing.Point(12, 34);
			this.testNameLabel.Name = "testNameLabel";
			this.testNameLabel.Size = new System.Drawing.Size(66, 13);
			this.testNameLabel.TabIndex = 17;
			this.testNameLabel.Text = "Nazwa testu";
			// 
			// authorLabel
			// 
			this.authorLabel.AutoSize = true;
			this.authorLabel.Location = new System.Drawing.Point(21, 12);
			this.authorLabel.Name = "authorLabel";
			this.authorLabel.Size = new System.Drawing.Size(32, 13);
			this.authorLabel.TabIndex = 16;
			this.authorLabel.Text = "Autor";
			// 
			// changeQuestionButton
			// 
			this.changeQuestionButton.Location = new System.Drawing.Point(352, 94);
			this.changeQuestionButton.Name = "changeQuestionButton";
			this.changeQuestionButton.Size = new System.Drawing.Size(97, 23);
			this.changeQuestionButton.TabIndex = 33;
			this.changeQuestionButton.Text = "Zmień pytanie";
			this.changeQuestionButton.UseVisualStyleBackColor = true;
			// 
			// addAsnwerButton
			// 
			this.addAsnwerButton.Location = new System.Drawing.Point(249, 121);
			this.addAsnwerButton.Name = "addAsnwerButton";
			this.addAsnwerButton.Size = new System.Drawing.Size(97, 23);
			this.addAsnwerButton.TabIndex = 30;
			this.addAsnwerButton.Text = "Dodaj odpowiedź";
			this.addAsnwerButton.UseVisualStyleBackColor = true;
			this.addAsnwerButton.Click += new System.EventHandler(this.addAsnwerButton_Click);
			// 
			// deleteAnswerButton
			// 
			this.deleteAnswerButton.Location = new System.Drawing.Point(589, 231);
			this.deleteAnswerButton.Name = "deleteAnswerButton";
			this.deleteAnswerButton.Size = new System.Drawing.Size(97, 23);
			this.deleteAnswerButton.TabIndex = 31;
			this.deleteAnswerButton.Text = "Usuń odpowiedź";
			this.deleteAnswerButton.UseVisualStyleBackColor = true;
			// 
			// changeAnswerButton
			// 
			this.changeAnswerButton.Location = new System.Drawing.Point(352, 121);
			this.changeAnswerButton.Name = "changeAnswerButton";
			this.changeAnswerButton.Size = new System.Drawing.Size(97, 23);
			this.changeAnswerButton.TabIndex = 32;
			this.changeAnswerButton.Text = "Zmień odpowiedź";
			this.changeAnswerButton.UseVisualStyleBackColor = true;
			this.changeAnswerButton.Click += new System.EventHandler(this.changeAnswerButton_Click);
			// 
			// setAnswerPointsButton
			// 
			this.setAnswerPointsButton.Location = new System.Drawing.Point(138, 205);
			this.setAnswerPointsButton.Name = "setAnswerPointsButton";
			this.setAnswerPointsButton.Size = new System.Drawing.Size(75, 23);
			this.setAnswerPointsButton.TabIndex = 4;
			this.setAnswerPointsButton.Text = "Ustaw";
			this.setAnswerPointsButton.UseVisualStyleBackColor = true;
			this.setAnswerPointsButton.Click += new System.EventHandler(this.setAnswerPointsButton_Click);
			// 
			// answerTextBox
			// 
			this.answerTextBox.Location = new System.Drawing.Point(112, 123);
			this.answerTextBox.Name = "answerTextBox";
			this.answerTextBox.Size = new System.Drawing.Size(131, 20);
			this.answerTextBox.TabIndex = 34;
			// 
			// answerLabel
			// 
			this.answerLabel.AutoSize = true;
			this.answerLabel.Location = new System.Drawing.Point(15, 129);
			this.answerLabel.Name = "answerLabel";
			this.answerLabel.Size = new System.Drawing.Size(94, 13);
			this.answerLabel.TabIndex = 35;
			this.answerLabel.Text = "Podaj odpowiedź: ";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(732, 494);
			this.Controls.Add(this.answerLabel);
			this.Controls.Add(this.answerTextBox);
			this.Controls.Add(this.setAnswerPointsButton);
			this.Controls.Add(this.answerPointsLabel);
			this.Controls.Add(this.addAsnwerButton);
			this.Controls.Add(this.deleteAnswerButton);
			this.Controls.Add(this.changeAnswerButton);
			this.Controls.Add(this.questionLabel);
			this.Controls.Add(this.questionTextBox);
			this.Controls.Add(this.changeQuestionButton);
			this.Controls.Add(this.answerPointsNumericUpDown);
			this.Controls.Add(this.scoreNumericUpDown);
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
			((System.ComponentModel.ISupportInitialize)(this.answerPointsNumericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown scoreNumericUpDown;
		private System.Windows.Forms.Label answerPointsLabel;
		private System.Windows.Forms.NumericUpDown answerPointsNumericUpDown;
		private System.Windows.Forms.Label questionLabel;
		private System.Windows.Forms.TextBox questionTextBox;
		private System.Windows.Forms.Button scoreAddButton;
		private System.Windows.Forms.Label scoreLabel;
		private System.Windows.Forms.Button saveTestButton;
		private System.Windows.Forms.Button deleteQuestionButton;
		private System.Windows.Forms.Button addQuesionButton;
		private System.Windows.Forms.TabControl questionsTabControl;
		private System.Windows.Forms.Button testNameButton;
		private System.Windows.Forms.Button addAuthorButton;
		private System.Windows.Forms.TextBox testNameTextBox;
		private System.Windows.Forms.TextBox authorTextBox;
		private System.Windows.Forms.Label testNameLabel;
		private System.Windows.Forms.Label authorLabel;
		private System.Windows.Forms.Button changeQuestionButton;
		private System.Windows.Forms.Button addAsnwerButton;
		private System.Windows.Forms.Button deleteAnswerButton;
		private System.Windows.Forms.Button changeAnswerButton;
		private System.Windows.Forms.Button setAnswerPointsButton;
		private System.Windows.Forms.TextBox answerTextBox;
		private System.Windows.Forms.Label answerLabel;
	}
}

