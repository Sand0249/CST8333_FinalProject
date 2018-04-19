/** 
 * Author: Simranjit Singh Sandhu
 * Date  : April 15, 2018
 * Class : MainScreen.cs
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    /// <summary>
    /// this class shows learning experience - Polymorphism and it is the main screen that opens other classes on button clicks, displays total no 
    /// of records and displays all records from csv into console using polymorphism
    /// </summary>
    public partial class MainScreen : Form                  // MainScreen class extending Form class
    {
        /// <summary>
        /// instantiate string variables as records and restart to display records in textfield and restart program
        /// </summary>
        public string records, restart;                  // initializing string variables
        
        /// <summary>
        /// no arg constructor which calls method from designer class which is responsible for GUI elements
        /// </summary>
        public MainScreen()                                // no arg constructor
        {
            InitializeComponent();                       // calling designer class responsible for GUI elements
        }

        /// <summary>
        /// this button opens the Display sort class when clicked
        /// </summary>
        /// <param name="sender"> object refernce which raises the event</param>
        /// <param name="e"> event listener which contains the event data</param>
        private void button1_Click(object sender, EventArgs e)  // on click event for button Display and Sort
        {
            DisplaySort open = new DisplaySort();             // Making object for DisplaySort class
            open.Show();                                     // opening class
        }

        /// <summary>
        /// this is action listener for CRUD class which opens InsertDelete class when clicked
        /// </summary>
        /// <param name="sender"> object refernce which raises the event</param>
        /// <param name="e"> event listener which contains the event data</param>
        private void btnInsertDel_Click(object sender, EventArgs e)  // on click event for CRUD button
        {
            InsertDelete open = new InsertDelete();           // Making object for InsertDelete class
            open.Show();                                      // opening new class        
        }

        /// <summary>
        /// this method is action listener for calculator button. It opens MarksCalculator class when clicked
        /// </summary>
        /// <param name="sender"> object refernce which raises the event</param>
        /// <param name="e"> event listener which contains the event data</param>
        private void btnCalculator_Click(object sender, EventArgs e)  // on click event for Calculator button
        {
            MarksCalculator open = new MarksCalculator();
            open.Show();
        }

        /// <summary>
        /// this methods open the polymorphic class - Derived when button is clicked. this method displays total number of records from database using 
        /// polymorphism strategy in such a way this it uses the overidden method from Derived class
        /// </summary>
        /// <param name="sender"> object refernce which raises the event</param>
        /// <param name="e"> event listener which contains the event data</param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            InsertDelete open = new Derived();
            txtRecords.Text = open.DbAction(records);
        }

        /// <summary>
        /// this method is action listener for button which calls readfile mehtod which in further dipalys all records of csv file into console
        /// </summary>
        /// <param name="sender"> object refernce which raises the event</param>
        /// <param name="e"> event listener which contains the event data</param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            readFile();
        }

        /// <summary>
        /// This method is used to display the specified dataset records into console Using IO method
        /// </summary>
        public void readFile()
        {
            try
            {           
                String read = File.ReadAllText(@"D:\Dataset.csv"); // reading the .csv file
                Console.WriteLine(read);            // printing it on Console
                Console.ReadLine();
                Console.WriteLine("Program by Simranjit Singh Sandhu");
                DialogResult box = MessageBox.Show("Do you want to run again ?", "Program by: Simranjit Singh Sandhu", MessageBoxButtons.YesNo);

                for (; ; )
                {          
                 if (box == DialogResult.Yes)
                 {
                    readFile();
                 }
                 else if (box == DialogResult.No)
                 {
                        break;
                 }

                }               
            } // end of try method
            catch (Exception ex)    // catch method
            {
                Console.WriteLine("The file couldn't find");    // message to be printed on exception
                Console.WriteLine(ex.Message);
            }
        }

    }             // end of class
}                   // end of namespace
