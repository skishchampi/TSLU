﻿using System;
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
            // TODO: This line of code loads data into the 'MyDatabase4DataSet.Script' table. You can move, or remove it, as needed.
            this.scriptTableAdapter.Fill(this.MyDatabase4DataSet.Script);
            // TODO: This line of code loads data into the 'MyDatabase4DataSet.Language' table. You can move, or remove it, as needed.
            this.languageTableAdapter.Fill(this.MyDatabase4DataSet.Language);

        }
        public static orgp[] array_l = new orgp[5];

        public static int i_l = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            for (int hujintao = 0; hujintao < 5; hujintao++)
            {
                array_l[hujintao] = new orgp();
            }
            array_l[i_l].id = Convert.ToInt32(comboBox1.SelectedValue);//id from language table
            array_l[i_l].ma = Convert.ToInt32(comboBox2.SelectedValue);//id from script table
            i_l = i_l + 1;
        }
    }
}
