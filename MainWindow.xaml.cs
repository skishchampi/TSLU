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
            //Window1 w = new Window1();
            //w.Show();
             
            
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
              /*  switch (comboBox1.Text)
                {
                    case "":
                    case "Title":
                        sql = "SELECT * FROM Dictionaries where Title = + textBox1.Text + ";
                        break;
                    case "Author":
                         sql = "Select * From Dictionaries where Title = ";
                         break;
                    default:
                    break;
                }
                */
                SqlCeDataAdapter dataadapter = new SqlCeDataAdapter(sql, sqlCon);
                DataTable ds = new DataTable("Category");
                
                
                sqlCon.Open();
                //dataadapter.Fill(ds, "Author");
                sqlCon.Close();
                dataadapter.Fill(ds);
                dataGrid1.ItemsSource = ds.DefaultView;
            
        }
        
        private void dataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

    }
}
