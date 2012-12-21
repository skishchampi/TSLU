using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WpfApplication3
{
    


    public partial class organizations : Form
    {
        

        public organizations()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void organizations_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDatabase4DataSet.Organizations' table. You can move, or remove it, as needed.
            this.organizationsTableAdapter.Fill(this.myDatabase4DataSet.Organizations);
            // TODO: This line of code loads data into the 'myDatabase4DataSet.MAOrganizations' table. You can move, or remove it, as needed.
            this.mAOrganizationsTableAdapter.Fill(this.myDatabase4DataSet.MAOrganizations);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form add = new addorg();
            add.Show();
        }

        private void addexitAO_Click(object sender, EventArgs e)
        {

        }


        public static orgp[] array = new orgp[5];
        public static int i = 0;

        private void addmoreAO_Click(object sender, EventArgs e)
        {
            for (int hujintao = 0; hujintao < 5; hujintao++)
            {
                array[hujintao] = new orgp();
            }
            
            array[i].id = (int)comboBox2.SelectedValue;
            if ((string)comboBox1.SelectedValue == "Mention")
                array[i].ma = 1;
            else
                array[i].ma = 2;
            i = i + 1;

                
            
        }
    }
    
}
