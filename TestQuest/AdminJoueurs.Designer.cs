namespace TestQuest
{
    partial class AdminJoueurs
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
            this.TXB_Alias = new System.Windows.Forms.TextBox();
            this.TXB_Prenom = new System.Windows.Forms.TextBox();
            this.TXB_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Submit
            // 
            this.BTN_Submit.Location = new System.Drawing.Point(128, 102);
            this.BTN_Submit.Name = "BTN_Submit";
            this.BTN_Submit.Size = new System.Drawing.Size(75, 23);
            this.BTN_Submit.TabIndex = 0;
            this.BTN_Submit.Text = "Soumettre";
            this.BTN_Submit.UseVisualStyleBackColor = true;
            this.BTN_Submit.Click += new System.EventHandler(this.BTN_Submit_Click);
            // 
            // TXB_Alias
            // 
            this.TXB_Alias.Location = new System.Drawing.Point(102, 12);
            this.TXB_Alias.Name = "TXB_Alias";
            this.TXB_Alias.Size = new System.Drawing.Size(100, 20);
            this.TXB_Alias.TabIndex = 1;
            // 
            // TXB_Prenom
            // 
            this.TXB_Prenom.Location = new System.Drawing.Point(102, 38);
            this.TXB_Prenom.Name = "TXB_Prenom";
            this.TXB_Prenom.Size = new System.Drawing.Size(100, 20);
            this.TXB_Prenom.TabIndex = 1;
            // 
            // TXB_Name
            // 
            this.TXB_Name.Location = new System.Drawing.Point(102, 64);
            this.TXB_Name.Name = "TXB_Name";
            this.TXB_Name.Size = new System.Drawing.Size(100, 20);
            this.TXB_Name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom";
            // 
            // AdminJoueurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 137);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXB_Name);
            this.Controls.Add(this.TXB_Prenom);
            this.Controls.Add(this.TXB_Alias);
            this.Controls.Add(this.BTN_Submit);
            this.Name = "AdminJoueurs";
            this.Text = "AdminJoueurs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Submit;
        private System.Windows.Forms.TextBox TXB_Alias;
        private System.Windows.Forms.TextBox TXB_Prenom;
        private System.Windows.Forms.TextBox TXB_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}