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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        loginBLL l=new loginBLL();
        loginDAL dal= new loginDAL();

        private void pboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            l.username = txtUsername.Text;
            l.password = txtPassword.Text;
            l.user_type = cmbUserType.Text;

            //Checking the login credentials
            bool sucess = dal.loginCheck(l);
            if (sucess == true)
            {
                //login successfull
                MessageBox.Show("Login Successful", "Success");
            }
            else
            {
                //Login Failed
                MessageBox.Show("Login Failed. Try Again", "Fail");
            }
        }
    }
}
