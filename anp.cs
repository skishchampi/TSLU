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
    public partial class AddNewPublisher : Form
    {
        public AddNewPublisher()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public class publisherloc
        {
            //Name and ID for publishers
            public string Name { get; set; }
            public int location  { get; set; }
            //The below information goes into Location Table
            public string Street { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public int Pin { get; set; }
            public string Country { get; set; }

            public void publoc(publisherloc pl)
            {
                SqlCeConnection Conn = new SqlCeConnection("Data Source=D:\\TSLU\\MyDatabase4.sdf");
                Conn.Open();
                SqlCeCommand Cmd = new SqlCeCommand();
                Cmd.Connection = Conn;
                Cmd.CommandText = "Insert into Location (Street,City,State,Country,PIN)Values(@Street,@City,@State,@Country,@PIN)";
                Cmd.Parameters.AddWithValue("@Street", pl.Street);
                Cmd.Parameters.AddWithValue("@City", pl.City);
                Cmd.Parameters.AddWithValue("@State", pl.State);
                Cmd.Parameters.AddWithValue("@Pin", pl.Pin);
                Cmd.Parameters.AddWithValue("@Country", pl.Country);
                Cmd.ExecuteNonQuery();
                //Conn.Close();
                {//Getting the ID of the location record last entered. This will go as foreign key in Publisher's location column.
                    SqlCeDataAdapter adap = new SqlCeDataAdapter("SELECT max(ID) FROM Location", "Data Source=D:\\TSLU\\MyDatabase4.sdf");
                    DataSet dat = new DataSet();
                    adap.Fill(dat);
                    Int32 First = Convert.ToInt32(dat.Tables[0].Rows[0]["Column1"].ToString());
                    pl.location = First;
                }
                //Conn.Open();
                //SqlCeCommand Cmd2 = new SqlCeCommand();
                Cmd.CommandText = "Insert into Publisher (Name, Location)Values(@Name,@Location)";
                Cmd.Parameters.AddWithValue("@Name", pl.Name);
                Cmd.Parameters.AddWithValue("@Location", pl.location);
                Cmd.ExecuteNonQuery();
                Conn.Close();

            }
        }
        public class location
        {
            public int ID { get; set;}
            public string Street { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public int Pin { get; set; }
            public string Country { get; set; }
        }
        private void AddExit_Click(object sender, EventArgs e)
        {
            publisherloc pl = new publisherloc();
            pl.Name = textBox1.Text;
            pl.Street = textBox2.Text;
            pl.City = textBox3.Text;
            pl.State = textBox4.Text;
            pl.Pin = Convert.ToInt32(textBox5.Text);
            pl.Country = textBox6.Text;
            /*{//Getting the ID of the location record last entered. This will go as foreign key in Publisher's location column.
                SqlCeDataAdapter adap = new SqlCeDataAdapter("SELECT max(ID) FROM Location", "Data Source=D:\\TSLU\\MyDatabase4.sdf");
                DataSet dat = new DataSet();
                adap.Fill(dat);
                Int32 First = Convert.ToInt32(dat.Tables[0].Rows[0]["Column1"].ToString());
                pl.location = First;
            }*/
            //Finally calling the method
            pl.location = 0;
            pl.publoc(pl);
            Close();
        }
    }
}
