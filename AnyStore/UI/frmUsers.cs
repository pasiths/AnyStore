using AnyStore.BLL;
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
            u.added_by = 1;
            u.status = 1;

            //Inserting Data Into Database
            bool success=dal.Insert(u);
            //If the data is successfully inserted then the value of success will be true else it will be false
            if (success == true)
            {
                //Data Successfully Inserted
                MessageBox.Show("User Successfuly Created", "Success");
            }
            else
            {
                //Failed to insert data
                MessageBox.Show("Failed To Add New User", "Fail");
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
    }
}
