using AnyStore.BLL;
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
    internal class categoriesDAL
    {
        #region Connection String 
        //Static String to Connect Database
        static string myconnection = ConfigurationManager.ConnectionStrings["AnyStore"].ConnectionString;
        #endregion

        #region Select method for product module
        public DataTable Select()
        {
            SqlConnection con = new SqlConnection(myconnection);
            DataTable dt = new DataTable();
            try
            {
                string query = "Select * from tbl_categories";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }

            return dt;
        }
        #endregion

        #region Insert Data in Database
        public bool Insert(categoriesBLL c)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(myconnection);
            try
            {
                string sql = "Insert Into tbl_products (title,description,added_date,added_by) Values (@title,@description,@added_date,@added_by)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@title", c.title);
                cmd.Parameters.AddWithValue("@description", c.description);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
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
        public bool Update(categoriesBLL c)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(myconnection);
            try
            {
                string query = "Update tbl_products Set title=@title,description=@description,added_date=@added_date,added_by=@added_by Where id=@id";
                SqlCommand cmd= new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@title", c.title);
                cmd.Parameters.AddWithValue("@description", c.description);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);
                cmd.Parameters.AddWithValue("@id", c.id);

                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if(rows > 0)
                {
                    isSuccess=true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally { con.Close(); }
            return isSuccess;
        }
        #endregion

        #region Delete Data in Database
        public bool Delete(categoriesBLL c)
        {
            bool isSuccess = false;
            SqlConnection con=new SqlConnection(myconnection);
            try
            {
                string sql = "Delete From tbl_products Where id=@id";
                SqlCommand cmd=new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", c.id);
                con.Open();
                int rows=cmd.ExecuteNonQuery();
                if(rows > 0)
                {
                    isSuccess=true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }
        #endregion
    }
}
