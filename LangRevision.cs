using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LangRevision
{
    public partial class LangRevision : Form
    {
        private AskNameForm askNameForm;
        private static int MAX_LINKS = 10;

        public LangRevision()
        {
            InitializeComponent();
            
            /*
             * Create a link for the MAX_LINKS last opened files 
             */

            String[] filePaths = Directory.GetFiles(Utils.LangFilesDirectory);
            // If MAX_LINKS or less are in the directory, links all of them
            if(filePaths.Length <= MAX_LINKS) {
                int i = 0;
                foreach(String filePath in filePaths) {
                    LinkLabel l = new LinkLabel();
                    l.Text = filePath.Remove(0, Utils.LangFilesDirectory.Length + 1);
                    l.MouseClick += delegate(object _sender, MouseEventArgs _e) {
                        OpenLangFile(filePath);
                    };
                    l.Location = new Point(this.recentlyOpenedFileslabel.Location.X + 10, this.recentlyOpenedFileslabel.Location.Y + this.recentlyOpenedFileslabel.Height + 14 * i++);
                    l.AutoSize = true;
                    this.Controls.Add(l);
                }
            }
            // Else links the most recents
            else {
                // TODO : recent opened files file
            }

            new LinkLabel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void menuQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            askNameForm = new AskNameForm();
            askNameForm.Show();
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {

        }

        private void menuSave_Click(object sender, EventArgs e)
        {

        }

        private void OpenLangFile(String _fileName) {
            // TODO
        }
    }
}
