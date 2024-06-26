﻿using AnyStore.BLL;
using AnyStore.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyStore.UI
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        userBLL u=new userBLL();
        userDAL dal= new userDAL();

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            //Getting Data From UI
            u.first_name=txtFirstName.Text;
            u.last_name=txtLastName.Text;
            u.email=txtEmail.Text;
            u.username=txtUsername.Text;
            u.password=txtPassword.Text;
            u.contact=txtContact.Text;
            u.address=txtAddress.Text;
            u.gender = cmbGender.Text;
            u.user_type = cmbUserType.Text;
            u.added_date = DateTime.Now;

            //Getting username of the logged in user
            string loggeduser = frmLogin.loggedIn;
            userBLL usr = dal.GetIDFromUsername(loggeduser);
            u.added_by = usr.id;
            //u.status = 1;
            u.modify_date= DateTime.Now;

            //Inserting Data Into Database
            bool success=dal.Insert(u);
            //If the data is successfully inserted then the value of success will be true else it will be false
            if (success == true)
            {
                //Data Successfully Inserted
                MessageBox.Show("User Successfuly Created", "Success");
                clear();
            }
            else
            {
                //Failed to insert data
                MessageBox.Show("Failed To Add New User", "Fail");
                clear();
            }
            //Refreshing Data Grid View
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }

       private void clear()
        {
            txtUserID.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtAddress.Text = string.Empty;
            cmbGender.SelectedIndex = -1;
            cmbUserType.SelectedIndex=-1;
        }

        private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the index of particular row
            int rowIndex = e.RowIndex;
            txtUserID.Text = dgvUsers.Rows[rowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dgvUsers.Rows[rowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dgvUsers.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvUsers.Rows[rowIndex].Cells[3].Value.ToString();
            txtUsername.Text = dgvUsers.Rows[rowIndex].Cells[4].Value.ToString();
            txtPassword.Text = dgvUsers.Rows[rowIndex].Cells[5].Value.ToString();
            txtContact.Text = dgvUsers.Rows[rowIndex].Cells[6].Value.ToString();
            txtAddress.Text = dgvUsers.Rows[rowIndex].Cells[7].Value.ToString();
            cmbGender.Text = dgvUsers.Rows[rowIndex].Cells[8].Value.ToString();
            cmbUserType.Text = dgvUsers.Rows[rowIndex].Cells[9].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Get the values from USerr UI
            u.id=Convert.ToInt32(txtUserID.Text);
            u.first_name=txtFirstName.Text;
            u.last_name=txtLastName.Text;
            u.email=txtEmail.Text;
            u.username=txtUsername.Text;
            u.password=txtPassword.Text;
            u.contact=txtContact.Text;
            u.address=txtAddress.Text;
            u.gender = cmbGender.Text;
            u.user_type = cmbUserType.Text;
            u.modify_date = DateTime.Now;
            u.added_by = 1;

            //Updating Data into database
            bool success=dal.Update(u);
            //if data is updated successfully then the value of success will be true else it will be false
            if (success == true)
            {
                //Data Update Successfully
                MessageBox.Show("User Successfully Updated", "Success");
                clear();
            }
            else
            {
                //failed to update user
                MessageBox.Show("Failed to Update User", "Fail");
            }
            //Refreshing Data Grid viwe
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Getting User ID from Form
            u.id=Convert.ToInt32(txtUserID.Text);
            
            bool success=dal.Delete(u);
            //if data is deleted then the value of sucess will be true else it will be false
            if (success == true)
            {
                //User Deleted Successfully
                MessageBox.Show("User Deleted Successfully","Success");
                clear();
            }
            else
            {
                //Failed to Deleted
                MessageBox.Show("Failed to Delete user","Fail");
            }
            //Refreshing Data Grid viwe
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Get Keyword from text box
            string keywords=txtSearch.Text;

            //Check if the keywords has value or not
            if (keywords != null)
            {
                //Show user based on keywords
                DataTable dt= dal.Search(keywords);
                dgvUsers.DataSource = dt;
            }
            else
            {
                //Show all user from the database
                DataTable dt=dal.Select();
                dgvUsers.DataSource = dt;
            }
        }
    }
}
