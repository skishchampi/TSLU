namespace WpfApplication3
{
    partial class aao
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addmoreAO = new System.Windows.Forms.Button();
            this.addexitAO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 1;
            // 
            // addmoreAO
            // 
            this.addmoreAO.Location = new System.Drawing.Point(77, 69);
            this.addmoreAO.Name = "addmoreAO";
            this.addmoreAO.Size = new System.Drawing.Size(75, 23);
            this.addmoreAO.TabIndex = 2;
            this.addmoreAO.Text = "Add More";
            this.addmoreAO.UseVisualStyleBackColor = true;
            // 
            // addexitAO
            // 
            this.addexitAO.Location = new System.Drawing.Point(168, 69);
            this.addexitAO.Name = "addexitAO";
            this.addexitAO.Size = new System.Drawing.Size(75, 23);
            this.addexitAO.TabIndex = 3;
            this.addexitAO.Text = "AddExit";
            this.addexitAO.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 113);
            this.Controls.Add(this.addexitAO);
            this.Controls.Add(this.addmoreAO);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Add Acknowledgement: Organizations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addmoreAO;
        private System.Windows.Forms.Button addexitAO;
    }
}