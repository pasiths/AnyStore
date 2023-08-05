using AnyStore.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyStore.DAL
{
    internal class transactionDetailsDAL
    {
        #region Connection String 
        //Static String to Connect Database
        static string myconnection = ConfigurationManager.ConnectionStrings["AnyStore"].ConnectionString;
        #endregion

        #region Insert method for transaction detail
        public bool InsertTransactionDetails(transactionDetailsBLL td)
        {
            bool isSuccess=false;
            SqlConnection con=new SqlConnection(myconnection);
            try
            {
                string sql = "Insert Into tbl_transaction_detail(product_id,rate,qty,total,dea_cust_id,added_date,added_by) Values(@product_id,@rate,@qty,@total,@dea_cust_id,@added_date,@added_by)";
                SqlCommand cmd =new SqlCommand(sql,con);
                cmd.Parameters.AddWithValue("@product_id", td.product_id);
                cmd.Parameters.AddWithValue("@rate", td.rate);
                cmd.Parameters.AddWithValue("@qty", td.qty);
                cmd.Parameters.AddWithValue("@total", td.total);
                cmd.Parameters.AddWithValue("@dea_cust_id", td.dea_cust_id);
                cmd.Parameters.AddWithValue("@added_date", td.added_date);
                cmd.Parameters.AddWithValue("@added_by", td.added_by);

                con.Open();

                int rows=cmd.ExecuteNonQuery();
                if (rows>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess=false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally
            {
                con.Close();
            }
            return isSuccess;
        }
        #endregion
    }
}
