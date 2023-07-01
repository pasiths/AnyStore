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

        #region Insert Data in Database
        public bool Insert(userBLL u)
        {
            bool isSuccess=false;
            SqlConnection con=new SqlConnection(myConnection);

            try
            {
                String sql = "INSERT INTO tbl_users(first_name,last_name,email,username,password,address,gender,user_type,added_date,added_by) VALUES(@first_name,@last_name,@email,@username,@password,@address,@gender,@user_type,@added_date,@added_by)";
                SqlCommand cmd=new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@first_name", u.first_name);
                cmd.Parameters.AddWithValue("@last_name", u.last_name);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.first_name);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@gender", u.gender);
                cmd.Parameters.AddWithValue("@user_type", u.user_type);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);

                con.Open();

                int rows=cmd.ExecuteNonQuery();

                //If the query is executed Successfully then the value to rows will be greater than 0 else it will be less than 0
                if(rows > 0)
                {
                    //Query Successfull
                    isSuccess=true;
                }
                else
                {
                    //Query Failed
                    isSuccess=false;
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

            return isSuccess;
        }
        #endregion

        #region Update data in Database
        public bool Update(userBLL u)
        {
            bool isSuccess = false;

            SqlConnection con = new SqlConnection(myConnection);

            try
            {
                string sql = "UPDATE tbl_users SET first_name=@first_name,last_name=@last_name,email=@email,username=@username,password=@password,address=@address,gender=@gender,user_type=@user_type,added_date=@added_date,added_by=@added_by WHERE user_id=@id";
                SqlCommand cmd=new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@first_name", u.first_name);
                cmd.Parameters.AddWithValue("@last_name", u.last_name);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.first_name);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@gender", u.gender);
                cmd.Parameters.AddWithValue("@user_type", u.user_type);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);
                cmd.Parameters.AddWithValue("@id", u.id);

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
            catch(Exception ex)
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
