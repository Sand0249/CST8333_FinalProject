/** 
 * Author: Simranjit Singh Sandhu
 * Date  : April 15, 2018
 * Class : Program.cs
 * Description: main class running the whole program
 */

 ///
 ///  this is auto generated class
 ///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    /// <summary>
    /// this is main class that decides which class to run first
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()                                             // main method
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());                    // running MainScreen class
           
        }
    }                 // end of class
}                  // end of namespace
