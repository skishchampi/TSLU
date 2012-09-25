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
            
        }
        public class clsEmployee
        {
            public int EmpNo { get; set; }
            public string EmpName { get; set; }
            public int Salary { get; set; }
            public int DeptNo { get; set; }
        }

        public class DataAccess
        {
            SqlConnection Conn;
            SqlCommand Cmd;

            public DataAccess()
            {
                Conn = new SqlConnection("Data Source=C:\\Users\\Skish Champi\\Documents\\Visual Studio 2010\\Projects\\TSLU\\Database3.sdf;Initial Catalog=Company;Integrated Security=SSPI");
            }

            public ObservableCollection<clsEmployee> GetAllEmployee()
            {
                ObservableCollection<clsEmployee> EmpCol = new ObservableCollection<clsEmployee>();
                Conn.Open();
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandText = "Select * from Employee";
                SqlDataReader Reader = Cmd.ExecuteReader();

                while (Reader.Read())
                {
                    EmpCol.Add(new clsEmployee()
                    {
                        EmpNo = Convert.ToInt32(Reader["EmpNo"]),
                        EmpName = Reader["EmpName"].ToString(),
                        Salary = Convert.ToInt32(Reader["Salary"]),
                        DeptNo = Convert.ToInt32(Reader["DeptNo"])
                    });
                }

                Conn.Close();
                return EmpCol;
            }

            public void InsertEmployee(clsEmployee objEmp)
            {
                Conn.Open();
                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandText = "Insert into Employee Values(@EmpNo,@EmpName,@Salary,@DeptNo)";
                Cmd.Parameters.AddWithValue("@EmpNo", objEmp.EmpNo);
                Cmd.Parameters.AddWithValue("@EmpName", objEmp.EmpName);
                Cmd.Parameters.AddWithValue("@Salary", objEmp.Salary);
                Cmd.Parameters.AddWithValue("@DeptNo", objEmp.DeptNo);
                Cmd.ExecuteNonQuery();
                Conn.Close();
            }
        }
    }
}