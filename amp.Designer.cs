namespace WpfApplication3
{
    partial class AddMentionP
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
            this.addmoreP = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addexitP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addmoreP
            // 
            this.addmoreP.Location = new System.Drawing.Point(58, 78);
            this.addmoreP.Name = "addmoreP";
            this.addmoreP.Size = new System.Drawing.Size(75, 30);
            this.addmoreP.TabIndex = 0;
            this.addmoreP.Text = "Add More";
            this.addmoreP.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // addexitP
            // 
            this.addexitP.Location = new System.Drawing.Point(139, 78);
            this.addexitP.Name = "addexitP";
            this.addexitP.Size = new System.Drawing.Size(75, 30);
            this.addexitP.TabIndex = 3;
            this.addexitP.Text = "Add&Exit";
            this.addexitP.UseVisualStyleBackColor = true;
            // 
            // AddMentionP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 120);
            this.Controls.Add(this.addexitP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addmoreP);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddMentionP";
            this.Text = "Add Mentions of People";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addmoreP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addexitP;
    }
}