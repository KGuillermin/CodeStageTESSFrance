namespace csharptest
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxCodebarre = new System.Windows.Forms.TextBox();
            this.buttonok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCodebarre
            // 
            this.textBoxCodebarre.Location = new System.Drawing.Point(96, 67);
            this.textBoxCodebarre.Name = "textBoxCodebarre";
            this.textBoxCodebarre.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodebarre.TabIndex = 0;
            // 
            // buttonok
            // 
            this.buttonok.Location = new System.Drawing.Point(108, 215);
            this.buttonok.Name = "buttonok";
            this.buttonok.Size = new System.Drawing.Size(75, 23);
            this.buttonok.TabIndex = 1;
            this.buttonok.Text = "AFFICHER";
            this.buttonok.UseVisualStyleBackColor = true;
            this.buttonok.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 326);
            this.Controls.Add(this.buttonok);
            this.Controls.Add(this.textBoxCodebarre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCodebarre;
        private System.Windows.Forms.Button buttonok;
    }
}

