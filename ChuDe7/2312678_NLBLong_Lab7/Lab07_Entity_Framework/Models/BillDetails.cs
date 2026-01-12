using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Entity_Framework.Models
{
    public class BillDetails
    {
        public int ID { get; set; }
        public int InvoiceID { get; set; }
        public int FoodID { get; set; }
        public int Quantity { get; set; }
    }
}
