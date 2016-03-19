namespace TestQuest
{
    partial class JokerForm
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
            this.bt_Cat1 = new System.Windows.Forms.Button();
            this.bt_Cat2 = new System.Windows.Forms.Button();
            this.bt_Cat3 = new System.Windows.Forms.Button();
            this.bt_Cat4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Cat1
            // 
            this.bt_Cat1.Location = new System.Drawing.Point(12, 12);
            this.bt_Cat1.Name = "bt_Cat1";
            this.bt_Cat1.Size = new System.Drawing.Size(348, 38);
            this.bt_Cat1.TabIndex = 0;
            this.bt_Cat1.UseVisualStyleBackColor = true;
            this.bt_Cat1.Click += new System.EventHandler(this.bt_Category_Click);
            // 
            // bt_Cat2
            // 
            this.bt_Cat2.Location = new System.Drawing.Point(12, 56);
            this.bt_Cat2.Name = "bt_Cat2";
            this.bt_Cat2.Size = new System.Drawing.Size(348, 38);
            this.bt_Cat2.TabIndex = 0;
            this.bt_Cat2.UseVisualStyleBackColor = true;
            this.bt_Cat2.Click += new System.EventHandler(this.bt_Category_Click);
            // 
            // bt_Cat3
            // 
            this.bt_Cat3.Location = new System.Drawing.Point(12, 100);
            this.bt_Cat3.Name = "bt_Cat3";
            this.bt_Cat3.Size = new System.Drawing.Size(348, 38);
            this.bt_Cat3.TabIndex = 0;
            this.bt_Cat3.UseVisualStyleBackColor = true;
            this.bt_Cat3.Click += new System.EventHandler(this.bt_Category_Click);
            // 
            // bt_Cat4
            // 
            this.bt_Cat4.Location = new System.Drawing.Point(12, 144);
            this.bt_Cat4.Name = "bt_Cat4";
            this.bt_Cat4.Size = new System.Drawing.Size(348, 38);
            this.bt_Cat4.TabIndex = 0;
            this.bt_Cat4.UseVisualStyleBackColor = true;
            this.bt_Cat4.Click += new System.EventHandler(this.bt_Category_Click);
            // 
            // JokerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 196);
            this.ControlBox = false;
            this.Controls.Add(this.bt_Cat4);
            this.Controls.Add(this.bt_Cat3);
            this.Controls.Add(this.bt_Cat2);
            this.Controls.Add(this.bt_Cat1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JokerForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JokerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Cat1;
        private System.Windows.Forms.Button bt_Cat2;
        private System.Windows.Forms.Button bt_Cat3;
        private System.Windows.Forms.Button bt_Cat4;
    }
}