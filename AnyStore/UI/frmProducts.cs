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
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        categoriesDAL cdal= new categoriesDAL();
        productsBLL p= new productsBLL();
        productsDAL pdal= new productsDAL();
        userDAL udal= new userDAL();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Get all tha values from product form
            p.name=txtName.Text;
            p.category = cmbCategory.Text;
            p.description=txtDescription.Text;
            p.rate=decimal.Parse(txtRate.Text);
            p.qty = 0;
            p.added_date = DateTime.Now;

            //Getting ID in added by field
            string loggeduser = frmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggeduser);
            //passsign the id of logged in user in added by field
            p.added_by = usr.id;
            //c.added_by =1;

            //Creating boolean method to insert data into database
            bool success = pdal.Insert(p);

            if (success == true)
            {
                MessageBox.Show("New Product inserted successfully");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to insert Product");
            }
            DataTable dt = pdal.Select();
            dgvProducts.DataSource = dt;
        }

        public void Clear()
        {
            txtProductID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtRate.Text = string.Empty;
            txtSearch.Text = string.Empty;
            cmbCategory.SelectedIndex = -1;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            DataTable dt = pdal.Select();
            dgvProducts.DataSource = dt;
            //Creating data the table to hold the categories from Database
            DataTable categoriesDT=cdal.Select();
            //Specify datasource for categories combobox
            cmbCategory.DataSource = categoriesDT;
            //Specify display member and value member for cambobox
            cmbCategory.DisplayMember = "title";
            cmbCategory.ValueMember = "title";
        }

        private void dgvProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            txtProductID.Text = dgvProducts.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text= dgvProducts.Rows[rowIndex].Cells[1].Value.ToString();
            cmbCategory.Text= dgvProducts.Rows[rowIndex].Cells[2].Value.ToString();
            txtDescription.Text= dgvProducts.Rows[rowIndex].Cells[3].Value.ToString();
            txtRate.Text= dgvProducts.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Get all tha values from product form
            p.id=int.Parse(txtProductID.Text);
            p.name = txtName.Text;
            p.category = cmbCategory.Text;
            p.description = txtDescription.Text;
            p.rate = decimal.Parse(txtRate.Text);
            p.qty = 0;
            p.added_date = DateTime.Now;

            //Getting ID in added by field
            string loggeduser = frmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggeduser);
            //passsign the id of logged in user in added by field
            p.added_by = usr.id;
            //c.added_by =1;

            //Creating boolean method to insert data into database
            bool success = pdal.Update(p);

            if (success == true)
            {
                MessageBox.Show("Product Update successfully");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Update product");
            }
            DataTable dt = pdal.Select();
            dgvProducts.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Get all tha values from product form
            p.id = int.Parse(txtProductID.Text);
            
            //Creating boolean method to insert data into database
            bool success = pdal.Delete(p);

            if (success == true)
            {
                MessageBox.Show("Product Delete successfully");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Delete product");
            }
            DataTable dt = pdal.Select();
            dgvProducts.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword=txtSearch.Text;

            if(keyword != null)
            {
                DataTable dt = pdal.Search(keyword);
                dgvProducts.DataSource = dt;
            }
            else
            {
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;
            }
        }
    }
}
