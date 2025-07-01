using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TestVNPTInvoice.VNPT_INVOICE.MODEL
{
   
    [XmlRoot("DSHDon")]
    public class DSHDon
    {
        public HDon HDon { get; set; }
    }

    public class HDon
    {
        public string key { get; set; }
        public DLHDon DLHDon { get; set; }
    }

    public class DLHDon
    {
        public TTChung TTChung { get; set; }
        public NDHDon NDHDon { get; set; }
    }

    public class TTChung
    {
        public string SHDon { get; set; }
        public string MHSo { get; set; }
        public string SBKe { get; set; }
        public string NBKe { get; set; }
        public string DVTTe { get; set; }
        public string TGia { get; set; }
        public string HTTToan { get; set; }
    }

    public class NDHDon
    {
        public NBan NBan { get; set; }
        public NMua NMua { get; set; }
        public DSHHDVu DSHHDVu { get; set; }
        public TToan TToan { get; set; }
    }

    public class NBan
    {
        public string Ten { get; set; }
        public string MST { get; set; }
        public string DChi { get; set; }
        public string SDThoai { get; set; }
        public string DCTDTu { get; set; }
        public string STKNHang { get; set; }
        public string TNHang { get; set; }
        public string Fax { get; set; }
        public string LDDNBo { get; set; }
        public string HDSo { get; set; }
        public string HVTNXHang { get; set; }
        public string TNVChuyen { get; set; }
        public string PTVChuyen { get; set; }
        public string HDKTSo { get; set; }
        public string HDKTNgay { get; set; }
    }

    public class NMua
    {
        public string Ten { get; set; }
        public string MST { get; set; }
        public string DChi { get; set; }
        public string MKHang { get; set; }
        public string SDThoai { get; set; }
        public string DCTDTu { get; set; }
        public string HVTNMHang { get; set; }
        public string STKNHang { get; set; }
        public string TNHang { get; set; }
        public string HVTNNHang { get; set; }
    }

    public class DSHHDVu
    {
        [XmlElement("HHDVu")]
        public List<HHDVu> HHDVu { get; set; }
    }

    public class HHDVu
    {
        public string TChat { get; set; }
        public string STT { get; set; }
        public string MHHDVu { get; set; }
        public string THHDVu { get; set; }
        public string DVTinh { get; set; }
        public string SLuong { get; set; }
        public string DGia { get; set; }
        public string TLCKhau { get; set; }
        public string STCKhau { get; set; }
        public string GTKCThue { get; set; }
        public string ThTien { get; set; }
        public string TSuat { get; set; }
        public string TThue { get; set; }
        public string TSThue { get; set; }
        public TTKhac TTKhac { get; set; }
    }

    public class TTKhac
    {
        public TTin TTin { get; set; }
    }

    public class TTin
    {
        public string TTruong { get; set; }
        public string KDLieu { get; set; }
        public string DLieu { get; set; }
    }

    public class TToan
    {
        public THTTLTSuat THTTLTSuat { get; set; }
        public string TgTCThue { get; set; }
        public string TgTThue { get; set; }
        public string TTCKTMai { get; set; }
        public string TgTTTBSo { get; set; }
        public string TgTTTBChu { get; set; }
    }

    public class THTTLTSuat
    {
        [XmlElement("LTSuat")]
        public List<LTSuat> LTSuat { get; set; }
    }

    public class LTSuat
    {
        public string TSuat { get; set; }
        public string ThTien { get; set; }
        public string TThue { get; set; }
    }

    public class HDon_GetInvViewByDate
    {
        public string DLieu { get; set; }
        public string Loai { get; set; }
        public string TThai { get; set; }
    }
}
