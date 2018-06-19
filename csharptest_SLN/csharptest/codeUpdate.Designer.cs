namespace csharptest
{
    partial class CodeUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonModif = new System.Windows.Forms.Button();
            this.textBoxcode = new System.Windows.Forms.TextBox();
            this.textBoxnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonModif
            // 
            this.ButtonModif.Location = new System.Drawing.Point(93, 169);
            this.ButtonModif.Name = "ButtonModif";
            this.ButtonModif.Size = new System.Drawing.Size(75, 23);
            this.ButtonModif.TabIndex = 0;
            this.ButtonModif.Text = "Modifier";
            this.ButtonModif.UseVisualStyleBackColor = true;
            this.ButtonModif.Click += new System.EventHandler(this.ButtonModif_Click);
            // 
            // textBoxcode
            // 
            this.textBoxcode.Location = new System.Drawing.Point(110, 36);
            this.textBoxcode.Name = "textBoxcode";
            this.textBoxcode.Size = new System.Drawing.Size(100, 20);
            this.textBoxcode.TabIndex = 1;
            this.textBoxcode.TextChanged += new System.EventHandler(this.textBoxcode_TextChanged);
            // 
            // textBoxnum
            // 
            this.textBoxnum.Location = new System.Drawing.Point(110, 81);
            this.textBoxnum.Name = "textBoxnum";
            this.textBoxnum.Size = new System.Drawing.Size(100, 20);
            this.textBoxnum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Num : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "New code barre : ";
            // 
            // CodeUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 333);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxnum);
            this.Controls.Add(this.textBoxcode);
            this.Controls.Add(this.ButtonModif);
            this.Name = "CodeUpdate";
            this.Text = "codeUpdate";
            this.Load += new System.EventHandler(this.codeUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonModif;
        private System.Windows.Forms.TextBox textBoxcode;
        private System.Windows.Forms.TextBox textBoxnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}