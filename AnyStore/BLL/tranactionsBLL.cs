using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyStore.BLL
{
    internal class tranactionsBLL
    {
        public int id { get; set; }
        public int dea_cust_id { get; set; }
        public double grandTotal{get; set; }
        public DateTime transaction_date { get; set; }
        public double tax { get; set; }
        public double discount { get; set; }
        public int added_by { get; set; }
    }
}
