namespace Test
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTestChoice = new System.Windows.Forms.Button();
            this.testRunDesign = new Test.TestRunDesign();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.testRunDesign);
            this.groupBox1.Location = new System.Drawing.Point(18, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(953, 321);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(947, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Witaj! Aby rozpocząć test, wybierz jeden z nich wskazując plik Nazwa_Testu.XML. P" +
    "o wskazaniu pliku test rozpocznie się automatycznie. Powodzenia!";
            // 
            // buttonTestChoice
            // 
            this.buttonTestChoice.Location = new System.Drawing.Point(18, 41);
            this.buttonTestChoice.Name = "buttonTestChoice";
            this.buttonTestChoice.Size = new System.Drawing.Size(151, 27);
            this.buttonTestChoice.TabIndex = 3;
            this.buttonTestChoice.Text = "Wybór testu.";
            this.buttonTestChoice.UseVisualStyleBackColor = true;
            this.buttonTestChoice.Click += new System.EventHandler(this.buttonTestChoice_Click);
            // 
            // testRunDesign
            // 
            this.testRunDesign.Location = new System.Drawing.Point(6, 21);
            this.testRunDesign.Name = "testRunDesign";
            this.testRunDesign.Size = new System.Drawing.Size(939, 293);
            this.testRunDesign.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 400);
            this.Controls.Add(this.buttonTestChoice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTestChoice;
        private TestRunDesign testRunDesign;
    }
}

