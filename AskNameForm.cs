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
        private Form returnForm;

        public AskNameForm() {
            InitializeComponent();
        }

        public AskNameForm(Form _returnForm) {
            InitializeComponent();
            returnForm = _returnForm;
        }

        private void AskNameForm_Load(object sender, EventArgs e) {

        }

        private void button_Click(object sender, EventArgs e) {
            if(String.IsNullOrEmpty(textBox.Text)) {
                MessageBox.Show("Please enter something");
            } else {

            }
        }
    }
}
