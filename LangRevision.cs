using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace LangRevision
{
    /// <summary>
    /// Main class of the application.
    /// </summary>
    public partial class LangRevision : Form
    {
        public enum ETranslationMod {
            LeftToRight,
            RightToLeft,
            Both
        };

        private AskNameForm         m_askNameForm;
        private ModSelectionForm    m_modSelectionForm;
        private String              m_langFilePath;
        private ETranslationMod     m_translationMod;

        private static int MAX_LINKS = 10;

        /*
         * Constructors
         */

        public LangRevision() {
            InitializeComponent();
            
            /*
             * Create a link for the MAX_LINKS last opened files
             * On click, sets the file path and Open a new form to select the translation mod
             */

            String[] filePaths = Directory.GetFiles(Utils.LangFilesDirectory);
            // If MAX_LINKS or less are in the directory, links all of them
            if(filePaths.Length <= MAX_LINKS) {
                int i = 0;
                foreach(String filePath in filePaths) {
                    LinkLabel l = new LinkLabel();
                    l.Text = filePath.Remove(0, Utils.LangFilesDirectory.Length + 1);
                    l.MouseClick += delegate(object _sender, MouseEventArgs _e) {
                        m_langFilePath = filePath;
                        OpenLangFileModSelection();
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

        /*
         * Properties
         */

        public ETranslationMod TranslationMod {
            get { return m_translationMod;  }
            set { m_translationMod = value; }
        }


        /*
         * Other methods
         */

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e) {

        }

        private void menuQuit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void menuNew_Click(object sender, EventArgs e) {
            m_askNameForm = new AskNameForm();
            m_askNameForm.Show();
        }

        private void menuOpen_Click(object sender, EventArgs e) {

        }

        private void menuSave_Click(object sender, EventArgs e) {

        }

        /// <summary>
        /// Create and Show a ModSelection form.
        /// This new form allows the user to select the Translation Mod he wants to use.
        /// Calls back ModSelectionFormClosedEventHandler when closing.
        /// </summary>
        private void OpenLangFileModSelection() {
            m_modSelectionForm = new ModSelectionForm(this);
            m_modSelectionForm.FormClosed += new FormClosedEventHandler(ModSelectionFormClosedEventHandler);
            m_modSelectionForm.Show();
        }

        private void ModSelectionFormClosedEventHandler(object sender, FormClosedEventArgs e) {
            if(m_langFilePath != null) {
                OpenLangFile(m_langFilePath);

            } else {
                throw new Exception("The LangFile Path should have been set before.");
            }
        }

        /// <summary>
        /// Open a LangFile to load its content.
        /// </summary>
        private void OpenLangFile(String _path) {
            // TODO
        }
        
    }
}
