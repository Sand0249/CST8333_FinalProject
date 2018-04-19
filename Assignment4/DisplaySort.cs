﻿/** 
 * Author: Simranjit Singh Sandhu
 * Date  : April 15, 2018
 * Class : DisplaySort.cs
 */

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    /// <summary>
    /// This class shows learing topic - Data structures by fetching data into Dattable and then sort it.it sorts the data from database on two 
    /// fields - ref_date and coordinate in both ascedning and and descending order
    /// </summary>
    public partial class DisplaySort : Form           // class DisplaySort extending Form class
    {
        /// <summary>
        /// instantiating variables for using in class for different purposes
        /// </summary>
        public string server = "localhost";           // creating string for database server as server
        public string database = "csvdatabase";       // instantiating string for database name as database
        public string uid = "cst8333";                // instantiating string for database username as uid 
        public string password = "password";          // instantiating string for database password as password
        public string connectionString;               // connection string for database
        public MySqlConnection connection;            // instantiating connection for MySqlConnection class
        public string queryViewRecords;               // instantiating strings for different queries
        public MySqlCommand cmd;                      // instantiating Object for MySqlCommand class
        public DataTable dataTable;                   // instantiating object for Datatable class for fetching data from database in the form of table 
        public DataView view;                         // initializing Dataview class for displaying data in grid view
         
        /// <summary>
        /// this is no arg constructor calling autogenerated class for GUI elements and connection string for database connection
        /// </summary>   
        public DisplaySort()                                 
        {
            InitializeComponent();                           // calling designer class which  represents UI
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database    // connection string for
                     + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";     // MySql  
        }

        /// <summary>
        /// Show all records from database using MySqlConnection and query to be performed
        /// </summary>
        public void ViewRecords()                               // method MakeConnection
        {
             connection = new MySqlConnection(connectionString);  // connection with database
            queryViewRecords = "select * from FinalProject";            // query for displaying all records from database
            connection.Open();                                     // connection is open
            cmd = new MySqlCommand(queryViewRecords, connection);  // command executing query for viewing records
            try                                                    // try block
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(); // MySqlAdapter for filling dataset and updating database
                adapter.SelectCommand = cmd;                     // command executing query 
                dataTable = new DataTable();           // datatable for viewing records from database
                adapter.Fill(dataTable);
                BindingSource binding = new BindingSource();    // binding source which encapsulated data source
                binding.DataSource = dataTable;                 // encapsulating datatable with bindingsource
                dataGridView.DataSource = binding;              // filling dataGridView with records form database
                adapter.Update(dataTable);                      // show updated records from database
                connection.Close();                            // connection is close
            }
            catch (Exception ex)                             // catching exception
            {
                MessageBox.Show(ex.Message);                 // dialog box on exception 
            }

        }

        /// <summary>
        /// Sorts the data from database in datagridview according to selections of different strings 
        /// </summary>
        /// <param name="sort"> shows as string for performing different operartions on different selections of strings</param>
        public void SortRecords(String sort)
        {     
            // if string is dateAsc then follwing condition will run and data will be sorted in ascending order - ref_date
            if (sort == "dateAsc")
            {
                view = new DataView(dataTable);
                view.Sort = "ref_date Asc";
                dataGridView.DataSource = view;
            }

            // if string is dateDesc then follwing condition will run and data will be sorted in Descending order - ref_date
            else if (sort == "dateDesc")
            {
                view = new DataView(dataTable);
                view.Sort = "ref_date Desc";
                dataGridView.DataSource = view;
            }

            // if string is CordAsc then follwing condition will run and data will be sorted in ascending order - coordinate
            else if (sort == "CordAsc")
            {
                view = new DataView(dataTable);
                view.Sort = "coordinate Asc";
                dataGridView.DataSource = view;
            }

            // if string is CordDesc then follwing condition will run and data will be sorted in Descending order - coordinate
            else if (sort == "CordDesc")
            {
                view = new DataView(dataTable);
                view.Sort = "coordinate Desc";
                dataGridView.DataSource = view;
            }
        }

        /// <summary>
        /// nothing in this method
        /// </summary>
        /// <param name="sender"> object refernce which raises the event</param>
        /// <param name="e"> event listener which contains the event data</param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }

        /// <summary>
        /// button click listener for button Load records by calling method. It displays all records from database into datagrid view when button is clicked
        /// </summary>
        /// <param name="sender"> object refernce which raises the event</param>
        /// <param name="e"> event listener which contains the event data</param>
        private void btnLoadRecords_Click(object sender, EventArgs e)
        {
            ViewRecords();          // calling method
        }

        /// <summary>
        /// sorts the records in ascending order of ref_date when this button is clicked using method - SortRecords()
        /// </summary>
        /// <param name="sender"> object refernce which raises the event</param>
        /// <param name="e"> event listener which contains the event data</param>
        private void btnSort_Click(object sender, EventArgs e)   
        {
            SortRecords("dateAsc");
        }

        /// <summary>
        /// sort the records in decending order of ref_date and displays in datagridview using SortRecords method
        /// </summary>
        /// <param name="sender"> object refernce which raises the event</param>
        /// <param name="e"> event listener which contains the event data</param>
        private void btnDescDate_Click(object sender, EventArgs e)
        {
            SortRecords("dateDesc");
        }

        /// <summary>
        /// sort the records in ascending order of coordinate and displays in datagridview using SortRecords method
        /// </summary>
        /// <param name="sender"> object refernce which raises the event</param>
        /// <param name="e"> event listener which contains the event data</param>
        private void btnAscCoordinate_Click(object sender, EventArgs e)
        {
            SortRecords("CordAsc");
        }

        /// <summary>
        /// sort the records in decending order of coordinate and displays in datagridview using SortRecords method
        /// </summary>
        /// <param name="sender"> object refernce which raises the event</param>
        /// <param name="e"> event listener which contains the event data</param>
        private void btnDescCoordinate_Click(object sender, EventArgs e)
        {
            SortRecords("CordDesc");
        }
    }                       // end of class
}                          // end of namespace


////                          <<<< References >>>>
////       https://msdn.microsoft.com/en-us/library/aa720641(v=vs.71).aspx
////