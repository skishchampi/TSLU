namespace WpfApplication3
{
    partial class scriptlanguage
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.languageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MyDatabase4DataSet = new WpfApplication3.MyDatabase4DataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.scriptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.languageTableAdapter = new WpfApplication3.MyDatabase4DataSetTableAdapters.LanguageTableAdapter();
            this.scriptTableAdapter = new WpfApplication3.MyDatabase4DataSetTableAdapters.ScriptTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.languageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyDatabase4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scriptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "AddExit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(205, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Language";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Script";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.languageBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(68, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "ID";
            // 
            // languageBindingSource
            // 
            this.languageBindingSource.DataMember = "Language";
            this.languageBindingSource.DataSource = this.MyDatabase4DataSet;
            // 
            // MyDatabase4DataSet
            // 
            this.MyDatabase4DataSet.DataSetName = "MyDatabase4DataSet";
            this.MyDatabase4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.scriptBindingSource;
            this.comboBox2.DisplayMember = "Name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(68, 85);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.ValueMember = "ID";
            // 
            // scriptBindingSource
            // 
            this.scriptBindingSource.DataMember = "Script";
            this.scriptBindingSource.DataSource = this.MyDatabase4DataSet;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(91, 133);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "AddMore";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // languageTableAdapter
            // 
            this.languageTableAdapter.ClearBeforeFill = true;
            // 
            // scriptTableAdapter
            // 
            this.scriptTableAdapter.ClearBeforeFill = true;
            // 
            // scriptlanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 185);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "scriptlanguage";
            this.Text = "To: Language and Script";
            this.Load += new System.EventHandler(this.scriptlanguage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.languageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyDatabase4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scriptBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button4;
        private MyDatabase4DataSet MyDatabase4DataSet;
        private System.Windows.Forms.BindingSource languageBindingSource;
        private MyDatabase4DataSetTableAdapters.LanguageTableAdapter languageTableAdapter;
        private System.Windows.Forms.BindingSource scriptBindingSource;
        private MyDatabase4DataSetTableAdapters.ScriptTableAdapter scriptTableAdapter;
    }
}