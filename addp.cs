using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlServerCe;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WpfApplication3
{
    public partial class addp : Form
    {
        public addp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            SqlCeConnection Conn = new SqlCeConnection("Data Source=D:\\TSLU\\MyDatabase4.sdf");
            Conn.Open();
            SqlCeCommand Cmd = new SqlCeCommand();
            Cmd.Connection = Conn;
            Cmd.CommandText = "Insert into People (Name)Values(@Name)";
            Cmd.Parameters.AddWithValue("@Name", name);
            Cmd.ExecuteNonQuery();
            Conn.Close();
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            SqlCeConnection Conn = new SqlCeConnection("Data Source=D:\\TSLU\\MyDatabase4.sdf");
            Conn.Open();
            SqlCeCommand Cmd = new SqlCeCommand();
            Cmd.Connection = Conn;
            Cmd.CommandText = "Insert into People (Name)Values(@Name)";
            Cmd.Parameters.AddWithValue("@Name", name);
            Cmd.ExecuteNonQuery();
            Conn.Close();
            Close();
        }
    }
}
