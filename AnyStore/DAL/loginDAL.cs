﻿using AnyStore.BLL;
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
    internal class loginDAL
    {
        #region Connection String 
        //Static String to Connect Database
        static string myConnection = ConfigurationManager.ConnectionStrings["AnyStore"].ConnectionString;
        #endregion

        #region login info check
        public bool loginCheck(loginBLL l)
        {
            //Create a boolean variable and set its value to false and return it
            bool isSuccess = false;

            //Connecting to Database
            SqlConnection con=new SqlConnection(myConnection);

            try
            {
                //Sql query to check login
                string sql = "SELECT * FROM tbl_users WHERE username=@username AND password=@password AND user_type=@user_type";

                //Creating SQL Command to pass value
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@username", l.username);
                cmd.Parameters.AddWithValue("@password", l.password);
                cmd.Parameters.AddWithValue("@user_type", l.user_type);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                //Checking the rows in DataTable
                if (dt.Rows.Count>0)
                {
                    //Login Succesful
                    isSuccess=true;
                }
                else
                {
                    //Login Failed
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
