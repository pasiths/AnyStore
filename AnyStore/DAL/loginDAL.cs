using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyStore.DAL
{
    internal class loginDAL
    {
        #region Connection String 
        //Static String to Connect Database
        static string myconnectionstring = ConfigurationManager.ConnectionStrings["AnyStore"].ConnectionString;
        #endregion
    }
}
