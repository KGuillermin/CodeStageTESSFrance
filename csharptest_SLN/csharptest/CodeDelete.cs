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
    public partial class CodeDelete : Form
    {
        public CodeDelete()
        {
            InitializeComponent();
        }

        private void CodeDelete_Load(object sender, EventArgs e)
        {

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            SqlConnection cnndouchette = DouchetteDAL.GetConnection();
            int num = int.Parse(textBoxnum.Text);
            
            using (cnndouchette)
            {
                cnndouchette.Open();


                DouchetteDAL.Deletedouchette(num, cnndouchette);



            }
        }
    }
}
