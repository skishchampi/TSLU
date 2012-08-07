namespace WpfApplication3
{
    partial class AddAckP
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
            this.addmoreAP = new System.Windows.Forms.Button();
            this.addexitAP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addmoreAP
            // 
            this.addmoreAP.Location = new System.Drawing.Point(96, 78);
            this.addmoreAP.Name = "addmoreAP";
            this.addmoreAP.Size = new System.Drawing.Size(75, 23);
            this.addmoreAP.TabIndex = 0;
            this.addmoreAP.Text = "Add More";
            this.addmoreAP.UseVisualStyleBackColor = true;
            // 
            // addexitAP
            // 
            this.addexitAP.Location = new System.Drawing.Point(182, 78);
            this.addexitAP.Name = "addexitAP";
            this.addexitAP.Size = new System.Drawing.Size(75, 23);
            this.addexitAP.TabIndex = 1;
            this.addexitAP.Text = "AddExit";
            this.addexitAP.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 3;
            // 
            // AddAckP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 126);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addexitAP);
            this.Controls.Add(this.addmoreAP);
            this.Name = "AddAckP";
            this.Text = "Add Acknowledgement: People";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addmoreAP;
        private System.Windows.Forms.Button addexitAP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}