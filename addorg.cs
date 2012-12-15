using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Data.SqlClient;

namespace WpfApplication3
{
    public partial class addorg : Form
    {
        public addorg()
        {
            InitializeComponent();
            
        }

        public string name { get; set; } 

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            SqlCeConnection Conn = new SqlCeConnection("Data Source=D:\\TSLU\\MyDatabase4.sdf");
            Conn.Open();
            SqlCeCommand Cmd = new SqlCeCommand();
            Cmd.Connection = Conn;
            Cmd.CommandText = "Insert into Organization (Name)Values(@Name)";
            Cmd.Parameters.AddWithValue("@Name", name);
            Cmd.ExecuteNonQuery();
            Conn.Close();
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            name = textBox1.Text;
            SqlCeConnection Conn = new SqlCeConnection("Data Source=D:\\TSLU\\MyDatabase4.sdf");
            Conn.Open();
            SqlCeCommand Cmd = new SqlCeCommand();
            Cmd.Connection = Conn;
            Cmd.CommandText = "Insert into Organizations (Name)Values(@Name)";
            Cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            Cmd.ExecuteNonQuery();
            Conn.Close();
            Close();
        }
    }
}
