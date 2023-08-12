using AnyStore.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyStore.DAL
{
    internal class transactionDAL
    {
        #region Connection String 
        //Static String to Connect Database
        static string myconnection = ConfigurationManager.ConnectionStrings["AnyStore"].ConnectionString;
        #endregion

        #region Insert Data in Database
        public bool Insert_Transaction(transctionsBLL t,out int transactionID)
        {
            //Create a boolean value and set its default value to false
            bool isSuccess=false;
            //Set the out transactionID value to negative i.e. -1
            transactionID = -1;

            SqlConnection con=new SqlConnection(myconnection);
            try
            {
                string query = "Insert Into tbl_transactions(type,dea_cust_id,grandTotal,transaction_date,tax,discount,added_by) Values(@type,@dea_cust_id,@grandTotal,@transaction_date,@tax,@discount,@added_by); Select @@IDENTITY;";
                con.Open();
                SqlCommand cmd=new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@type", t.type);
                cmd.Parameters.AddWithValue("@dea_cust_id", t.dea_cust_id);
                cmd.Parameters.AddWithValue("@grandTotal", t.grandTotal);
                cmd.Parameters.AddWithValue("@transaction_date", t.transaction_date);
                cmd.Parameters.AddWithValue("@tax", t.tax);
                cmd.Parameters.AddWithValue("@discount", t.discount);
                cmd.Parameters.AddWithValue("@added_by", t.added_by);

                //Execute the Query
                object o=cmd.ExecuteScalar();
                //If the query is execute successfully then the value will not be null else ir will be null
                if(o!=null)
                {
                    transactionID=int.Parse(o.ToString());
                    isSuccess=true;
                }
                else
                {
                    isSuccess=false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
            return isSuccess;
        }
        #endregion

        #region Update data in database
        
        #endregion

        #region Delete Data in Database
        
        #endregion
    }
}
