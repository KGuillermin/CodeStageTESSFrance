namespace csharptest
{
    partial class CodeInsert
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
            this.textBoxcode = new System.Windows.Forms.TextBox();
            this.Buttonadd = new System.Windows.Forms.Button();
            this.textBoxnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxcode
            // 
            this.textBoxcode.Location = new System.Drawing.Point(59, 44);
            this.textBoxcode.Name = "textBoxcode";
            this.textBoxcode.Size = new System.Drawing.Size(100, 20);
            this.textBoxcode.TabIndex = 0;
            // 
            // Buttonadd
            // 
            this.Buttonadd.Location = new System.Drawing.Point(68, 160);
            this.Buttonadd.Name = "Buttonadd";
            this.Buttonadd.Size = new System.Drawing.Size(75, 23);
            this.Buttonadd.TabIndex = 2;
            this.Buttonadd.Text = "Ajouter";
            this.Buttonadd.UseVisualStyleBackColor = true;
            this.Buttonadd.Click += new System.EventHandler(this.Buttonadd_Click);
            // 
            // textBoxnum
            // 
            this.textBoxnum.Location = new System.Drawing.Point(59, 90);
            this.textBoxnum.Name = "textBoxnum";
            this.textBoxnum.Size = new System.Drawing.Size(100, 20);
            this.textBoxnum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Code :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Num : ";
            // 
            // CodeInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 285);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxnum);
            this.Controls.Add(this.Buttonadd);
            this.Controls.Add(this.textBoxcode);
            this.Name = "CodeInsert";
            this.Text = "CodeInsert";
            this.Load += new System.EventHandler(this.CodeInsert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxcode;
        private System.Windows.Forms.Button Buttonadd;
        private System.Windows.Forms.TextBox textBoxnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}