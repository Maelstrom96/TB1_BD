namespace TestQuest
{
    partial class AdminQuestions
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
            this.BTN_Submit = new System.Windows.Forms.Button();
            this.TXT_Question = new System.Windows.Forms.TextBox();
            this.TXT_Answer1 = new System.Windows.Forms.TextBox();
            this.TXT_Answer2 = new System.Windows.Forms.TextBox();
            this.TXT_Answer3 = new System.Windows.Forms.TextBox();
            this.TXT_Answer4 = new System.Windows.Forms.TextBox();
            this.RB_Good1 = new System.Windows.Forms.RadioButton();
            this.RB_Good2 = new System.Windows.Forms.RadioButton();
            this.RB_Good3 = new System.Windows.Forms.RadioButton();
            this.RB_Good4 = new System.Windows.Forms.RadioButton();
            this.CB_Categories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Submit
            // 
            this.BTN_Submit.Location = new System.Drawing.Point(287, 344);
            this.BTN_Submit.Name = "BTN_Submit";
            this.BTN_Submit.Size = new System.Drawing.Size(75, 23);
            this.BTN_Submit.TabIndex = 0;
            this.BTN_Submit.Text = "Soumettre";
            this.BTN_Submit.UseVisualStyleBackColor = true;
            this.BTN_Submit.Click += new System.EventHandler(this.BTN_Submit_Click);
            // 
            // TXT_Question
            // 
            this.TXT_Question.Location = new System.Drawing.Point(12, 12);
            this.TXT_Question.Multiline = true;
            this.TXT_Question.Name = "TXT_Question";
            this.TXT_Question.Size = new System.Drawing.Size(350, 163);
            this.TXT_Question.TabIndex = 1;
            // 
            // TXT_Answer1
            // 
            this.TXT_Answer1.Location = new System.Drawing.Point(12, 181);
            this.TXT_Answer1.Name = "TXT_Answer1";
            this.TXT_Answer1.Size = new System.Drawing.Size(247, 20);
            this.TXT_Answer1.TabIndex = 2;
            // 
            // TXT_Answer2
            // 
            this.TXT_Answer2.Location = new System.Drawing.Point(12, 207);
            this.TXT_Answer2.Name = "TXT_Answer2";
            this.TXT_Answer2.Size = new System.Drawing.Size(247, 20);
            this.TXT_Answer2.TabIndex = 2;
            // 
            // TXT_Answer3
            // 
            this.TXT_Answer3.Location = new System.Drawing.Point(12, 233);
            this.TXT_Answer3.Name = "TXT_Answer3";
            this.TXT_Answer3.Size = new System.Drawing.Size(247, 20);
            this.TXT_Answer3.TabIndex = 2;
            // 
            // TXT_Answer4
            // 
            this.TXT_Answer4.Location = new System.Drawing.Point(12, 259);
            this.TXT_Answer4.Name = "TXT_Answer4";
            this.TXT_Answer4.Size = new System.Drawing.Size(247, 20);
            this.TXT_Answer4.TabIndex = 2;
            // 
            // RB_Good1
            // 
            this.RB_Good1.AutoSize = true;
            this.RB_Good1.Location = new System.Drawing.Point(265, 181);
            this.RB_Good1.Name = "RB_Good1";
            this.RB_Good1.Size = new System.Drawing.Size(97, 17);
            this.RB_Good1.TabIndex = 3;
            this.RB_Good1.TabStop = true;
            this.RB_Good1.Text = "Bonne réponse";
            this.RB_Good1.UseVisualStyleBackColor = true;
            // 
            // RB_Good2
            // 
            this.RB_Good2.AutoSize = true;
            this.RB_Good2.Location = new System.Drawing.Point(265, 207);
            this.RB_Good2.Name = "RB_Good2";
            this.RB_Good2.Size = new System.Drawing.Size(97, 17);
            this.RB_Good2.TabIndex = 3;
            this.RB_Good2.TabStop = true;
            this.RB_Good2.Text = "Bonne réponse";
            this.RB_Good2.UseVisualStyleBackColor = true;
            // 
            // RB_Good3
            // 
            this.RB_Good3.AutoSize = true;
            this.RB_Good3.Location = new System.Drawing.Point(265, 233);
            this.RB_Good3.Name = "RB_Good3";
            this.RB_Good3.Size = new System.Drawing.Size(97, 17);
            this.RB_Good3.TabIndex = 3;
            this.RB_Good3.TabStop = true;
            this.RB_Good3.Text = "Bonne réponse";
            this.RB_Good3.UseVisualStyleBackColor = true;
            // 
            // RB_Good4
            // 
            this.RB_Good4.AutoSize = true;
            this.RB_Good4.Location = new System.Drawing.Point(265, 256);
            this.RB_Good4.Name = "RB_Good4";
            this.RB_Good4.Size = new System.Drawing.Size(97, 17);
            this.RB_Good4.TabIndex = 3;
            this.RB_Good4.TabStop = true;
            this.RB_Good4.Text = "Bonne réponse";
            this.RB_Good4.UseVisualStyleBackColor = true;
            // 
            // CB_Categories
            // 
            this.CB_Categories.FormattingEnabled = true;
            this.CB_Categories.Location = new System.Drawing.Point(141, 285);
            this.CB_Categories.Name = "CB_Categories";
            this.CB_Categories.Size = new System.Drawing.Size(118, 21);
            this.CB_Categories.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Categorie";
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(12, 344);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancel.TabIndex = 6;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // AdminQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 379);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_Categories);
            this.Controls.Add(this.RB_Good4);
            this.Controls.Add(this.RB_Good3);
            this.Controls.Add(this.RB_Good2);
            this.Controls.Add(this.RB_Good1);
            this.Controls.Add(this.TXT_Answer4);
            this.Controls.Add(this.TXT_Answer3);
            this.Controls.Add(this.TXT_Answer2);
            this.Controls.Add(this.TXT_Answer1);
            this.Controls.Add(this.TXT_Question);
            this.Controls.Add(this.BTN_Submit);
            this.Name = "AdminQuestions";
            this.ShowIcon = false;
            this.Text = "Questions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Submit;
        private System.Windows.Forms.TextBox TXT_Question;
        private System.Windows.Forms.TextBox TXT_Answer1;
        private System.Windows.Forms.TextBox TXT_Answer2;
        private System.Windows.Forms.TextBox TXT_Answer3;
        private System.Windows.Forms.TextBox TXT_Answer4;
        private System.Windows.Forms.RadioButton RB_Good1;
        private System.Windows.Forms.RadioButton RB_Good2;
        private System.Windows.Forms.RadioButton RB_Good3;
        private System.Windows.Forms.RadioButton RB_Good4;
        private System.Windows.Forms.ComboBox CB_Categories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Cancel;
    }
}