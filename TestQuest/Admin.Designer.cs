namespace TestQuest
{
    partial class Admin
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
            this.BTN_Questions = new System.Windows.Forms.Button();
            this.BTN_Players = new System.Windows.Forms.Button();
            this.DGV_Admin = new System.Windows.Forms.DataGridView();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.BTN_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Admin)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Questions
            // 
            this.BTN_Questions.Location = new System.Drawing.Point(12, 12);
            this.BTN_Questions.Name = "BTN_Questions";
            this.BTN_Questions.Size = new System.Drawing.Size(75, 23);
            this.BTN_Questions.TabIndex = 0;
            this.BTN_Questions.Text = "Questions";
            this.BTN_Questions.UseVisualStyleBackColor = true;
            this.BTN_Questions.Click += new System.EventHandler(this.BTN_Questions_Click);
            // 
            // BTN_Players
            // 
            this.BTN_Players.Location = new System.Drawing.Point(93, 12);
            this.BTN_Players.Name = "BTN_Players";
            this.BTN_Players.Size = new System.Drawing.Size(75, 23);
            this.BTN_Players.TabIndex = 0;
            this.BTN_Players.Text = "Joueurs";
            this.BTN_Players.UseVisualStyleBackColor = true;
            this.BTN_Players.Click += new System.EventHandler(this.BTN_Players_Click);
            // 
            // DGV_Admin
            // 
            this.DGV_Admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Admin.Location = new System.Drawing.Point(13, 42);
            this.DGV_Admin.Name = "DGV_Admin";
            this.DGV_Admin.Size = new System.Drawing.Size(621, 256);
            this.DGV_Admin.TabIndex = 1;
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Location = new System.Drawing.Point(559, 12);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(75, 23);
            this.BTN_Delete.TabIndex = 2;
            this.BTN_Delete.Text = "Supprimer";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Visible = false;
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.Location = new System.Drawing.Point(478, 12);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(75, 23);
            this.BTN_Modifier.TabIndex = 3;
            this.BTN_Modifier.Text = "Modifier";
            this.BTN_Modifier.UseVisualStyleBackColor = true;
            this.BTN_Modifier.Visible = false;
            // 
            // BTN_Add
            // 
            this.BTN_Add.Location = new System.Drawing.Point(397, 12);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(75, 23);
            this.BTN_Add.TabIndex = 3;
            this.BTN_Add.Text = "Ajouter";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Visible = false;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 309);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.DGV_Admin);
            this.Controls.Add(this.BTN_Players);
            this.Controls.Add(this.BTN_Questions);
            this.Name = "Admin";
            this.ShowIcon = false;
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Admin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Questions;
        private System.Windows.Forms.Button BTN_Players;
        private System.Windows.Forms.DataGridView DGV_Admin;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Button BTN_Add;
    }
}