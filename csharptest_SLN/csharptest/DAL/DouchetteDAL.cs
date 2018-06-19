using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharptest.DAL
{
    
    public abstract class DouchetteDAL
    {

        //SqlConnection
        public static SqlConnection GetConnection()
        {
        string connectionbdd = null;
        SqlConnection cnndouchette;

        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        builder.DataSource = "37.187.175.134";
        builder.InitialCatalog = "RMSTAGIARE";
        builder.MultipleActiveResultSets = true;
        builder.UserID = "Dev1";
        builder.Password = "ST$83700";

        connectionbdd = builder.ConnectionString;
        cnndouchette = new SqlConnection(connectionbdd);
        return cnndouchette;
        }

        //C => Create / Insert
        public static void Insertdouchette(int num, int codebarre, SqlConnection cnndouchette)

        {
            SqlCommand addcodebarre = new SqlCommand("INSERT INTO DOUCHETTE (Num, codebarre)" +
                                                         " VALUES ('" + num + "','" + codebarre + "')", cnndouchette);
            int nbRow = 0;

            nbRow = addcodebarre.ExecuteNonQuery();
        }

        //R => Read / Select
        public static string Selectdouchette(string num, string codebarre, SqlConnection cnndouchette)
        {
           SqlDataReader lecteurcodebarre;
           SqlCommand verificationcodebarre = new SqlCommand("SELECT codebarre" +
                                                                    " FROM Douchette" +
                                                                    " WHERE Num = '"+num+"'", cnndouchette);

            lecteurcodebarre = verificationcodebarre.ExecuteReader();

                if (lecteurcodebarre.Read())
                    codebarre = Convert.ToString(lecteurcodebarre["codebarre"]);
                return codebarre;
        }

        //U => Update
        public static void Updatedouchette(int num, int codebarre, SqlConnection cnndouchette)
        {
            SqlCommand Modifcodebarre = new SqlCommand("UPDATE Douchette" +
                                                                    " SET codebarre = '" + codebarre + "'" +
                                                                    " WHERE num = '" + num + "'", cnndouchette);

            Modifcodebarre.ExecuteNonQuery();
        }

        //D => Delete
        public static void Deletedouchette(int num, SqlConnection cnndouchette)
        {
            SqlCommand Delcodebarre = new SqlCommand("DELETE FROM Douchette WHERE Num = '" + num + "'", cnndouchette);

            Delcodebarre.ExecuteNonQuery();
        }

        //L => List
        

    }
}
