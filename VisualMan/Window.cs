using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualMan
{
    public partial class Window : Form
    {
        private String sourcepath;
        private List<String> files;
        private List<String> changes;
        private List<String> delete;
        private List<String> types = new List<String> {".mkv", ".mp4", ".srt"};
        private List<String> deleteType = new List<String> { ".vtt", ".torrent" };
        private List<String> blacklist = new List<String> {"x264", "H264", "x265", "H265", "WEBRip",
                                                           "BluRay", "BrRip", "BRip", "YIFY", "YTS AG",
                                                           "YTS AM", "GAZ", "INTERNAL", "REPACK", "RABG",
                                                           "HDTV"};
        private Regex year = new Regex("[\\s][0-9]{4}[\\s]");
        private Regex resolution = new Regex("[\\s[0-9]{3,4}p[\\s]");
        private Boolean dryrun = false;
        private Boolean deleteExtras = false;

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
                else if (deleteType.IndexOf(Path.GetExtension(file)) >= 0)
                    delete.Add(file);
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
            delete = new List<String>();

            if (!Directory.Exists(sourcepath))
            {
                outputBox.Text = "Please enter a valid directory";
                return;
            }

            DirSearch(sourcepath);
            if (dryrun)
                changes.Add("**DRY RUN**");
            deleteFiles();
            formatNames(files);
            outputBox.Text = "";
            outputBox.Text = String.Join(Environment.NewLine, changes);
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

                Match match = year.Match(newName);
                if (match.Success)
                {
                    newName = newName.Replace(match.Value, "(" + match.Value.Replace(" ", "") + ")");
                }
                match = resolution.Match(newName);
                if (match.Success)
                {
                    newName = newName.Replace(match.Value, "");
                    newName += match.Value;
                }

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
            changes.Add("Done.");
        }

        private void deleteFiles()
        {
            if (deleteExtras)
            {
                foreach (String extras in delete)
                {
                    if (!dryrun)
                        File.Delete(extras);
                    changes.Add(extras);
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

        private void deleteBox_CheckStateChanged(object sender, EventArgs e)
        {
            deleteExtras = !deleteExtras;
        }

        private void deleteBox_MouseEnter(object sender, EventArgs e)
        {
            deleteTip.SetToolTip(deleteBox, "This will delete .vtt and .torrent files");
        }
    }
}
