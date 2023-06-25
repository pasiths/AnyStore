using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyStore.DAL
{
    internal class userDAL
    {
        #region Connection String 
        static string myConString = ConfigurationManager.ConnectionStrings["AnyStor"].ConnectionString;
        #endregion
    }
}
