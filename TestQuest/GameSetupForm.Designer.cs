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
            this.tb_Player2 = new System.Windows.Forms.TextBox();
            this.bt_Next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_1
            // 
            this.txt_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_1.Location = new System.Drawing.Point(-2, 176);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(415, 76);
            this.txt_1.TabIndex = 0;
            this.txt_1.Text = "VS";
            this.txt_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Player1
            // 
            this.tb_Player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Player1.Location = new System.Drawing.Point(57, 141);
            this.tb_Player1.Name = "tb_Player1";
            this.tb_Player1.Size = new System.Drawing.Size(299, 32);
            this.tb_Player1.TabIndex = 1;
            this.tb_Player1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Player1.TextChanged += new System.EventHandler(this.tb_Player1_TextChanged);
            // 
            // tb_Player2
            // 
            this.tb_Player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Player2.Location = new System.Drawing.Point(57, 256);
            this.tb_Player2.Name = "tb_Player2";
            this.tb_Player2.Size = new System.Drawing.Size(299, 32);
            this.tb_Player2.TabIndex = 2;
            this.tb_Player2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Player2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bt_Next
            // 
            this.bt_Next.Location = new System.Drawing.Point(133, 306);
            this.bt_Next.Name = "bt_Next";
            this.bt_Next.Size = new System.Drawing.Size(139, 38);
            this.bt_Next.TabIndex = 3;
            this.bt_Next.Text = "GO!";
            this.bt_Next.UseVisualStyleBackColor = true;
            this.bt_Next.Click += new System.EventHandler(this.bt_Next_Click);
            // 
            // GameSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 363);
            this.Controls.Add(this.bt_Next);
            this.Controls.Add(this.tb_Player2);
            this.Controls.Add(this.tb_Player1);
            this.Controls.Add(this.txt_1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameSetupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_1;
        private System.Windows.Forms.TextBox tb_Player1;
        private System.Windows.Forms.TextBox tb_Player2;
        private System.Windows.Forms.Button bt_Next;
    }
}