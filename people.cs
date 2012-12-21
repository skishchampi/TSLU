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
    public partial class People : Form
    {
        public List<people> peoplelist = new List<people>();

        public People()
        {
            InitializeComponent();
            //List<people> peoplelist = new List<people>();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        
        private void People_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDatabase4DataSet.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.myDatabase4DataSet.People);
            

        }
        public static orgp[] array_p = new orgp[5];
        
        public static int i_p = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            for (int hujintao = 0; hujintao < 5;hujintao++ )
            {
                array_p[hujintao] = new orgp();
            }
            /*people p = new people();
            p.Name = comboBox2.Text;
            p.MA = comboBox1.Text;
            peoplelist.Add(p);
             */
            array_p[i_p].id = Convert.ToInt32(comboBox2.SelectedValue);

            if ((string)comboBox1.SelectedValue == "Mention")
                array_p[i_p].ma = 1;
            else
                array_p[i_p].ma = 2;

            i_p = i_p + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*people p = new people();
            people q = new people();
            p.Name = comboBox2.Text;
            p.MA = comboBox1.Text;
            peoplelist.Add(p);
            int i=0;
            while(i<peoplelist.Count)
            {
                q.Name = peoplelist[i].Name;
                q.MA = peoplelist[i].MA;
                i++;
            }
              */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form add = new addp();
            add.Show();
        }


    }
}
