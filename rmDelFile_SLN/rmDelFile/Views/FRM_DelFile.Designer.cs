namespace rmDelFile
{
    partial class FRM_DelFile
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
            this.groupBoxformat = new System.Windows.Forms.GroupBox();
            this.CBpdf = new System.Windows.Forms.CheckBox();
            this.CBTousF = new System.Windows.Forms.CheckBox();
            this.CBbmp = new System.Windows.Forms.CheckBox();
            this.CBpng = new System.Windows.Forms.CheckBox();
            this.CBjpg = new System.Windows.Forms.CheckBox();
            this.CBtxt = new System.Windows.Forms.CheckBox();
            this.CBtif = new System.Windows.Forms.CheckBox();
            this.groupBoxtype = new System.Windows.Forms.GroupBox();
            this.CBTousT = new System.Windows.Forms.CheckBox();
            this.CBlit = new System.Windows.Forms.CheckBox();
            this.CBfac = new System.Windows.Forms.CheckBox();
            this.CBbl = new System.Windows.Forms.CheckBox();
            this.CBpod = new System.Windows.Forms.CheckBox();
            this.CBpd = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.RBmodif = new System.Windows.Forms.RadioButton();
            this.RBcreation = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxpath = new System.Windows.Forms.TextBox();
            this.buttonpath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonstart = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.CBSrep = new System.Windows.Forms.CheckBox();
            this.groupBoxformat.SuspendLayout();
            this.groupBoxtype.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxformat
            // 
            this.groupBoxformat.Controls.Add(this.CBpdf);
            this.groupBoxformat.Controls.Add(this.CBTousF);
            this.groupBoxformat.Controls.Add(this.CBbmp);
            this.groupBoxformat.Controls.Add(this.CBpng);
            this.groupBoxformat.Controls.Add(this.CBjpg);
            this.groupBoxformat.Controls.Add(this.CBtxt);
            this.groupBoxformat.Controls.Add(this.CBtif);
            this.groupBoxformat.Location = new System.Drawing.Point(35, 171);
            this.groupBoxformat.Name = "groupBoxformat";
            this.groupBoxformat.Size = new System.Drawing.Size(223, 100);
            this.groupBoxformat.TabIndex = 0;
            this.groupBoxformat.TabStop = false;
            this.groupBoxformat.Text = "Format de fichier";
            this.groupBoxformat.Enter += new System.EventHandler(this.groupBoxformat_Enter);
            // 
            // CBpdf
            // 
            this.CBpdf.AutoSize = true;
            this.CBpdf.Location = new System.Drawing.Point(150, 42);
            this.CBpdf.Name = "CBpdf";
            this.CBpdf.Size = new System.Drawing.Size(44, 17);
            this.CBpdf.TabIndex = 19;
            this.CBpdf.Text = ".pdf";
            this.CBpdf.UseVisualStyleBackColor = true;
            this.CBpdf.CheckedChanged += new System.EventHandler(this.CheckBoxformat);
            // 
            // CBTousF
            // 
            this.CBTousF.AutoSize = true;
            this.CBTousF.Location = new System.Drawing.Point(20, 66);
            this.CBTousF.Name = "CBTousF";
            this.CBTousF.Size = new System.Drawing.Size(50, 17);
            this.CBTousF.TabIndex = 18;
            this.CBTousF.Text = "Tous";
            this.CBTousF.UseVisualStyleBackColor = true;
            this.CBTousF.CheckedChanged += new System.EventHandler(this.Buttonstartacces);
            // 
            // CBbmp
            // 
            this.CBbmp.AutoSize = true;
            this.CBbmp.Location = new System.Drawing.Point(85, 19);
            this.CBbmp.Name = "CBbmp";
            this.CBbmp.Size = new System.Drawing.Size(49, 17);
            this.CBbmp.TabIndex = 16;
            this.CBbmp.Text = ".bmp";
            this.CBbmp.UseVisualStyleBackColor = true;
            this.CBbmp.CheckedChanged += new System.EventHandler(this.CheckBoxformat);
            // 
            // CBpng
            // 
            this.CBpng.AutoSize = true;
            this.CBpng.Location = new System.Drawing.Point(85, 42);
            this.CBpng.Name = "CBpng";
            this.CBpng.Size = new System.Drawing.Size(47, 17);
            this.CBpng.TabIndex = 17;
            this.CBpng.Text = ".png";
            this.CBpng.UseVisualStyleBackColor = true;
            this.CBpng.CheckedChanged += new System.EventHandler(this.CheckBoxformat);
            // 
            // CBjpg
            // 
            this.CBjpg.AutoSize = true;
            this.CBjpg.Location = new System.Drawing.Point(20, 19);
            this.CBjpg.Name = "CBjpg";
            this.CBjpg.Size = new System.Drawing.Size(43, 17);
            this.CBjpg.TabIndex = 13;
            this.CBjpg.Text = ".jpg";
            this.CBjpg.UseVisualStyleBackColor = true;
            this.CBjpg.CheckedChanged += new System.EventHandler(this.CheckBoxformat);
            // 
            // CBtxt
            // 
            this.CBtxt.AutoSize = true;
            this.CBtxt.Location = new System.Drawing.Point(150, 19);
            this.CBtxt.Name = "CBtxt";
            this.CBtxt.Size = new System.Drawing.Size(40, 17);
            this.CBtxt.TabIndex = 15;
            this.CBtxt.Text = ".txt";
            this.CBtxt.UseVisualStyleBackColor = true;
            this.CBtxt.CheckedChanged += new System.EventHandler(this.CheckBoxformat);
            // 
            // CBtif
            // 
            this.CBtif.AutoSize = true;
            this.CBtif.Location = new System.Drawing.Point(20, 42);
            this.CBtif.Name = "CBtif";
            this.CBtif.Size = new System.Drawing.Size(37, 17);
            this.CBtif.TabIndex = 14;
            this.CBtif.Text = ".tif";
            this.CBtif.UseVisualStyleBackColor = true;
            this.CBtif.CheckedChanged += new System.EventHandler(this.CheckBoxformat);
            // 
            // groupBoxtype
            // 
            this.groupBoxtype.Controls.Add(this.CBfac);
            this.groupBoxtype.Controls.Add(this.CBTousT);
            this.groupBoxtype.Controls.Add(this.CBlit);
            this.groupBoxtype.Controls.Add(this.CBbl);
            this.groupBoxtype.Controls.Add(this.CBpod);
            this.groupBoxtype.Controls.Add(this.CBpd);
            this.groupBoxtype.Location = new System.Drawing.Point(278, 171);
            this.groupBoxtype.Name = "groupBoxtype";
            this.groupBoxtype.Size = new System.Drawing.Size(200, 100);
            this.groupBoxtype.TabIndex = 1;
            this.groupBoxtype.TabStop = false;
            this.groupBoxtype.Text = "Type de fichier";
            // 
            // CBTousT
            // 
            this.CBTousT.AutoSize = true;
            this.CBTousT.Location = new System.Drawing.Point(114, 66);
            this.CBTousT.Name = "CBTousT";
            this.CBTousT.Size = new System.Drawing.Size(50, 17);
            this.CBTousT.TabIndex = 21;
            this.CBTousT.Text = "Tous";
            this.CBTousT.UseVisualStyleBackColor = true;
            this.CBTousT.CheckedChanged += new System.EventHandler(this.Buttonstartacces);
            // 
            // CBlit
            // 
            this.CBlit.AutoSize = true;
            this.CBlit.Location = new System.Drawing.Point(24, 66);
            this.CBlit.Name = "CBlit";
            this.CBlit.Size = new System.Drawing.Size(42, 17);
            this.CBlit.TabIndex = 20;
            this.CBlit.Text = "LIT";
            this.CBlit.UseVisualStyleBackColor = true;
            this.CBlit.CheckedChanged += new System.EventHandler(this.CheckBoxType);
            // 
            // CBfac
            // 
            this.CBfac.AutoSize = true;
            this.CBfac.Location = new System.Drawing.Point(114, 43);
            this.CBfac.Name = "CBfac";
            this.CBfac.Size = new System.Drawing.Size(46, 17);
            this.CBfac.TabIndex = 19;
            this.CBfac.Text = "FAC";
            this.CBfac.UseVisualStyleBackColor = true;
            this.CBfac.CheckedChanged += new System.EventHandler(this.CheckBoxType);
            // 
            // CBbl
            // 
            this.CBbl.AutoSize = true;
            this.CBbl.Location = new System.Drawing.Point(24, 20);
            this.CBbl.Name = "CBbl";
            this.CBbl.Size = new System.Drawing.Size(39, 17);
            this.CBbl.TabIndex = 16;
            this.CBbl.Text = "BL";
            this.CBbl.UseVisualStyleBackColor = true;
            this.CBbl.CheckedChanged += new System.EventHandler(this.CheckBoxType);
            // 
            // CBpod
            // 
            this.CBpod.AutoSize = true;
            this.CBpod.Location = new System.Drawing.Point(114, 20);
            this.CBpod.Name = "CBpod";
            this.CBpod.Size = new System.Drawing.Size(49, 17);
            this.CBpod.TabIndex = 18;
            this.CBpod.Text = "POD";
            this.CBpod.UseVisualStyleBackColor = true;
            this.CBpod.CheckedChanged += new System.EventHandler(this.CheckBoxType);
            // 
            // CBpd
            // 
            this.CBpd.AutoSize = true;
            this.CBpd.Location = new System.Drawing.Point(24, 43);
            this.CBpd.Name = "CBpd";
            this.CBpd.Size = new System.Drawing.Size(41, 17);
            this.CBpd.TabIndex = 17;
            this.CBpd.Text = "PD";
            this.CBpd.UseVisualStyleBackColor = true;
            this.CBpd.CheckedChanged += new System.EventHandler(this.CheckBoxType);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.RBmodif);
            this.groupBox5.Controls.Add(this.RBcreation);
            this.groupBox5.Location = new System.Drawing.Point(521, 171);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Baser sur la date de";
            // 
            // RBmodif
            // 
            this.RBmodif.AutoSize = true;
            this.RBmodif.Location = new System.Drawing.Point(103, 60);
            this.RBmodif.Name = "RBmodif";
            this.RBmodif.Size = new System.Drawing.Size(81, 17);
            this.RBmodif.TabIndex = 1;
            this.RBmodif.Text = "modification";
            this.RBmodif.UseVisualStyleBackColor = true;
            // 
            // RBcreation
            // 
            this.RBcreation.AutoSize = true;
            this.RBcreation.Checked = true;
            this.RBcreation.Location = new System.Drawing.Point(103, 19);
            this.RBcreation.Name = "RBcreation";
            this.RBcreation.Size = new System.Drawing.Size(63, 17);
            this.RBcreation.TabIndex = 0;
            this.RBcreation.TabStop = true;
            this.RBcreation.Text = "création";
            this.RBcreation.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.numericUpDown2);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Location = new System.Drawing.Point(521, 27);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 100);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ancienneté fichier";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(42, 44);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(86, 20);
            this.numericUpDown2.TabIndex = 11;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "jours";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // textBoxpath
            // 
            this.textBoxpath.Enabled = false;
            this.textBoxpath.Location = new System.Drawing.Point(86, 56);
            this.textBoxpath.MaximumSize = new System.Drawing.Size(392, 20);
            this.textBoxpath.Name = "textBoxpath";
            this.textBoxpath.Size = new System.Drawing.Size(392, 20);
            this.textBoxpath.TabIndex = 7;
            this.textBoxpath.TextChanged += new System.EventHandler(this.textBoxpath_TextChanged);
            // 
            // buttonpath
            // 
            this.buttonpath.Location = new System.Drawing.Point(86, 83);
            this.buttonpath.Name = "buttonpath";
            this.buttonpath.Size = new System.Drawing.Size(75, 23);
            this.buttonpath.TabIndex = 8;
            this.buttonpath.Text = "Parcourir";
            this.buttonpath.UseVisualStyleBackColor = true;
            this.buttonpath.Click += new System.EventHandler(this.buttonpath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Chemin :";
            // 
            // buttonstart
            // 
            this.buttonstart.Enabled = false;
            this.buttonstart.Location = new System.Drawing.Point(86, 303);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(75, 23);
            this.buttonstart.TabIndex = 11;
            this.buttonstart.Text = "Démarrer";
            this.buttonstart.UseVisualStyleBackColor = true;
            this.buttonstart.Click += new System.EventHandler(this.buttonstart_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(86, 332);
            this.progressBar.Maximum = 1000;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(585, 16);
            this.progressBar.TabIndex = 13;
            this.progressBar.Visible = false;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // CBSrep
            // 
            this.CBSrep.AutoSize = true;
            this.CBSrep.Location = new System.Drawing.Point(185, 87);
            this.CBSrep.Name = "CBSrep";
            this.CBSrep.Size = new System.Drawing.Size(154, 17);
            this.CBSrep.TabIndex = 14;
            this.CBSrep.Text = "Inclure les sous répertoires ";
            this.CBSrep.UseVisualStyleBackColor = true;
            this.CBSrep.Visible = false;
            // 
            // FRM_DelFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(759, 381);
            this.Controls.Add(this.CBSrep);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.buttonstart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonpath);
            this.Controls.Add(this.textBoxpath);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBoxtype);
            this.Controls.Add(this.groupBoxformat);
            this.Name = "FRM_DelFile";
            this.Text = "Suppression de fichier";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxformat.ResumeLayout(false);
            this.groupBoxformat.PerformLayout();
            this.groupBoxtype.ResumeLayout(false);
            this.groupBoxtype.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxformat;
        private System.Windows.Forms.GroupBox groupBoxtype;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton RBmodif;
        private System.Windows.Forms.RadioButton RBcreation;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBoxpath;
        private System.Windows.Forms.Button buttonpath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button buttonstart;
        private System.Windows.Forms.CheckBox CBbmp;
        private System.Windows.Forms.CheckBox CBpng;
        private System.Windows.Forms.CheckBox CBjpg;
        private System.Windows.Forms.CheckBox CBtxt;
        private System.Windows.Forms.CheckBox CBtif;
        private System.Windows.Forms.CheckBox CBfac;
        private System.Windows.Forms.CheckBox CBbl;
        private System.Windows.Forms.CheckBox CBpod;
        private System.Windows.Forms.CheckBox CBpd;
        private System.Windows.Forms.CheckBox CBlit;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox CBSrep;
        private System.Windows.Forms.CheckBox CBTousF;
        private System.Windows.Forms.CheckBox CBTousT;
        private System.Windows.Forms.CheckBox CBpdf;
    }
}

