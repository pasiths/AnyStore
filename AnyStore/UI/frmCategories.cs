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
            //c.added_by =1;

            //Creating boolean method to insert data into database
            bool success = dal.Insert(c);

            if(success==true)
            {
                MessageBox.Show("New category inserted successfully");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to insert new category");
            }
            DataTable dt = dal.Select();
            dgvCategories.DataSource = dt;
        }

        public void Clear()
        {
            txtCategoryID.Clear();
            txtDescription.Clear();
            txtTitle.Clear();
            txtSearch.Clear();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvCategories.DataSource = dt;
        }

        private void dgvCategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtCategoryID.Text = dgvCategories.Rows[RowIndex].Cells[0].Value.ToString();
            txtTitle.Text = dgvCategories.Rows[RowIndex].Cells[1].Value.ToString();
            txtDescription.Text = dgvCategories.Rows[RowIndex].Cells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            c.id=int.Parse(txtCategoryID.Text);
            c.title = txtTitle.Text;
            c.description = txtDescription.Text;
            c.added_date = DateTime.Now;

            //Getting ID in added by field
            string loggeduser = frmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggeduser);
            //passsign the id of logged in user in added by field
            c.added_by = usr.id;

            //Creating boolean method to insert data into database
            bool success = dal.Update(c);

            if (success == true)
            {
                MessageBox.Show("Category Update successfully");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Update category");
            }
            DataTable dt = dal.Select();
            dgvCategories.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            c.id = int.Parse(txtCategoryID.Text);
            bool success = dal.Delete(c);

            if (success == true)
            {
                MessageBox.Show("Category Delete successfully");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Delete category");
            }
            DataTable dt = dal.Select();
            dgvCategories.DataSource = dt;
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
                dgvCategories.DataSource = dt;
            }
            else
            {
                //Show all user from the database
                DataTable dt=dal.Select();
                dgvCategories.DataSource = dt;
            }
        }
    }
}
