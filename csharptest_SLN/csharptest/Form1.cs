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
    public partial class Form1 : Form
    {
    
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            string connetionbdd = null;
    SqlConnection cnndouchette;
    connetionbdd ="Data Source=37.187.175.134;Initial Catalog=RMSTAGIAIRE;User ID=Dev1;Password=ST$83700";
            

            cnndouchette = new SqlConnection(connetionbdd);
            try
            {
                cnndouchette.Open();
                MessageBox.Show("Connection Open ! ");
                cnndouchette.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionbdd = null;
            SqlConnection cnndouchette;
            SqlDataReader lecteurcodebarre;
            connetionbdd = "Data Source=37.187.175.134;Initial Catalog=RMSTAGIAIRE;User ID=Dev1;Password=ST$83700";
            cnndouchette = new SqlConnection(connetionbdd);
            cnndouchette.Open();
            SqlCommand verificationcodebarre = new SqlCommand("SELECT codebarre" +
                "FROM Douchette" +
                "WHERE Num = 1");

            lecteurcodebarre = verificationcodebarre.ExecuteReader();

            textBoxCodebarre.Text = Convert.ToString(lecteurcodebarre["codebarre"]);
            cnndouchette.Close();
        }
    }
}
