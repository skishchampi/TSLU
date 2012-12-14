namespace WpfApplication3
{
    partial class organizations
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
            this.label1 = new System.Windows.Forms.Label();
            this.addmoreAO = new System.Windows.Forms.Button();
            this.addexitAO = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.myDatabase4DataSet = new WpfApplication3.MyDatabase4DataSet();
            this.myDatabase4DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mAOrganizationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mAOrganizationsTableAdapter = new WpfApplication3.MyDatabase4DataSetTableAdapters.MAOrganizationsTableAdapter();
            this.organizationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.organizationsTableAdapter = new WpfApplication3.MyDatabase4DataSetTableAdapters.OrganizationsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabase4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabase4DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAOrganizationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationsBindingSource)).BeginInit();
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
            // addmoreAO
            // 
            this.addmoreAO.Location = new System.Drawing.Point(77, 102);
            this.addmoreAO.Name = "addmoreAO";
            this.addmoreAO.Size = new System.Drawing.Size(75, 23);
            this.addmoreAO.TabIndex = 2;
            this.addmoreAO.Text = "Add More";
            this.addmoreAO.UseVisualStyleBackColor = true;
            // 
            // addexitAO
            // 
            this.addexitAO.Location = new System.Drawing.Point(168, 102);
            this.addexitAO.Name = "addexitAO";
            this.addexitAO.Size = new System.Drawing.Size(75, 23);
            this.addexitAO.TabIndex = 3;
            this.addexitAO.Text = "AddExit";
            this.addexitAO.UseVisualStyleBackColor = true;
            this.addexitAO.Click += new System.EventHandler(this.addexitAO_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mention",
            "Acknowledgement"});
            this.comboBox1.Location = new System.Drawing.Point(77, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "M/A";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.organizationsBindingSource, "ID", true));
            this.comboBox2.DataSource = this.organizationsBindingSource;
            this.comboBox2.DisplayMember = "Name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(77, 37);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(166, 21);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.ValueMember = "ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // myDatabase4DataSet
            // 
            this.myDatabase4DataSet.DataSetName = "MyDatabase4DataSet";
            this.myDatabase4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myDatabase4DataSetBindingSource
            // 
            this.myDatabase4DataSetBindingSource.DataSource = this.myDatabase4DataSet;
            this.myDatabase4DataSetBindingSource.Position = 0;
            // 
            // mAOrganizationsBindingSource
            // 
            this.mAOrganizationsBindingSource.DataMember = "MAOrganizations";
            this.mAOrganizationsBindingSource.DataSource = this.myDatabase4DataSetBindingSource;
            // 
            // mAOrganizationsTableAdapter
            // 
            this.mAOrganizationsTableAdapter.ClearBeforeFill = true;
            // 
            // organizationsBindingSource
            // 
            this.organizationsBindingSource.DataMember = "Organizations";
            this.organizationsBindingSource.DataSource = this.myDatabase4DataSetBindingSource;
            // 
            // organizationsTableAdapter
            // 
            this.organizationsTableAdapter.ClearBeforeFill = true;
            // 
            // organizations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 156);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.addexitAO);
            this.Controls.Add(this.addmoreAO);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "organizations";
            this.Text = "Organizations";
            this.Load += new System.EventHandler(this.organizations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDatabase4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabase4DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAOrganizationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addmoreAO;
        private System.Windows.Forms.Button addexitAO;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource myDatabase4DataSetBindingSource;
        private MyDatabase4DataSet myDatabase4DataSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource mAOrganizationsBindingSource;
        private MyDatabase4DataSetTableAdapters.MAOrganizationsTableAdapter mAOrganizationsTableAdapter;
        private System.Windows.Forms.BindingSource organizationsBindingSource;
        private MyDatabase4DataSetTableAdapters.OrganizationsTableAdapter organizationsTableAdapter;
    }
}