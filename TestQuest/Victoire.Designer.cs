namespace TestQuest
{
    partial class Victoire
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
            this.txt_ = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_Result = new System.Windows.Forms.Label();
            this.lb_PlayerStats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_
            // 
            this.txt_.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_.Location = new System.Drawing.Point(12, 22);
            this.txt_.Name = "txt_";
            this.txt_.Size = new System.Drawing.Size(431, 60);
            this.txt_.TabIndex = 0;
            this.txt_.Text = "Victoire!";
            this.txt_.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Terminer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_Result
            // 
            this.lb_Result.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Result.Location = new System.Drawing.Point(12, 113);
            this.lb_Result.Name = "lb_Result";
            this.lb_Result.Size = new System.Drawing.Size(431, 42);
            this.lb_Result.TabIndex = 2;
            this.lb_Result.Text = "Stats";
            this.lb_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_PlayerStats
            // 
            this.lb_PlayerStats.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PlayerStats.Location = new System.Drawing.Point(12, 155);
            this.lb_PlayerStats.Name = "lb_PlayerStats";
            this.lb_PlayerStats.Size = new System.Drawing.Size(431, 35);
            this.lb_PlayerStats.TabIndex = 2;
            this.lb_PlayerStats.Text = "Stats";
            this.lb_PlayerStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Victoire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 277);
            this.Controls.Add(this.lb_PlayerStats);
            this.Controls.Add(this.lb_Result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Victoire";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Victoire";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txt_;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_Result;
        private System.Windows.Forms.Label lb_PlayerStats;
    }
}