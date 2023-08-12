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
    public partial class frmPurchaseAndSales : Form
    {
        public frmPurchaseAndSales()
        {
            InitializeComponent();
            change_topic();
        }

        DeaCustDAL dcDAL = new DeaCustDAL();
        productsDAL pDAL = new productsDAL();
        public void change_topic()
        {
            string type = frmUserDashboard.transactionType;
            lblTop.Text = type;
        }
        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the keyword from productsearch textbox
            string keyword = txtProductSearch.Text;

            //Check if we have value to txtProductSearch or not
            if (keyword == null)
            {
                txtProductName.Clear();
                txtInventory.Clear();
                txtRate.Clear();
                txtQty.Clear();
                return;
            }
            productsBLL p = pDAL.GetProductsForTransaction(keyword);

            txtProductName.Text = p.name;
            txtInventory.Text = p.qty.ToString();
            txtRate.Text = p.rate.ToString();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword=txtSearch.Text;
            if (keyword == null)
            {
                txtName.Clear();
                txtEmail.Clear();
                txtContact.Clear();
                txtAddress.Clear();
                return;
            }
        }
    }
}
