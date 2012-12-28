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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlServerCe;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            /*Window1 w = new Window1();
            //w.Show();
            MyDatabase4DataSet ds = new MyDatabase4DataSet();
            WpfApplication3.MyDatabase4DataSetTableAdapters.DictionariesTableAdapter adapter = new WpfApplication3.MyDatabase4DataSetTableAdapters.DictionariesTableAdapter();
            adapter.Fill(ds.Dictionaries);

            this.DataContext = ds.Dictionaries;
            */
            DictionariesDataProvider db = new DictionariesDataProvider();
            this.dataGrid1.ItemsSource = db.GetDictionaries();
            
        }

        
        

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
           Window1 w = new Window1();
           w.Show();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
                  
                SqlCeConnection sqlCon = new SqlCeConnection("Data Source=D:\\TSLU\\MyDatabase4.sdf");
                string sql = "SELECT * FROM Dictionaries ";
                string query = textBox1.Text;
                
                switch (comboBox1.Text)
                {
                    case "":
                    case "Title":
                        sql = "SELECT * FROM Dictionaries where Title LIKE '%"+query+"%'";
                        break;
                    case "Author":
                         sql = "Select * From Dictionaries where Title = ";
                         break;
                    case "Category":
                         sql = "Select * From Dictionaries where Category = " + Convert.ToInt32(query) +"";
                         break;
                    case "Publisher":
                         sql = "Select * From Dictionaries where Publisher = " + Convert.ToInt32(query) + "";
                         break;
                    default:
                    break;
                }
                
                SqlCeDataAdapter dataadapter = new SqlCeDataAdapter(sql, sqlCon);
                DataTable ds = new DataTable("Dictionaries");
                
                
                sqlCon.Open();
                //dataadapter.Fill(ds, "Author");
                sqlCon.Close();
                dataadapter.Fill(ds);
                dataGrid1.ItemsSource = ds.DefaultView;
            
            
        }
        
        private void dataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void UpdateForm_Click(object sender, RoutedEventArgs e)
        {
            Form2 update = new Form2();
            update.Show();
        }
        

    }

    public class DictionariesDataProvider
    {
        private WpfApplication3.MyDatabase4DataSetTableAdapters.DictionariesTableAdapter adapter;

        private WpfApplication3.MyDatabase4DataSet dataset;

        public DictionariesDataProvider()
        {
            dataset = new MyDatabase4DataSet();
            adapter = new WpfApplication3.MyDatabase4DataSetTableAdapters.DictionariesTableAdapter();
            adapter.Fill(dataset.Dictionaries);

            dataset.Dictionaries.DictionariesRowChanged += new MyDatabase4DataSet.DictionariesRowChangeEventHandler(DictionariesRowModified);
            dataset.Dictionaries.DictionariesRowDeleted += new MyDatabase4DataSet.DictionariesRowChangeEventHandler(DictionariesRowModified);
        }

        public DataView GetDictionaries()
        {
            return dataset.Dictionaries.DefaultView;
        }

        void DictionariesRowModified(object sender, MyDatabase4DataSet.DictionariesRowChangeEvent e)
        {
           // SqlCeConnection connection = new SqlCeConnection("Data Source=|Data Directory|\\MyDatabase4.sdf");
           // SqlCeCommand myupdatecommand = new SqlCeCommand("UPDATE Dictionaries SET Title=@p1, ", connection);
           // adapter.Adapter.UpdateCommand = myupdatecommand;
            adapter.Update(dataset.Dictionaries);
            
            
        }
        
    }

}
