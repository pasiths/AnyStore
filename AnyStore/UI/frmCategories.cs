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
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
        }

        categoriesBLL c=new categoriesBLL();
        categoriesDAL dal = new categoriesDAL();
        userDAL udal= new userDAL();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Get the values from categroy form
            c.title=txtTitle.Text;
            c.description=txtDescription.Text;
            c.added_date=DateTime.Now;

            //Getting ID in added by field
            string loggeduser = frmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggeduser);
            //passsign the id of logged in user in added by field
            c.added_by = usr.id;

            //Creating boolean method to insert data into database
            bool success = dal.Insert(c);

            if(success==true)
            {
                MessageBox.Show("New category inserted successfully");
            }
            else
            {
                MessageBox.Show("Failed to insert new category");
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
