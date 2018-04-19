/** 
 * Author: Simranjit Singh Sandhu
 * Date  : April 15, 2018
 * Class : MarkCalculator.cs
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    /// <summary>
    /// Class used to calculate average marks  by taking values from user
    /// </summary>
    public partial class MarksCalculator : Form
    {
       /// <summary>
       /// no arg constructor used to call designer class which is responsible for GUI elements
       /// </summary>
        public MarksCalculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// this is action listener for view total records button. it is used to call method - average which in futher calculates average marks 
        /// </summary>
        /// <param name="sender"> object refernce which raises the event</param>
        /// <param name="e"> event listener which contains the event data</param>
        private void btnTotalMarks_Click(object sender, EventArgs e)
        {
            txtTotal.Text = Average(int.Parse(txtEnglish.Text), int.Parse(txtMath.Text)).ToString();
        }

        /// <summary>
        /// This method is used to calculate the average marks of two courses
        /// </summary>
        /// <param name="a">first int variable for english marks tectfield</param>
        /// <param name="b"> second int variable for mathematics marks textfield</param>
        /// <returns>returns result of average marks</returns>
        public int Average(int a, int b)
        {          
             int   total = (a + b) / 2;            // int variable for average marks      
             return total;                      // returns result of method in the form of average marks
        }


    }   // end of class
}       // end of namespace
