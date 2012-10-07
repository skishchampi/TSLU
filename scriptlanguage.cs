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
    public partial class scriptlanguage : Form
    {
        public scriptlanguage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addlang al = new addlang();
            al.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addscript asc = new addscript();
            asc.Show();
        }

        private void scriptlanguage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDatabase4DataSet.Script' table. You can move, or remove it, as needed.
            this.scriptTableAdapter.Fill(this.myDatabase4DataSet.Script);
            // TODO: This line of code loads data into the 'myDatabase4DataSet.Language' table. You can move, or remove it, as needed.
            this.languageTableAdapter.Fill(this.myDatabase4DataSet.Language);

        }
    }
}
