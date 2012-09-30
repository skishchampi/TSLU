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
    public partial class ana : Form
    {
        public ana()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ana_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database3DataSet.Author' table. You can move, or remove it, as needed.
            this.authorTableAdapter.Fill(this.database3DataSet.Author);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
