using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LangRevision
{
    public partial class AskNameForm : Form
    {

        public AskNameForm() {
            InitializeComponent();
        }

        private void AskNameForm_Load(object sender, EventArgs e) {

        }

        /// <summary>
        /// On Click, creates a new lang file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, EventArgs e) {
            String name = textBox.Text;
            if(String.IsNullOrEmpty(name)) {
                MessageBox.Show("Please enter something.");
            } else {
                // Check if the name is more than just spaces
                name = name.Trim();
                if(name.Length == 0) {
                    MessageBox.Show("Please enter something else than spaces.");
                } else {
                    // Check if a file already exists with this name
                }
            }
        }
    }
}
