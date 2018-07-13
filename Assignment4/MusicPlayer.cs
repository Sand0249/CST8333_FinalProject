/** 
 * Author: Simranjit Singh Sandhu
 * Date  : April 15, 2018
 * Class : MusicPlayer.cs
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
    /// Music player created using Windows media player component
    /// </summary>
    public partial class MusicPlayer : Form
    {
        /// <summary>
        /// instantiating string element
        /// </summary>
        string path;

        /// <summary>
        /// no arg constructor used to call designer class which is responsible for GUI elements
        /// </summary>
        public MusicPlayer()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  button listener method for selecting media file from computer when button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = open.FileName;          // assiging path of selected media to string
            }
            axWindowsMediaPlayer1.URL = path;  // for playing music in player
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            
        }

    } // end of class
}     // end of namespace
