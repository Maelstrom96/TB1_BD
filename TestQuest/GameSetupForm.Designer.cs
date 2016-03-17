namespace TestQuest
{
    partial class GameSetupForm
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
            this.txt_1 = new System.Windows.Forms.Label();
            this.tb_Player1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_1
            // 
            this.txt_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_1.Font = new System.Drawing.Font("Minion Pro SmBd", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_1.Location = new System.Drawing.Point(0, 215);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(415, 76);
            this.txt_1.TabIndex = 0;
            this.txt_1.Text = "VS";
            this.txt_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Player1
            // 
            this.tb_Player1.Font = new System.Drawing.Font("Minion Pro SmBd", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Player1.Location = new System.Drawing.Point(58, 179);
            this.tb_Player1.Name = "tb_Player1";
            this.tb_Player1.Size = new System.Drawing.Size(299, 33);
            this.tb_Player1.TabIndex = 1;
            this.tb_Player1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Player1.TextChanged += new System.EventHandler(this.tb_Player1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Minion Pro SmBd", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(58, 294);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 33);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // GameSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 394);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tb_Player1);
            this.Controls.Add(this.txt_1);
            this.Name = "GameSetupForm";
            this.Text = "GameSetupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_1;
        private System.Windows.Forms.TextBox tb_Player1;
        private System.Windows.Forms.TextBox textBox1;
    }
}