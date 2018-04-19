/** 
 * Author: Simranjit Singh Sandhu
 * Date  : April 15, 2018
 * Class : Derived.cs
 */

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    /// <summary>
    /// This class shows learing topic of Inheritance.it inherits from InsertDelete class and used to print the toatl number of records from database 
    /// </summary>
    public class Derived: InsertDelete
    {
        /// <summary>
        /// This method is overriding the method from insertDelete class which prints the total number of records from database
        /// </summary>
        /// <param name="query"> used to change query and get the output accordingly</param>
        /// <returns> result as a string of whole query</returns>
        public override string DbAction(string query)
        {
            string que = "Select count(*) from finalproject";
            try                                                    // try block
            {
                using (connection = new MySqlConnection(connectionString))  // creating connection to database
                {
                    connection.Open();                                   // connection is open 
                    cmd = new MySqlCommand(que, connection);          // executing query for inserting records into database
                    obj = cmd.ExecuteScalar();                             // returns no. of rows affected

                    connection.Close();
                    result = obj.ToString();                             // connection is close

                }
            }
            catch (MySqlException ex)                             // catching exception
            {
                MessageBox.Show(ex.Message);                 // dialog box on exception 
            }
            return result;
        }

    }   // end of class
}      // end of namespace
