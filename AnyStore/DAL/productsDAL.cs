using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnyStore.BLL;

namespace AnyStore.DAL
{
    internal class productsDAL
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
                string query = "Select * from tbl_products";
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
        public bool Insert(productsBLL p)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(myconnection);
            try
            {
                string sql = "Insert Into tbl_products (name,category,description,rate,qty,added_date,added_by) Values (@name,@category,@description,@rate,@qty,@added_date,@added_by)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);
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
        public bool Update(productsBLL p)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(myconnection);
            try
            {
                string query = "Update tbl_products Set name=@name,category=@category,description=@description,rate=@rate,added_date=@added_date,added_by=@added_by Where id=@id";
                SqlCommand cmd= new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);
                cmd.Parameters.AddWithValue("@id", p.id);

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
        public bool Delete(productsBLL p)
        {
            bool isSuccess = false;
            SqlConnection con=new SqlConnection(myconnection);
            try
            {
                string sql = "Delete From tbl_products Where id=@id";
                SqlCommand cmd=new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", p.id);
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
                String sql = "SELECT * FROM tbl_products WHERE id LIKE '%" + keywords + "%' OR name LIKE '%" + keywords + "%' OR category LIKE '%" + keywords + "%' ";
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

        #region Method to search product in transaction module
        public productsBLL GetProductsForTransaction(string keywords)
        {
            productsBLL p = new productsBLL();
            SqlConnection con = new SqlConnection(myconnection);
            DataTable dt = new DataTable();
            try
            {
                //Write the query to get the details
                string sql = "Select name,rate,qty From tbl_products Where id Like '%" + keywords + "%' Or name Like '%" + keywords + "%' ";
                //Create Sql Data Adapter to execute the query
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

                //Open Database connction
                con.Open();
                //PAss the value from adapter to dt
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    p.name = dt.Rows[0]["name"].ToString();
                    p.rate = decimal.Parse(dt.Rows[0]["rate"].ToString());
                    p.qty = decimal.Parse(dt.Rows[0]["qty"].ToString());
                }
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

            return p;
        }
        #endregion

        #region Method to get product id based on product name
        public productsBLL GetProductIDFromName(string ProductName)
        {
            //First crate an object of deacust BLL and return it
            productsBLL p = new productsBLL();

            //Sql Connection here
            SqlConnection con = new SqlConnection(myconnection);

            //Data Table to hold the data temporarily
            DataTable dt = new DataTable();
            try
            {
                string sql = "Select id From tbl_products Where name='" + ProductName + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                con.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    p.id = int.Parse(dt.Rows[0]["id"].ToString());
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

            return p;
        }
        #endregion

        #region Method to get current quantity from the database based on product ID
        public decimal GetProductQty(int productID)
        {
            SqlConnection con = new SqlConnection(myconnection);
            decimal qty = 0;
            DataTable dt = new DataTable();
            try
            {
                string sql = "Select qty From tbl_products Where id=" + productID;
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    qty = decimal.Parse(dt.Rows[0]["qty"].ToString());
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
            return qty;
        }
        #endregion

        #region method to update quantity
        public bool UpdateQuantity(int ProductID, decimal Qty)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(myconnection);
            try
            {
                string query = "Update tbl_products Set qty=@qty Where id=@id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@qty", Qty);
                cmd.Parameters.AddWithValue("@id", ProductID);

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

        #region method to increse product
        public bool IncreaseProduct(int ProductID,decimal IncreaseQty)
        {
            bool success = false;
            SqlConnection con = new SqlConnection(myconnection);
            try
            {
                decimal currentQty=GetProductQty(ProductID);
                decimal NewQty = currentQty + IncreaseQty;
                success=UpdateQuantity(ProductID, NewQty);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return success;
        }
        #endregion

        #region method to decrease product
        public bool DecreaseProduct(int ProductID,decimal Qty)
        {
            bool success = false;
            SqlConnection con = new SqlConnection(myconnection);
            try
            {
                decimal currentQty = GetProductQty(ProductID);
                decimal NewQty =currentQty - Qty;
                success = UpdateQuantity(ProductID, NewQty);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return success;
        }
        #endregion

        #region display products based on categories
        public DataTable DisplayProductsBYCategory(string category)
        {
            SqlConnection con = new SqlConnection(myconnection);
            DataTable dt = new DataTable();

            try
            {
                string sql = "Select * From tbl_products Where category='" + category + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return dt;
        }
        #endregion
    }
}
