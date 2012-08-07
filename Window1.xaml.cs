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
    }
}
