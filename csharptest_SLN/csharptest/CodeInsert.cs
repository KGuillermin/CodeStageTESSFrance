using csharptest.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharptest
{
    public partial class CodeInsert : Form
    { 
        public CodeInsert()
        {
            InitializeComponent();
        }

        private void CodeInsert_Load(object sender, EventArgs e)
        {
            
            
            
        }


        public void Buttonadd_Click(object sender, EventArgs e)
        {
            
            SqlConnection cnndouchette = DouchetteDAL.GetConnection();
            /*string codebarre = string.Empty;*/
            int codebarre = int.Parse(textBoxcode.Text);
            int num = int.Parse(textBoxnum.Text);
            /*codebarre = Convert.ToInt32(textBoxcode.Text);*/
            using (cnndouchette)
            {
                cnndouchette.Open();

                DouchetteDAL.Insertdouchette(num, codebarre, cnndouchette);

                

            }
            
        }

       
    }
}
