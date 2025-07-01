using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVNPTInvoice.VNPT_INVOICE.MODEL_HOADON
{
    public class PQHoadonThemvao
    {
        public int sott { get; set; }
        public string ten { get; set; }
        public string dvt { get; set; }
        public int vat { get; set; }
        public double soluong { get; set; }
        public double dongiaVAT { get; set; }
        public double dongiaVATchua { get; set; }
        public double thanhtien { get; set; }
        public int tinhchat { get; set; }
    }
}
