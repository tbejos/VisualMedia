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
        private List<String> files;
        private List<String> changes;
        private List<String> types = new List<String> {".mkv", ".mp4", ".srt"};
        private List<String> blacklist = new List<String> {"x264", "H264", "x265", "H265", "WEBRip",
                                                           "BluRay", "BrRip", "BRip", "YIFY", "YTS AG",
                                                           "YTS AM", "GAZ", "INTERNAL", "REPACK", "RABG"};
        private Boolean dryrun = false;

        public Window()
        {
            InitializeComponent();
        }

        private void Windows_Load(object sender, EventArgs e)
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

        // Commit Path to Source Path on Enter
        private void enterSource_Leave(object sender, EventArgs e)
        {
            sourcepath = enterSource.Text;
        }

        // Recursive Search
        private void DirSearch(String source)
        {
            foreach (String file in Directory.GetFiles(source))
            {
                if (types.IndexOf(Path.GetExtension(file)) >= 0)
                    files.Add(file);
            }

            foreach (String dir in Directory.GetDirectories(source))
            {
                this.DirSearch(dir);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            files = new List<String>();
            changes = new List<String>();

            DirSearch(sourcepath);
            formatNames(files);
            outputBox.Text = "";
            outputBox.Text = String.Join(Environment.NewLine, changes);
            outputBox.Text += "\nDone.";
        }

        private void formatNames(List<String> names)
        {
            foreach (String name in names)
            {
                String file = name.Substring(name.LastIndexOf(@"\") + 1);
                String newName = file;
                String extension = Path.GetExtension(name);
                newName = newName.Replace("_", " ");
                newName = newName.Replace("[", "");
                newName = newName.Replace("]", "");
                newName = newName.Replace(".", " ");
                // Remove the '.' from file extension
                foreach (String type in types)
                    newName = newName.Replace(type.Substring(1), "");
                foreach (String word in blacklist)
                    newName = newName.Replace(word, "");

                char[] Whitespace = {' ', '\t'};
                String[] split = newName.Split(Whitespace, StringSplitOptions.RemoveEmptyEntries);
                newName = String.Join(" ", split);

                newName = newName + extension;
                if (!newName.Equals(file))
                {
                    newName = name.Substring(0, name.LastIndexOf(@"\") + 1) + newName;
                    if (!dryrun)
                        Directory.Move(name, newName);
                    changes.Add(newName);
                }
            }
        }

        private void writeBox_MouseEnter(object sender, EventArgs e)
        {
            dryRunTip.SetToolTip(writeBox, "Checking this will output the changes but will not actually overwrite the files");
        }

        private void writeBox_CheckedChanged(object sender, EventArgs e)
        {
            dryrun = !dryrun;
        }
    }
}
