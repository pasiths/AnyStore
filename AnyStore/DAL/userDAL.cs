using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyStore.DAL
{
    internal class userDAL
    {
        #region Connection String 
        static string myConnection = ConfigurationManager.ConnectionStrings["AnyStore"].ConnectionString;
        #endregion

        #region SelectData From Database
        public DataTable Select()
        {
            //Static Method To Connect Database
            SqlConnection con = new SqlConnection(myConnection);
            //To Hold The Data From Database
            DataTable dt = new DataTable();
            try
            {
                //SQL Query To Get Data From Database
                String sql = "SELECT * FROM tbl_users";
                //For Executing Command
                SqlCommand cmd = new SqlCommand(sql, con);
                //Getting Data From Database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //Database Connection Open
                con.Open();
                //Fill Data In Our Datatable
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {
                //Throw Message if any error occurs
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Closing Connection
                con.Close();
            }
            //Return the value in DataTable
            return dt;
        }
        #endregion
    }
}
