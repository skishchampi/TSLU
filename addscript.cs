﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WpfApplication3
{
    public partial class addscript : Form
    {
        public addscript()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            name = textBox1.Text;
            SqlCeConnection Conn = new SqlCeConnection("Data Source=D:\\TSLU\\MyDatabase4.sdf");
            Conn.Open();
            SqlCeCommand Cmd = new SqlCeCommand();
            Cmd.Connection = Conn;
            Cmd.CommandText = "Insert into Script (Name)Values(@Name)";
            Cmd.Parameters.AddWithValue("@Name", name);
            Cmd.ExecuteNonQuery();
            Conn.Close();
            this.Close();
        }
    }
}
