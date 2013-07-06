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
            InitializeDirectory();
            InitializeLinks();

            //new LinkLabel();
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

        private void menuReload_Click(object sender, EventArgs e) {
            this.RemoveAllLinks();
            this.InitializeLinks();
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

        private void InitializeLinks() {
            // If possible link all files
            // Else links the most recents
            if(!TryAddAllLinks(Utils.LangFilesDirectory)) {
                // TODO : recent opened files file
            }
        }
        
        private void InitializeDirectory() {
            if(!Directory.Exists(Utils.LangFilesDirectory)) {
                Directory.CreateDirectory(Utils.LangFilesDirectory);
            }
        }

        /// <summary>
        /// Creates a link for the MAX_LINKS last opened files
        /// On click, sets the file path and Open a new form to select the translation mod
        /// </summary>
        /// <param name="_path">Path ofthe folder.</param>
        /// <returns>True if it was possible to add them all. False otherwise.</returns>
        private bool TryAddAllLinks(String _path) {
            String[] filePaths = Directory.GetFiles(Utils.LangFilesDirectory);
            if(filePaths.Length <= MAX_LINKS) {
                int i = 0;
                foreach(String filePath in filePaths) {
                    LinkLabel label = new LinkLabel();
                    label.Text = filePath.Remove(0, Utils.LangFilesDirectory.Length + 1);
                    label.MouseClick += delegate(object _sender, MouseEventArgs _e) {
                        m_langFilePath = filePath;
                        OpenLangFileModSelection();
                    };
                    label.Location = new Point(this.recentlyOpenedFileslabel.Location.X + 10, this.recentlyOpenedFileslabel.Location.Y + this.recentlyOpenedFileslabel.Height + 14 * i++);
                    label.AutoSize = true;
                    this.Controls.Add(label);
                }
                return true;
            }
            return false;
        }

        private void RemoveAllLinks() {
            foreach(Control c in this.Controls) {
                if(c is LinkLabel) {
                    this.Controls.Remove(c);
                }
            }
        }

    }
}
