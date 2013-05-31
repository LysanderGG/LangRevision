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
    public partial class ModSelectionForm : Form
    {
        private LangRevision.ETranslationMod    m_mod;
        private LangRevision                    m_parent;

        public ModSelectionForm(LangRevision _parent = null) {
            m_parent = _parent;
            InitializeComponent();
        }

        public LangRevision.ETranslationMod getTranslationMod() {
            return m_mod;
        }

        private void buttonTranslationLeftToRight_Click(object sender, EventArgs e) {
            m_mod = LangRevision.ETranslationMod.LeftToRight;
            Close();
        }

        private void buttonBoth_Click(object sender, EventArgs e) {
            m_mod = LangRevision.ETranslationMod.Both;
            Close();
        }

        private void buttonTranslationRightToLeft_Click(object sender, EventArgs e) {
            m_mod = LangRevision.ETranslationMod.RightToLeft;
            Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e) {
            base.OnFormClosed(e);
            if(m_parent != null) {
                m_parent.TranslationMod = m_mod;
            }
        }
    }
}
