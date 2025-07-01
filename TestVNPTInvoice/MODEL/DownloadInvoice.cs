using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVNPTInvoice.VNPT_INVOICE.MODEL
{
    
    public class Item
    {
        public int Index { get; set; }
        public string InvToken { get; set; }
        public string FKey { get; set; }
        public string Name { get; set; }
        public DateTime PublishDate { get; set; }
        public int SignStatus { get; set; }
        public decimal Total { get; set; }
        public decimal Amount { get; set; }
        public string Pattern { get; set; }
        public string Serial { get; set; }
        public string InvNum { get; set; }
        public int Status { get; set; }
        public string CusName { get; set; }
        public int Payment { get; set; }
    }
    
}
