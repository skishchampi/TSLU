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
            clsDic dicitem = new clsDic();
            dicitem.title = title.Text;
            //Console.WriteLine(dicitem.title);
            dicitem.ISBN = Convert.ToUInt64(isbn.Text);
            dicitem.Edition = Convert.ToDateTime(datePicker1.Text);
            dicitem.Part = Convert.ToInt32(part.Text);
            dicitem.Copies = Convert.ToInt32(numberofcopies.Text);
            dicitem.Words = Convert.ToInt32(numberofwords.Text);
            dicitem.Notes = notes.Text;
            dicitem.Category = Convert.ToInt32(categorycombo.SelectedValue);
            dicitem.Publisher = Convert.ToInt32(publishercombo.SelectedValue);
            /*call author list
            //call org list
            //call people list
            //call to lang list
            */
            
            //Console.WriteLine(ana.array[0]);
            //Console.WriteLine(organizations.array[0].id);
            //Console.WriteLine(People.array_p[0].id);
            //Console.WriteLine(scriptlanguage.array_l[0].id);

            SqlCeConnection Conn = new SqlCeConnection("Data Source=D:\\TSLU\\MyDatabase4.sdf");
            Conn.Open();
            SqlCeCommand Cmd = new SqlCeCommand();
            Cmd.Connection = Conn;
            
            //Insert Information that directly goes into the Dictionaries table without any other dependencies
            Cmd.CommandText = "Insert into Dictionaries (Title, ISBN, Edition, Volume, Part, Copies, Words, Notes, Category, Publisher)Values(@Title, @ISBN, @Edition, @Volume, @Part, @Copies, @Words, @Notes, @Category, @Publisher)";
            Cmd.Parameters.AddWithValue("@Title",dicitem.title);
            Cmd.Parameters.AddWithValue("@ISBN",dicitem.ISBN);
            Cmd.Parameters.AddWithValue("@Edition",dicitem.Edition);
            Cmd.Parameters.AddWithValue("@Volume",dicitem.Volume);
            Cmd.Parameters.AddWithValue("@Part",dicitem.Part);
            Cmd.Parameters.AddWithValue("@Copies",dicitem.Copies);
            Cmd.Parameters.AddWithValue("@Words",dicitem.Words);
            Cmd.Parameters.AddWithValue("@Notes",dicitem.Notes);
            Cmd.Parameters.AddWithValue("@Category",Convert.ToInt32(categorycombo.SelectedValue));
            Cmd.Parameters.AddWithValue("@Publisher",Convert.ToInt32(publishercombo.SelectedValue));
            Cmd.ExecuteNonQuery();
            
            int counter = 0;

            //Insert Information about Authors and Dictionary
            Cmd.CommandText = "Select max(ID) from Dictionaries";
            int current_dic_id = Convert.ToInt32(Cmd.ExecuteScalar());
            Cmd.CommandText = "Insert into AuthDic (AID, DID)Values(@AID, @DID)";
            Cmd.Parameters.AddWithValue("@AID", ana.array[0]);
            Cmd.Parameters.AddWithValue("@DID", current_dic_id);
            Cmd.ExecuteNonQuery();

            Conn.Close();
            Conn.Open();
            Cmd.Connection = Conn;
            
            
            //Insert information about language and dictionary
            Cmd.CommandText = "Insert into LangDic (DID, LID, TYPE)Values(@DID, @LID, @TYPE)";
            Cmd.Parameters["@DID"].Value = current_dic_id;   //AddWithValue("@DID",current_dic_id)
            Cmd.Parameters.AddWithValue("@LID",languagescript.f_lang);
            Cmd.Parameters.AddWithValue("@TYPE",1);
            Cmd.ExecuteNonQuery();
            Conn.Close();
            Conn.Open();
            Cmd.Connection = Conn;
            
            //find number of languages the meaning of the dictionary word is in
            //Loop will determine the number of non-zero values in the given array
            while (counter < 5)
            {
                if (scriptlanguage.array_l[counter].id == 0)
                    break;
                else
                {
                    counter++;                   
                }
            }
            
            for(int iota=0; iota<counter;iota++)
            {
                Cmd.Parameters["@DID"].Value = current_dic_id; //Cmd.Parameters.AddWithValue("@DID", current_dic_id);
                Cmd.Parameters["@LID"].Value = scriptlanguage.array_l[iota].id;//AddWithValue("@LID", scriptlanguage.array_l[counter].id)
                Cmd.Parameters["@TYPE"].Value = 2;
                Cmd.ExecuteNonQuery();
            }
            Conn.Close();
            Conn.Open();
            Cmd.Connection = Conn;

            
            //Insert information about Script and dictionary
            Cmd.CommandText = "Insert into ScriptDic (DID, SID, TYPE)Values(@DID, @SID, @TYPE)";
            Cmd.Parameters["@DID"].Value = current_dic_id; //Cmd.Parameters.AddWithValue("@DID", current_dic_id);
            Cmd.Parameters.AddWithValue("@SID", languagescript.f_script);
            Cmd.Parameters["@TYPE"].Value = 1;
            Cmd.ExecuteNonQuery();

            for (int iota = 0; iota < counter; iota++)
            {
                Cmd.Parameters["@DID"].Value = current_dic_id; //Cmd.Parameters.AddWithValue("@DID", current_dic_id);
                Cmd.Parameters["@SID"].Value = scriptlanguage.array_l[iota].ma;
                Cmd.Parameters["@TYPE"].Value = 2;
                Cmd.ExecuteNonQuery();
            }
            Conn.Close();
            Conn.Open();
            Cmd.Connection = Conn;
            
            
            //People associated with the Dictionary
            Cmd.CommandText = "Insert into MAPeople (DID, PID, MA)Values(@DID, @PID, @MA)";
            //Loop will determine the number of non-zero values in the given array
            counter = 0;
            while (counter < 5)
            {
                if (People.array_p[counter].id == 0)
                    break;
                else
                {
                    counter++;
                }
            }
            Cmd.Parameters.AddWithValue("@PID", 0);
            //Cmd.Parameters.Add("@TYPE", SqlDbType.Int);
            for (int iota = 0; iota < counter; iota++)
            {
                Cmd.Parameters["@DID"].Value = current_dic_id; //Cmd.Parameters.AddWithValue("@DID", current_dic_id);
                Cmd.Parameters["@PID"].Value = People.array_p[iota].id;
                //Console.WriteLine(People.array_p[iota].ma);
                Cmd.Parameters["@TYPE"].Value = "Mention";//People.array_p[iota].ma
                Cmd.ExecuteNonQuery();
            }
            Conn.Close();
            Conn.Open();
            Cmd.Connection = Conn;
            
            
            //Organizations associated with the Dictionary
            Cmd.CommandText = "Insert into MAOrganizations (DID, PID, MA)Values(@DID, @OID, @MA)";
            //Loop will determine the number of non-zero values in the given array
            counter = 0;
            while (counter < 5)
            {
                if (organizations.array[counter].id == 0)
                    break;
                else
                {
                    counter++;
                }
            }
            Cmd.Parameters.AddWithValue("@OID",0);
            //Cmd.Parameters.AddWithValue("@TYPE", 0);
            for (int iota = 0; iota < counter; iota++)
            {
                Cmd.Parameters["@DID"].Value = current_dic_id; //Cmd.Parameters.AddWithValue("@DID", current_dic_id);
                Cmd.Parameters["@OID"].Value = organizations.array[iota].id;
                Cmd.Parameters["@TYPE"].Value = "Acknowledgement"; //organizations.array[iota].ma
                Cmd.ExecuteNonQuery();
            }
            Conn.Close();



            

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
            categorycombo.SelectedValue = ds.Tables["Category"].Columns["ID"];
            
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
            publishercombo.SelectedValue = ds.Tables["Publisher"].Columns["ID"];
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
