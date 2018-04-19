/** 
 * Author: Simranjit Singh Sandhu
 * Date  : April 15, 2018
 * Class : InsertDelete.cs
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
    /// This class shows learing topic - Database connectivity. it performs the CRUD operation on database.
    /// </summary>
    public partial class InsertDelete : Form
    {
        /// <summary>
        /// Instantiates variables and objects for use in class 
        /// </summary>
        public string server = "localhost";           // creating string for database server as server
        public string database = "csvdatabase";       // instantiating string for database name as database
        public string uid = "cst8333";                // instantiating string for database username as uid 
        public string password = "password";          // instantiating string for database password as password
        public string connectionString;               // connection string for database
        public MySqlConnection connection;            // instantiating connection for MySqlConnection class
        public MySqlCommand cmd;                      // instantiating cmd using MySqlCommand class
        public string queryViewRecords, query, queryDelete; // instantiating strings for different queries
        public object obj;                            // creating object for object class
        public string result;                         // instantiating string variable as result


        /// <summary>
        /// No arg constructor responsible for calling GUI elements class and setting up connection string for database connectivity
        /// </summary>
        public InsertDelete()                             // no arg constructor
        {
            InitializeComponent();                     // designer class responsible for GUI elements
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database    // connection string for
                     + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";     // MySql                     
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// this is action listener for delete button. It calls DbAction method on click and delete the record from database
        /// </summary>
        /// <param name="sender"> object refernce which raises the event</param>
        /// <param name="e"> event listener which contains the event data</param>
        private void btnDelete_Click(object sender, EventArgs e)        
        {
            queryDelete = "delete from FinalProject where RowId = " + txtIdDelete.Text + ";";  // query for deleting records
            DbAction(queryDelete);
            MessageBox.Show("Data deleted from Database");     // dialog box for confirmation
        }

        /// <summary>
        /// this method is action listener for Load records button. It displays all the records from database in datagrid view when clicked
        /// </summary>
        /// <param name="sender"> object refernce which raises the event</param>
        /// <param name="e"> event listener which contains the event data</param>
        public void btnLoad_Click(object sender, EventArgs e)    
        {
            connection = new MySqlConnection(connectionString);  // connection with database
            queryViewRecords = "select * from FinalProject";            // query for displaying all records from database
            connection.Open();                                     // connection is open
            cmd = new MySqlCommand(queryViewRecords, connection);  // command executing query for viewing records
            try                                                    // try block
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(); // MySqlAdapter for filling dataset and updating database
                adapter.SelectCommand = cmd;                     // command executing query 
                DataTable dataTable = new DataTable();           // datatable for viewing records from database
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
        /// this is save button used to save data into database. When it is clicked, DbAction method is called which saves all the data into datbase 
        /// entered by user into textfields 
        /// </summary>
        /// <param name="sender"> object refernce which raises the event</param>
        /// <param name="e"> event listener which contains the event data</param>
        private void btnSave_Click(object sender, EventArgs e)   // on click method for Save button
        {
            query = "INSERT INTO FinalProject VALUES ('" + txtRowId.Text + "','" + datetxt.Text + "','" + txtGeo.Text + "','"
                + txtCommod.Text + "','" + txtVector.Text + "','" + txtCoordinate.Text + "','" + txtValue.Text + "');";
            DbAction(query);
            MessageBox.Show("Data saved into Database");     // dialog box for confirmation
            

        }

        /// <summary>
        /// This method is used to save data into database
        /// </summary>
        /// <param name="query">string used to write sql query to perform specified operation on database</param>
        /// <returns> result of mysql command</returns>
        public virtual string DbAction(string query)
        {       
            try                                                    // try block
            {
                using (connection = new MySqlConnection(connectionString))  // creating connection to database
                {
                    connection.Open();                                   // connection is open 
                    cmd = new MySqlCommand(query, connection);          // executing query for inserting records into database
                 obj =   cmd.ExecuteNonQuery();                             // returns no. of rows affected
   
                    connection.Close();
                     result =  obj.ToString();                             // connection is close
                   
                }
            }
            catch (MySqlException ex)                             // catching exception
            {
                MessageBox.Show(ex.Message);                 // dialog box on exception 
            }
            return result;
        }

}            // end of class
}                // end of namespace


////           <<<<References>>>>
////    https://www.c-sharpcorner.com/article/display-data-in-a-datagridview-C-Sharp-6/ 
////