using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Data.Common;

namespace WpfApplication3
{
    public partial class AddNewCategory : Form
    {
        public AddNewCategory()
        {
            InitializeComponent();
        }

        private void AddNewCategory_Load(object sender, EventArgs e)
        {

        }
        public class category
        {
            public string Description { get; set; }

            public void InsertCat(string Name)
            {
                SqlCeConnection Conn = new SqlCeConnection("Data Source=D:\\TSLU\\MyDatabase4.sdf");
                Conn.Open();
                SqlCeCommand Cmd = new SqlCeCommand();
                Cmd.Connection = Conn;
                Cmd.CommandText = "Insert into Category (Description)Values(@Description)";
                Cmd.Parameters.AddWithValue("@Description", Description);
                Cmd.ExecuteNonQuery();
                Conn.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            category c = new category();
            c.Description= textBox1.Text;
            c.InsertCat(c.Description);
            Close();
        }
    }
}
