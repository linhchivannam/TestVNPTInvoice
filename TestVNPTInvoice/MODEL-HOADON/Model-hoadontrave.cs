using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVNPTInvoice.VNPT_INVOICE.MODEL_HOADON
{
    internal class Model_hoadontrave
    {
    }
    public class HHDVu
    {
        public string STT { get; set; }
        public string THHDVu { get; set; }
        public string DVTinh { get; set; }
        public string SLuong { get; set; }
        public string DGia { get; set; }
        public string TSuat { get; set; }
        public string ThTien { get; set; }
    }

    public class HoaDon
    {
        public string SHDon { get; set; }
        public string NLap { get; set; }
        public string TenNBan { get; set; }
        public string TenNMua { get; set; }
        public List<HHDVu> HangHoaDichVu { get; set; }

        public string TToan { get; set; }
    }
}
