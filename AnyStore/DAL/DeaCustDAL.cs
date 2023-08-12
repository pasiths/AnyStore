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
    internal class DeaCustDAL
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
                string query = "Select * from tbl_dea_cust";
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
        public bool Insert(DeaCusBLL dc)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(myconnection);
            try
            {
                string sql = "Insert Into tbl_dea_cust (type,name,email,contact,address,added_date,added_by) Values (@type,@name,@email,@contact,@address,@added_date,@added_by)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@type", dc.type);
                cmd.Parameters.AddWithValue("@name", dc.name);
                cmd.Parameters.AddWithValue("@email", dc.email);
                cmd.Parameters.AddWithValue("@contact", dc.contact);
                cmd.Parameters.AddWithValue("@address", dc.address);
                cmd.Parameters.AddWithValue("@added_date", dc.added_date);
                cmd.Parameters.AddWithValue("@added_by", dc.added_by);
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
        public bool Update(DeaCusBLL dc)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(myconnection);
            try
            {
                string query = "Update tbl_dea_cust Set name=@name,email=@email,contact=@contact,address=@address,added_date=@added_date,added_by=@added_by Where id=@id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", dc.name);
                cmd.Parameters.AddWithValue("@email", dc.email);
                cmd.Parameters.AddWithValue("@contact", dc.contact);
                cmd.Parameters.AddWithValue("@address", dc.address);
                cmd.Parameters.AddWithValue("@added_date", dc.added_date);
                cmd.Parameters.AddWithValue("@added_by", dc.added_by);
                cmd.Parameters.AddWithValue("@id", dc.id);

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

        #region Delete Data in Database
        public bool Delete(DeaCusBLL dc)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(myconnection);
            try
            {
                string sql = "Delete From tbl_dea_cust Where id=@id";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", dc.id);
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
            finally
            {
                con.Close();
            }
            return isSuccess;
        }
        #endregion

        #region Search User on Database using Keywords
        public DataTable Search(string keywords)
        {
            //Static Method To Connect Database
            SqlConnection con = new SqlConnection(myconnection);
            //To Hold The Data From Database
            DataTable dt = new DataTable();
            try
            {
                //SQL Query To Get Data From Database
                String sql = "SELECT * FROM tbl_dea_cust WHERE id LIKE '%" + keywords + "%' OR type LIKE '%" + keywords + "%' OR name LIKE '%" + keywords + "%' ";
                //For Executing Command
                SqlCommand cmd = new SqlCommand(sql, con);
                //Getting Data From Database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //Database Connection Open
                con.Open();
                //Fill Data In Our Datatable
                adapter.Fill(dt);
            }
            catch (Exception ex)
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

        #region Method To search dealer or customer for transaction module
        public DeaCusBLL SearchDealerCustomerForTransaction(string keyword)
        {
            DeaCusBLL dc = new DeaCusBLL();
            SqlConnection con = new SqlConnection(myconnection);
            DataTable dt = new DataTable();
            try
            {
                string sql = "Select name, email, contact, address from tbl_dea_cust Where id Like '%" + keyword + "%' Or name Like '%" + keyword + "%' ";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                con.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dc.name = dt.Rows[0]["name"].ToString();
                    dc.email = dt.Rows[0]["email"].ToString();
                    dc.contact = dt.Rows[0]["contact"].ToString();
                    dc.address = dt.Rows[0]["address"].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dc;
        }
        #endregion
    }
}
