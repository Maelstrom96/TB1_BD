﻿namespace TestQuest
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
            this.bt_Rep1 = new System.Windows.Forms.Button();
            this.bt_Rep2 = new System.Windows.Forms.Button();
            this.bt_Rep3 = new System.Windows.Forms.Button();
            this.bt_Rep4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(298, 602);
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
            // bt_Rep1
            // 
            this.bt_Rep1.Location = new System.Drawing.Point(23, 434);
            this.bt_Rep1.Name = "bt_Rep1";
            this.bt_Rep1.Size = new System.Drawing.Size(438, 32);
            this.bt_Rep1.TabIndex = 5;
            this.bt_Rep1.UseVisualStyleBackColor = true;
            // 
            // bt_Rep2
            // 
            this.bt_Rep2.Location = new System.Drawing.Point(23, 472);
            this.bt_Rep2.Name = "bt_Rep2";
            this.bt_Rep2.Size = new System.Drawing.Size(438, 32);
            this.bt_Rep2.TabIndex = 5;
            this.bt_Rep2.UseVisualStyleBackColor = true;
            // 
            // bt_Rep3
            // 
            this.bt_Rep3.Location = new System.Drawing.Point(23, 510);
            this.bt_Rep3.Name = "bt_Rep3";
            this.bt_Rep3.Size = new System.Drawing.Size(438, 32);
            this.bt_Rep3.TabIndex = 5;
            this.bt_Rep3.UseVisualStyleBackColor = true;
            // 
            // bt_Rep4
            // 
            this.bt_Rep4.Location = new System.Drawing.Point(23, 548);
            this.bt_Rep4.Name = "bt_Rep4";
            this.bt_Rep4.Size = new System.Drawing.Size(438, 32);
            this.bt_Rep4.TabIndex = 5;
            this.bt_Rep4.UseVisualStyleBackColor = true;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 642);
            this.Controls.Add(this.bt_Rep4);
            this.Controls.Add(this.bt_Rep3);
            this.Controls.Add(this.bt_Rep2);
            this.Controls.Add(this.bt_Rep1);
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

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lb_Categorie;
        private System.Windows.Forms.Button BTN_Admin;
        private System.Windows.Forms.Button bt_Rep1;
        private System.Windows.Forms.Button bt_Rep2;
        private System.Windows.Forms.Button bt_Rep3;
        private System.Windows.Forms.Button bt_Rep4;
    }
}
