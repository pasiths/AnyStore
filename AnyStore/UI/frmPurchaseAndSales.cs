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
using System.Transactions;
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
        userDAL uDAL = new userDAL();
        transactionDAL tDAL = new transactionDAL();
        transactionDetailsDAL tdDAL = new transactionDetailsDAL();

        DataTable transactionDT=new DataTable();

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
            if (keyword == null || keyword=="")
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
            if (keyword == null || keyword=="")
            {
                txtName.Clear();
                txtEmail.Clear();
                txtContact.Clear();
                txtAddress.Clear();
                return;
            }

            DeaCusBLL dc = dcDAL.SearchDealerCustomerForTransaction(keyword);
            txtName.Text = dc.name;
            txtEmail.Text = dc.email;
            txtContact.Text = dc.contact;
            txtAddress.Text = dc.address;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Get product name,rate and qty customer want to busy
            string productName = txtProductName.Text;
            decimal Rate = decimal.Parse(txtRate.Text);
            decimal Qty = decimal.Parse(txtQty.Text);

            decimal Total = Rate * Qty; //Total

            //Display the subtotal i textBox
            //Get the subtotal value from textbox
            decimal subTotal = decimal.Parse(txtSubTotal.Text);
            subTotal = subTotal + Total;

            //Check whether the product is selected or not
            if (productName == "" || productName == null)
            {
                MessageBox.Show("Select the product first. Try Again!!!");
            }
            else
            {
                //Add product to the data grid view
                transactionDT.Rows.Add(productName, Rate, Qty, Total);
                //Show in Data Grid View
                dgvAddedProducts.DataSource = transactionDT;
                //Display the Subtotal in textbox
                txtSubTotal.Text = subTotal.ToString();

                //Clear the textboxes
                txtProductSearch.Clear();
                txtProductName.Clear();
                txtInventory.Text = "0.00";
                txtRate.Text = "0.00";
                txtQty.Text = "0.00";
            }
        }

        private void frmPurchaseAndSales_Load(object sender, EventArgs e)
        {
            //Specify Columns for our transactionDataTable
            transactionDT.Columns.Add("Product Name");
            transactionDT.Columns.Add("Rate");
            transactionDT.Columns.Add("Quantity");
            transactionDT.Columns.Add("Total");
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            //Get the value for discount textbox
            string value = txtDiscount.Text;

            if (value == "")
            {
                MessageBox.Show("Please Add Discount first");
            }
            else
            {
                decimal subTotal = decimal.Parse(txtSubTotal.Text);
                decimal discount = decimal.Parse(txtDiscount.Text);


                //Calculate the grandtotal based on discount
                decimal grandTotal = ((100 - discount) / 100) * subTotal;

                //Display the grandtotal in textbox
                txtGrandTotal.Text = grandTotal.ToString();
            }
        }

        private void txtVAT_TextChanged(object sender, EventArgs e)
        {
            string check = txtGrandTotal.Text;
            if (check == "")
            {
                MessageBox.Show("Calculate the discount and set the grand total first");
                return;
            }
            else
            {
                decimal previousGT = decimal.Parse(txtGrandTotal.Text);
                decimal vat = decimal.Parse(txtVAT.Text);
                decimal grandTotalWithVAT=((100+vat)/100)*previousGT;

                txtGrandTotal.Text = grandTotalWithVAT.ToString();
            }
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            decimal grandTotal = decimal.Parse(txtGrandTotal.Text);
            decimal paidAmount = decimal.Parse(txtPaidAmount.Text);

            decimal returnAmount = paidAmount - grandTotal;

            txtReturnAmount.Text = returnAmount.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Get the value from purchaseSales form here
            transctionsBLL transactions = new transctionsBLL();
            transactions.type = lblTop.Text;

            //Get the id of dealer or customer here
            //Lets get name of the dealer or customer first
            string deaCustName = txtName.Text;
            DeaCusBLL dc = dcDAL.GetDeaCustIDFromName(deaCustName);

            transactions.dea_cust_id = dc.id;
            transactions.grandTotal = decimal.Parse(txtGrandTotal.Text);
            transactions.transaction_date = DateTime.Now;
            transactions.tax = Math.Round(decimal.Parse(txtVAT.Text),2);
            transactions.discount = decimal.Parse(txtDiscount.Text);

            string username = frmLogin.loggedIn;
            userBLL u = uDAL.GetIDFromUsername(username);

            transactions.added_by = u.id;
            transactions.transactionDetails = transactionDT;

            bool success = false;

            using (TransactionScope scope = new TransactionScope())
            {
                int transactionID = -1;

                //Create a boolean value and insert transaction
                bool w = tDAL.Insert_Transaction(transactions, out transactionID);

                //Use for loop to insert transaction details
                for(int i = 0; i < transactionDT.Rows.Count; i++)
                {
                    //Get all the details of the product
                    transactionDetailsBLL transactionDetails = new transactionDetailsBLL();
                    //Get the project name and convert it to id
                    string productName = transactionDT.Rows[i][0].ToString();
                    productsBLL p = pDAL.GetProductIDFromName(productName);

                    transactionDetails.product_id = p.id;
                    transactionDetails.rate = decimal.Parse(transactionDT.Rows[i][1].ToString());
                    transactionDetails.qty = decimal.Parse(transactionDT.Rows[i][2].ToString());
                    transactionDetails.total = Math.Round(decimal.Parse(transactionDT.Rows[i][3].ToString()),2);
                    transactionDetails.dea_cust_id = dc.id;
                    transactionDetails.added_date = DateTime.Now;
                    transactionDetails.added_by = u.id;

                    //Insert Transaction Details inside the database
                    bool y = tdDAL.InsertTransactionDetails(transactionDetails);
                    success = w && y;
                }
                if (success == true)
                {
                    scope.Complete();
                    MessageBox.Show("Transaction Completed Sucessfully");

                    dgvAddedProducts.DataSource = null;
                    dgvAddedProducts.Rows.Clear();
                    dgvAddedProducts.Columns.Clear();
                    dgvAddedProducts.Refresh();


                    txtSearch.Clear();
                    txtName.Clear();
                    txtEmail.Clear();
                    txtContact.Clear();
                    txtAddress.Clear();
                    txtProductSearch.Clear();
                    txtProductName.Clear();
                    txtInventory.Clear();
                    txtRate.Clear();
                    txtQty.Clear();
                    txtSubTotal.Text="0.0";
                    txtDiscount.Text = "0.0";
                    txtVAT.Text = "0.0";
                    txtGrandTotal.Text = "0.0";
                    txtPaidAmount.Text = "0.0";
                    txtReturnAmount.Clear();
                }
                else
                {
                    MessageBox.Show("Transaction Failed");
                } 
            }
        }
    }
}
