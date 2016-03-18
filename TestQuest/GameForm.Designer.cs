namespace TestQuest
{
    partial class GameForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3 = new System.Windows.Forms.Button();
            this.lb_Categorie = new System.Windows.Forms.Label();
            this.BTN_Admin = new System.Windows.Forms.Button();
            this.LBL_Questions = new System.Windows.Forms.Label();
            this.BTN_Answer1 = new System.Windows.Forms.Button();
            this.BTN_Answer2 = new System.Windows.Forms.Button();
            this.BTN_Answer3 = new System.Windows.Forms.Button();
            this.BTN_Answer4 = new System.Windows.Forms.Button();
            this.LBL_Score0 = new System.Windows.Forms.Label();
            this.LBL_score1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(296, 607);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Rand Animation";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lb_Categorie
            // 
            this.lb_Categorie.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Categorie.Location = new System.Drawing.Point(-1, 334);
            this.lb_Categorie.Name = "lb_Categorie";
            this.lb_Categorie.Size = new System.Drawing.Size(485, 21);
            this.lb_Categorie.TabIndex = 3;
            this.lb_Categorie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_Admin
            // 
            this.BTN_Admin.Location = new System.Drawing.Point(376, 12);
            this.BTN_Admin.Name = "BTN_Admin";
            this.BTN_Admin.Size = new System.Drawing.Size(85, 23);
            this.BTN_Admin.TabIndex = 4;
            this.BTN_Admin.Text = "Administration";
            this.BTN_Admin.UseVisualStyleBackColor = true;
            this.BTN_Admin.Click += new System.EventHandler(this.BTN_Admin_Click);
            // 
            // LBL_Questions
            // 
            this.LBL_Questions.AutoSize = true;
            this.LBL_Questions.Location = new System.Drawing.Point(54, 397);
            this.LBL_Questions.Name = "LBL_Questions";
            this.LBL_Questions.Size = new System.Drawing.Size(10, 13);
            this.LBL_Questions.TabIndex = 5;
            this.LBL_Questions.Text = ".";
            // 
            // BTN_Answer1
            // 
            this.BTN_Answer1.Location = new System.Drawing.Point(12, 432);
            this.BTN_Answer1.Name = "BTN_Answer1";
            this.BTN_Answer1.Size = new System.Drawing.Size(449, 23);
            this.BTN_Answer1.TabIndex = 6;
            this.BTN_Answer1.Text = "answer1";
            this.BTN_Answer1.UseVisualStyleBackColor = true;
            this.BTN_Answer1.Visible = false;
            // 
            // BTN_Answer2
            // 
            this.BTN_Answer2.Location = new System.Drawing.Point(12, 477);
            this.BTN_Answer2.Name = "BTN_Answer2";
            this.BTN_Answer2.Size = new System.Drawing.Size(449, 23);
            this.BTN_Answer2.TabIndex = 6;
            this.BTN_Answer2.Text = "Answer2";
            this.BTN_Answer2.UseVisualStyleBackColor = true;
            this.BTN_Answer2.Visible = false;
            // 
            // BTN_Answer3
            // 
            this.BTN_Answer3.Location = new System.Drawing.Point(12, 523);
            this.BTN_Answer3.Name = "BTN_Answer3";
            this.BTN_Answer3.Size = new System.Drawing.Size(449, 23);
            this.BTN_Answer3.TabIndex = 6;
            this.BTN_Answer3.Text = "Answer3";
            this.BTN_Answer3.UseVisualStyleBackColor = true;
            this.BTN_Answer3.Visible = false;
            // 
            // BTN_Answer4
            // 
            this.BTN_Answer4.Location = new System.Drawing.Point(12, 569);
            this.BTN_Answer4.Name = "BTN_Answer4";
            this.BTN_Answer4.Size = new System.Drawing.Size(449, 23);
            this.BTN_Answer4.TabIndex = 6;
            this.BTN_Answer4.Text = "answer4";
            this.BTN_Answer4.UseVisualStyleBackColor = true;
            this.BTN_Answer4.Visible = false;
            // 
            // LBL_Score0
            // 
            this.LBL_Score0.AutoSize = true;
            this.LBL_Score0.Location = new System.Drawing.Point(12, 12);
            this.LBL_Score0.Name = "LBL_Score0";
            this.LBL_Score0.Size = new System.Drawing.Size(35, 13);
            this.LBL_Score0.TabIndex = 7;
            this.LBL_Score0.Text = "label1";
            // 
            // LBL_score1
            // 
            this.LBL_score1.AutoSize = true;
            this.LBL_score1.Location = new System.Drawing.Point(54, 12);
            this.LBL_score1.Name = "LBL_score1";
            this.LBL_score1.Size = new System.Drawing.Size(35, 13);
            this.LBL_score1.TabIndex = 7;
            this.LBL_score1.Text = "label1";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 641);
            this.Controls.Add(this.LBL_score1);
            this.Controls.Add(this.LBL_Score0);
            this.Controls.Add(this.BTN_Answer4);
            this.Controls.Add(this.BTN_Answer3);
            this.Controls.Add(this.BTN_Answer2);
            this.Controls.Add(this.BTN_Answer1);
            this.Controls.Add(this.LBL_Questions);
            this.Controls.Add(this.BTN_Admin);
            this.Controls.Add(this.lb_Categorie);
            this.Controls.Add(this.button3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 680);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 680);
            this.Name = "GameForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lb_Categorie;
        private System.Windows.Forms.Button BTN_Admin;
        private System.Windows.Forms.Label LBL_Questions;
        private System.Windows.Forms.Button BTN_Answer1;
        private System.Windows.Forms.Button BTN_Answer2;
        private System.Windows.Forms.Button BTN_Answer3;
        private System.Windows.Forms.Button BTN_Answer4;
        private System.Windows.Forms.Label LBL_Score0;
        private System.Windows.Forms.Label LBL_score1;
    }
}

