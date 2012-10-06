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
        List<people> peoplelist = new List<people>();

        public People()
        {
            InitializeComponent();
            //List<people> peoplelist = new List<people>();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public class people
        {
            public string Name { get; set; }
            public string MA { get; set; }
        }
        
        private void People_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            people p = new people();
            p.Name = textBox1.Text;
            p.MA = comboBox1.Text;
            peoplelist.Add(p);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            people p = new people();
            people q = new people();
            p.Name = textBox1.Text;
            p.MA = comboBox1.Text;
            peoplelist.Add(p);
            int i=0;
            while(i<peoplelist.Count)
            {
                q.Name = peoplelist[i].Name;
                q.MA = peoplelist[i].MA;
                i++;
            }
        }


    }
}
