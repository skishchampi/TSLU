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
            // TODO: This line of code loads data into the 'myDatabase4DataSet.Author' table. You can move, or remove it, as needed.
            this.authorTableAdapter1.Fill(this.myDatabase4DataSet.Author);
            // TODO: This line of code loads data into the 'database3DataSet.Author' table. You can move, or remove it, as needed.
           // this.authorTableAdapter.Fill(this.database3DataSet.Author);

        }
        public class author
        {
            public string Name {get; set;}
            
            public void InsertAuth(string Name)
            {
                SqlCeConnection Conn = new SqlCeConnection("Data Source=D:\\TSLU\\MyDatabase4.sdf");
                Conn.Open();
                SqlCeCommand Cmd = new SqlCeCommand();
                Cmd.Connection = Conn;
                Cmd.CommandText = "Insert into Author (Name)Values(@Name)";
                Cmd.Parameters.AddWithValue("@Name", Name);
                Cmd.ExecuteNonQuery();
                Conn.Close();
                
            }
        }
        public static int i = 0;
        public static int[] array = new int[10];
        private void button1_Click(object sender, EventArgs e)
        {
            
            array[i] = (int)comboBox1.SelectedValue;
            Console.WriteLine(array[i]);
            i++;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* author author = new author();
             author.Name = textBox1.Text;
             author.InsertAuth(author.Name);
             * i=0;
             * return array;
             Close();
            
             */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            author author = new author();
            author.Name = textBox1.Text;
            author.InsertAuth(author.Name);
            textBox1.Text = "";
        }

        
    }
}
