using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlServerCe;



namespace WpfApplication3
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        private DataGridView dataGridView1 = new DataGridView();
        private BindingSource bindingSource1 = new BindingSource();
        private SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter();
        private Button reloadButton = new Button();
        private Button submitButton = new Button();

        

        // Initialize the form. 
        public Form2()
        {
            dataGridView1.Dock = DockStyle.Fill;

            reloadButton.Text = "reload";
            submitButton.Text = "submit";
            reloadButton.Click += new System.EventHandler(reloadButton_Click);
            submitButton.Click += new System.EventHandler(submitButton_Click);

            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Dock = DockStyle.Top;
            panel.AutoSize = true;
            panel.Controls.AddRange(new Control[] { reloadButton, submitButton });

            this.Controls.AddRange(new Control[] { dataGridView1, panel });
            this.Load += new System.EventHandler(Form1_Load);
            this.Text = "DataGridView databinding and updating demo";
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            // Bind the DataGridView to the BindingSource 
            // and load the data from the database.
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from Dictionaries");
        }

        private void reloadButton_Click(object sender, System.EventArgs e)
        {
            // Reload the data from the database.
            GetData(dataAdapter.SelectCommand.CommandText);
        }

        private void submitButton_Click(object sender, System.EventArgs e)
        {
            // Update the database with the user's changes.
            dataAdapter.Update((DataTable)bindingSource1.DataSource);
        }

        private void GetData(string selectCommand)
        {
            try
            {
                // Specify a connection string. Replace the given value with a  
                // valid connection string for a Northwind SQL Server sample 
                // database accessible to your system.
                String connectionString = "Data Source=|DataDirectory|\\MyDatabase4.sdf";

                // Create a new data adapter based on the specified query.
                dataAdapter = new SqlCeDataAdapter(selectCommand, connectionString);

                // Create a command builder to generate SQL update, insert, and 
                // delete commands based on selectCommand. These are used to 
                // update the database.
                SqlCeCommandBuilder commandBuilder = new SqlCeCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                dataGridView1.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlCeException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }

    }
}
