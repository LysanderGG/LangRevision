﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace LangRevision
{
    public partial class AskNameForm : Form
    {

        public AskNameForm() {
            InitializeComponent();
        }

        private void AskNameForm_Load(object sender, EventArgs e) {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(this.AskNameForm_KeyDown);
        }

        /// <summary>
        /// On Click, creates a new lang file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, EventArgs e) {
            String name = textBox.Text;
            if(!FilesManager.IsValidFileName(name)) {
                MessageBox.Show("Please enter a correct file name.");
            } else {
                // Check if a file already exists with this name
                if(!Directory.Exists(Utils.LangFilesDirectory)) {
                    Directory.CreateDirectory(Utils.LangFilesDirectory);
                }

                if(FilesManager.ExistsFileInDirectory(Utils.LangFilesDirectory, name + "." + Utils.LangFilesExtension)) {
                    MessageBox.Show("This name is already used.");
                    textBox.Clear();
                } else {
                    StreamWriter sw = File.CreateText(Utils.LangFilesDirectory + "/" + name + "." + Utils.LangFilesExtension);
                    this.Close();
                }

            }
        }

        private void AskNameForm_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                this.button_Click(sender, e);
            }
        }
    }
}
