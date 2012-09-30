using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Data.Common;
using System.Data;


namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            comboBox1_SelectionChanged(comboBox2);
            comboBox2_SelectionChanged(comboBox2);
        }

        private void textBox15_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void addnewcategory_Click(object sender, RoutedEventArgs e)
        {
            AddNewCategory anc = new AddNewCategory();
            anc.Show();
        }

        private void addnewpublisher_Click(object sender, RoutedEventArgs e)
        {
            AddNewPublisher anp = new AddNewPublisher();
            anp.Show();
        }

        private void addmoreauthor_Click(object sender, RoutedEventArgs e)
        {
            ana ana = new ana();
            ana.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            aao addack = new aao();
            addack.Show();

        }

        private void AddRecord_Click(object sender, RoutedEventArgs e)
        {
            clsDic dicitem = new clsDic();
            dicitem.Title = title.Text;
            dicitem.ISBN = Convert.ToInt32(isbn.Text);


        }
        public class clsDic
        {
            public int ID { get; set; }
            public string Title { get; set; }
            public int ISBN { get; set; }
            public int Edition { get; set; }
            public int Volume { get; set; }
            public int Part { get; set; }
            public int Copies { get; set; }
            public int Words { get; set; }
            public string Notes { get; set; }
            public int Category { get; set; }
        }

        public class DataAccess
        {
            SqlConnection Conn;
            SqlCommand Cmd;

            public DataAccess()
            {
                Conn = new SqlConnection("Data Source=D:\\TSLU\\Database3.sdf;Initial Catalog=Company;Integrated Security=SSPI");
            }
            
            public ObservableCollection<clsDic> GetAllDictionaries()
            {
                ObservableCollection<clsDic> Dic = new ObservableCollection<clsDic>();
                Conn.Open();
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandText = "Select * from Dictionaries";
                SqlDataReader Reader = Cmd.ExecuteReader();
                
                while (Reader.Read())
                {
                    Dic.Add(new clsDic()
                    {
                        //ID = Convert.ToInt32(Reader["ID"]),
                        Title = Reader["Title"].ToString(),
                        ISBN = Convert.ToInt32(Reader["ISBN"]),
                        Edition = Convert.ToInt32(Reader["Edition"]),
                        Volume = Convert.ToInt32(Reader["Volume"]),
                        Part = Convert.ToInt32(Reader["Volume"]),
                        Copies = Convert.ToInt32(Reader["Copies"]),
                        Words = Convert.ToInt32(Reader["Words"]),
                        Notes = Reader["Notes"].ToString(),
                        Category = Convert.ToInt32(Reader["Category"])

                    });
                }

                Conn.Close();
                return Dic;
            }

            public void InsertDic(clsDic objEmp)
            {
                Conn.Open();
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandText = "Insert into Dictionaries Values(@Title,@ISBN,@Edition,@Volume,@Part,@Copies,@Words,@Notes,@Category)";
                //Cmd.Parameters.AddWithValue("@ID", objEmp.ID);
                Cmd.Parameters.AddWithValue("@Title", objEmp.Title);
                Cmd.Parameters.AddWithValue("@ISBN", objEmp.ISBN);
                Cmd.Parameters.AddWithValue("@Edition", objEmp.Edition);
                Cmd.Parameters.AddWithValue("@Volume", objEmp.Volume);
                Cmd.Parameters.AddWithValue("@Part", objEmp.Part);
                Cmd.Parameters.AddWithValue("@Copies", objEmp.Copies);
                Cmd.Parameters.AddWithValue("@Words", objEmp.Words);
                Cmd.Parameters.AddWithValue("@Notes", objEmp.Notes);
                Cmd.Parameters.AddWithValue("@Category", objEmp.Category);
                Cmd.ExecuteNonQuery();
                Conn.Close();
            }
        }

        private void comboBox1_SelectionChanged(ComboBox comboBox)
        {
            SqlCeConnection sqlCon = new SqlCeConnection("Data Source=D:\\TSLU\\Database3.sdf; Persist Security Info=False");
            SqlCeDataAdapter da = new SqlCeDataAdapter("Select * FROM Author", sqlCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "Author");
            comboBox1.ItemsSource = ds.Tables["Author"].DefaultView;
            comboBox1.DisplayMemberPath = ds.Tables["Author"].Columns["Name"].ToString();
            comboBox1.SelectedValuePath = ds.Tables["Author"].Columns["ID"].ToString();

        }

        private void comboBox2_SelectionChanged(ComboBox comboBox)
        {
            SqlCeConnection sqlCon = new SqlCeConnection("Data Source=D:\\TSLU\\Database3.sdf; Persist Security Info=False");
            SqlCeDataAdapter da = new SqlCeDataAdapter("Select * FROM Category", sqlCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "Category");
            comboBox2.ItemsSource = ds.Tables["Category"].DefaultView;
            comboBox2.DisplayMemberPath = ds.Tables["Category"].Columns["Description"].ToString();
            comboBox2.SelectedValuePath = ds.Tables["Category"].Columns["ID"].ToString();
            
        }

    }
}
