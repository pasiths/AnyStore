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
    public partial class frmDeaCust : Form
    {
        public frmDeaCust()
        {
            InitializeComponent();
        }

        DeaCusBLL dc=new DeaCusBLL();
        DeaCustDAL dcdal=new DeaCustDAL();
        userDAL udal=new userDAL();

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Get all tha values from product form
            dc.type = cmbDeaCust.Text;
            dc.name = txtName.Text;
            dc.email = txtEmail.Text;
            dc.contact= txtContact.Text;
            dc.address = txtAddress.Text;
            dc.added_date = DateTime.Now;

            //Getting ID in added by field
            string loggeduser = frmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggeduser);
            //passsign the id of logged in user in added by field
            dc.added_by = usr.id;
            //c.added_by =1;

            //Creating boolean method to insert data into database
            bool success = dcdal.Insert(dc);

            if (success == true)
            {
                MessageBox.Show("Dealer or Customer Insert successfully");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Insert Dealer or Customer");
            }
            DataTable dt = dcdal.Select();
            dgvDeaCust.DataSource = dt;
        }

        public void Clear()
        {
            txtDeaCustID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtSearch.Text = string.Empty;
            cmbDeaCust.SelectedIndex = -1;
        }

        private void frmDeaCust_Load(object sender, EventArgs e)
        {
            DataTable dt = dcdal.Select();
            dgvDeaCust.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Get all tha values from product form
            dc.id = int.Parse(txtDeaCustID.Text);
            dc.type = cmbDeaCust.Text;
            dc.name = txtName.Text;
            dc.email = txtEmail.Text;
            dc.contact = txtContact.Text;
            dc.address = txtAddress.Text;
            dc.added_date = DateTime.Now;

            //Getting ID in added by field
            string loggeduser = frmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggeduser);
            //passsign the id of logged in user in added by field
            dc.added_by = usr.id;
            //c.added_by =1;

            //Creating boolean method to insert data into database
            bool success = dcdal.Update(dc);

            if (success == true)
            {
                MessageBox.Show("Dealer or Customer Update successfully");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Update or Customer");
            }
            DataTable dt = dcdal.Select();
            dgvDeaCust.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dc.id = int.Parse(txtDeaCustID.Text);
            bool success = dcdal.Delete(dc);

            if (success == true)
            {
                MessageBox.Show("Dealer or Customer Delete successfully");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to delete or Customer");
            }
            DataTable dt = dcdal.Select();
            dgvDeaCust.DataSource = dt;
        }

        private void dgvDeaCust_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtDeaCustID.Text = dgvDeaCust.Rows[RowIndex].Cells[0].Value.ToString();
            cmbDeaCust.Text = dgvDeaCust.Rows[RowIndex].Cells[1].Value.ToString();
            txtName.Text = dgvDeaCust.Rows[RowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvDeaCust.Rows[RowIndex].Cells[3].Value.ToString();
            txtContact.Text = dgvDeaCust.Rows[RowIndex].Cells[4].Value.ToString();
            txtAddress.Text = dgvDeaCust.Rows[RowIndex].Cells[5].Value.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Get Keyword from text box
            string keywords = txtSearch.Text;

            //Check if the keywords has value or not
            if (keywords != null)
            {
                //Show user based on keywords
                DataTable dt = dcdal.Search(keywords);
                dgvDeaCust.DataSource = dt;
            }
            else
            {
                //Show all user from the database
                DataTable dt = dcdal.Select();
                dgvDeaCust.DataSource = dt;
            }
        }
    }
}
