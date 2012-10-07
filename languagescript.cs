using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WpfApplication3
{
    public partial class languagescript : Form
    {
        public languagescript()
        {
            InitializeComponent();
        }

        private void languagescript_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDatabase4DataSet.Author' table. You can move, or remove it, as needed.
            //this.authorTableAdapter.Fill(this.myDatabase4DataSet.Author);
            // TODO: This line of code loads data into the 'myDatabase4DataSet.Script' table. You can move, or remove it, as needed.
            this.scriptTableAdapter.Fill(this.myDatabase4DataSet.Script);
            // TODO: This line of code loads data into the 'myDatabase4DataSet.Language' table. You can move, or remove it, as needed.
            this.languageTableAdapter.Fill(this.myDatabase4DataSet.Language);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            addlang lang = new addlang();
            lang.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addscript script = new addscript();
            script.Show();
        }
    }
}
