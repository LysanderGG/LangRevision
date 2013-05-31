namespace LangRevision
{
    partial class ModSelectionForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
            this.buttonTranslationLeftToRight = new System.Windows.Forms.Button();
            this.buttonTranslationRightToLeft = new System.Windows.Forms.Button();
            this.buttonBoth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTranslationLeftToRight
            // 
            this.buttonTranslationLeftToRight.Location = new System.Drawing.Point(56, 45);
            this.buttonTranslationLeftToRight.Name = "buttonTranslationLeftToRight";
            this.buttonTranslationLeftToRight.Size = new System.Drawing.Size(104, 23);
            this.buttonTranslationLeftToRight.TabIndex = 0;
            this.buttonTranslationLeftToRight.Text = "Left To Right";
            this.buttonTranslationLeftToRight.UseVisualStyleBackColor = true;
            this.buttonTranslationLeftToRight.Click += new System.EventHandler(this.buttonTranslationLeftToRight_Click);
            // 
            // buttonTranslationRightToLeft
            // 
            this.buttonTranslationRightToLeft.Location = new System.Drawing.Point(427, 45);
            this.buttonTranslationRightToLeft.Name = "buttonTranslationRightToLeft";
            this.buttonTranslationRightToLeft.Size = new System.Drawing.Size(104, 23);
            this.buttonTranslationRightToLeft.TabIndex = 1;
            this.buttonTranslationRightToLeft.Text = "Right To Left";
            this.buttonTranslationRightToLeft.UseVisualStyleBackColor = true;
            this.buttonTranslationRightToLeft.Click += new System.EventHandler(this.buttonTranslationRightToLeft_Click);
            // 
            // buttonBoth
            // 
            this.buttonBoth.Location = new System.Drawing.Point(242, 45);
            this.buttonBoth.Name = "buttonBoth";
            this.buttonBoth.Size = new System.Drawing.Size(104, 23);
            this.buttonBoth.TabIndex = 2;
            this.buttonBoth.Text = "Both";
            this.buttonBoth.UseVisualStyleBackColor = true;
            this.buttonBoth.Click += new System.EventHandler(this.buttonBoth_Click);
            // 
            // ModSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 148);
            this.Controls.Add(this.buttonBoth);
            this.Controls.Add(this.buttonTranslationRightToLeft);
            this.Controls.Add(this.buttonTranslationLeftToRight);
            this.Name = "ModSelectionForm";
            this.Text = "ModSelectionForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTranslationLeftToRight;
        private System.Windows.Forms.Button buttonTranslationRightToLeft;
        private System.Windows.Forms.Button buttonBoth;
    }
}