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

namespace VisualMan
{
    public partial class Window : Form
    {
        private String sourcepath;

        public Window()
        {
            InitializeComponent();
        }

        private void Windows_Load(object sender, EventArgs e)
        {
           
        }

        private void enterSource_TextChanged(object sender, EventArgs e)
        {

        }

        // Bring up a dialog to chose a folder path
        private void browseButton_Click(object sender, EventArgs e)
        {
            // Show the FolderBrowserDialog.
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                sourcepath = fbd.SelectedPath;
                enterSource.Text = sourcepath;
            }
        }
    }
}
