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
    public partial class CodeUpdate : Form
    {
        public CodeUpdate()
        {
            InitializeComponent();
        }

        private void codeUpdate_Load(object sender, EventArgs e)
        {

        }
  

        private void ButtonModif_Click(object sender, EventArgs e)
        {
            
            SqlConnection cnndouchette = DouchetteDAL.GetConnection();
            int codebarre = int.Parse(textBoxcode.Text); 
            int num = int.Parse(textBoxnum.Text);
            
            /*numcode = Convert.ToInt32(textBoxnum.Text);
            codebarre = Convert.ToInt32(textBoxcode.Text);*/
            using (cnndouchette)
            {
                cnndouchette.Open();


                DouchetteDAL.Updatedouchette(num, codebarre, cnndouchette);



            }
           
        }

        private void textBoxcode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
