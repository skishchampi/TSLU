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
            //comboBox1_SelectionChanged(authorcombo);
            comboBox2_SelectionChanged(publishercombo);
            comboBox3_SelectionChanged(categorycombo);
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
            organizations addack = new organizations();
            addack.Show();

        }

        private void AddRecord_Click(object sender, RoutedEventArgs e)
        {
            /*clsDic dicitem = new clsDic();
            dicitem.Title = title.Text;
            Console.WriteLine(dicitem.Title);
            dicitem.ISBN = Convert.ToUInt64(isbn.Text);
            dicitem.Edition = Convert.ToDateTime(datePicker1.Text);
            dicitem.Part = Convert.ToInt32(part.Text);
            dicitem.Copies = Convert.ToInt32(numberofcopies.Text);
            dicitem.Words = Convert.ToInt32(numberofwords.Text);
            dicitem.Notes = notes.Text;
            dicitem.Category = Convert.ToInt32(categorycombo.SelectedValue);
            dicitem.Publisher = Convert.ToInt32(publishercombo.SelectedValue);
            //call author list
            //call org list
            //call people list
            //call to lang list
            //call fr lang list*/
            int i = ana.array[0];
            Console.WriteLine(i);



        }
        /*
        public class clsDic
        {
            
            public int ID {get; set;}
            public string Title { get; set; }
            public int ISBN { get; set; }
            public int Edition { get; set; }
            public int Volume { get; set; }
            public int Part { get; set; }
            public int Copies { get; set; }
            public int Words { get; set; }
            public string Notes { get; set; }
            public int Category { get; set; }
            public int Publisher { get; set; }
            
              

        }*/
       /* private void AddRecord_Click(object sender, RoutedEventArgs e)
        {
            clsDic dicitem = new clsDic();
            dicitem.Title = title.Text;
            dicitem.ISBN = Convert.ToInt32(isbn.Text);
            dicitem.Edition = Convert.ToInt32(edition.Text);
            dicitem.Part = Convert.ToInt32(part.Text);
            dicitem.Copies = Convert.ToInt32(numberofcopies.Text);
            dicitem.Words = Convert.ToInt32(numberofwords.Text);
            dicitem.Notes = notes.Text;
            dicitem.Category = Convert.ToInt32(categorycombo.SelectedValue);
            dicitem.Publisher = Convert.ToInt32(publishercombo.SelectedValue);
            //call author list
            //call org list
            //call people list
            //call to lang list
            //call fr lang list
                  



        }*/

      /*  public class DataAccess
        {
            SqlConnection Conn;
            SqlCommand Cmd;

            public DataAccess()
            {
                Conn = new SqlConnection("Data Source=D:\\TSLU\\MyDatabase4.sdf");
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
                        Category = Convert.ToInt32(Reader["Category"]),
                        Publisher = Convert.ToInt32(Reader["Publisher"])

                    });
                }

                Conn.Close();
                return Dic;
            }
       
            public void InsertDic(clsDic objEmp)
            {
                Conn = new SqlConnection("Data Source=D:\\TSLU\\MyDatabase4.sdf");
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
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
        }*/

        private void comboBox1_SelectionChanged(ComboBox comboBox)
        {
            //SqlCeConnection sqlCon = new SqlCeConnection("Data Source=D:\\TSLU\\MyDatabase4.sdf");
            //SqlCeDataAdapter da = new SqlCeDataAdapter("Select * FROM Author", sqlCon);
            //DataSet ds = new DataSet();
            //da.Fill(ds, "Author");
            //authorcombo.ItemsSource = ds.Tables["Author"].DefaultView;
            //authorcombo.DisplayMemberPath = ds.Tables["Author"].Columns["Name"].ToString();
            //authorcombo.SelectedValuePath = ds.Tables["Author"].Columns["ID"].ToString();

        }

        private void comboBox2_SelectionChanged(ComboBox comboBox)
        {
            SqlCeConnection sqlCon = new SqlCeConnection("Data Source=D:\\TSLU\\MyDatabase4.sdf");
            SqlCeDataAdapter da = new SqlCeDataAdapter("Select * FROM Category", sqlCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "Category");
            categorycombo.ItemsSource = ds.Tables["Category"].DefaultView;
            categorycombo.DisplayMemberPath = ds.Tables["Category"].Columns["Description"].ToString();
            categorycombo.SelectedValuePath = ds.Tables["Category"].Columns["ID"].ToString();
            
        }

        private void comboBox3_SelectionChanged(ComboBox comboBox)
        {
            SqlCeConnection sqlCon = new SqlCeConnection("Data Source=D:\\TSLU\\MyDatabase4.sdf");
            SqlCeDataAdapter da = new SqlCeDataAdapter("Select * FROM Publisher", sqlCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "Publisher");
            publishercombo.ItemsSource = ds.Tables["Publisher"].DefaultView;
            publishercombo.DisplayMemberPath = ds.Tables["Publisher"].Columns["Name"].ToString();
            publishercombo.SelectedValuePath = ds.Tables["Publisher"].Columns["ID"].ToString();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            People addp = new People();
            addp.Show();
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click_2(object sender, RoutedEventArgs e)
        {
            languagescript ls = new languagescript();
            ls.Show();
            

        }

        private void AddNewRecord_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            scriptlanguage sl = new scriptlanguage();
            sl.Show();
        }

        private void publishercombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            //Console.WriteLine(datePicker1.Text);
            Close();
        }

        private void isbn_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        
    }
}
