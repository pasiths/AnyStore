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
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }

        categoriesDAL cdal = new categoriesDAL();
        productsDAL pdal=new productsDAL();

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            DataTable cdt = cdal.Select();
            cmbCategories.DataSource = cdt;

            cmbCategories.DisplayMember = "title";
            cmbCategories.ValueMember = "title";

            cmbCategories.SelectedIndex = -1;

            DataTable pdt = pdal.Select();
            dvgProducts.DataSource = pdt;
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = cmbCategories.Text;
            DataTable dt = pdal.DisplayProductsBYCategory(category);
            dvgProducts.DataSource = dt;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            cmbCategories.SelectedIndex = -1;
            DataTable pdt = pdal.Select();
            dvgProducts.DataSource = pdt;
        }
    }
}
