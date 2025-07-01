using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

using TestVNPTInvoice.VNPT_INVOICE.MODEL;

namespace TestVNPTInvoice.DLG
{
    partial class frm_DlgTaiDanhsachHoadonNgay : Form
    {
        public frm_DlgTaiDanhsachHoadonNgay()
        {
            InitializeComponent();
        }

        PortalService.PortalService portalService;
        List<HDon_GetInvViewByDate> ds;
        List<VNPT_INVOICE.MODEL_HOADON.HoaDon> hd;

        private void frm_DlgTaiDanhsachHoadon_Load(object sender, EventArgs e)
        {
            ds = new List<HDon_GetInvViewByDate>();
            hd = new List<VNPT_INVOICE.MODEL_HOADON.HoaDon>();
            portalService = new PortalService.PortalService();
            portalService.Url = PQ_VNPTConfig.urlApi + PQ_VNPTConfig.PortalService;
        }
        private void TaiHoadon()
        {
            string sohd = dgvDSHD.Rows[dgvDSHD.CurrentCell.RowIndex].Cells["SHDon"].Value.ToString();
            string ngay = dgvDSHD.Rows[dgvDSHD.CurrentCell.RowIndex].Cells["NLap"].Value.ToString();
            //invToken = "1/001;C25TMD;205"
            string invToken = txtPattern.Text + ";" + txtSerial.Text + ";" + sohd;
            portalService = new PortalService.PortalService();
            portalService.Url = PQ_VNPTConfig.urlApi + PQ_VNPTConfig.PortalService;



            var r = portalService.downloadInvPDFNoPay(invToken, PQ_VNPTConfig.username, PQ_VNPTConfig.pass);
            if (IsBase64String(r))
            {
                SaveBase64Pdf(r, sohd + "-" + ngay);
            }
            else
            {
                MessageBox.Show("Báo lỗi: " + r, "Thông báo lỗi");
            }
        }
         
        private void SaveBase64Pdf(string base64String, string sohd)
        {
            try
            {
                // Thư mục mặc định (Documents)
                string defaultFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                // Tên file PDF muốn lưu
                string fileName = sohd + ".pdf";

                // Đường dẫn đầy đủ
                string filePath = Path.Combine(defaultFolder, fileName);

                // Chuyển chuỗi base64 sang mảng byte
                byte[] pdfBytes = Convert.FromBase64String(base64String);

                // Ghi dữ liệu ra file
                File.WriteAllBytes(filePath, pdfBytes);

                MessageBox.Show("Đã lưu file PDF thành công tại:\n" + filePath, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu file PDF:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ds.Clear();
            

            var r = portalService.GetInvViewByDate(PQ_VNPTConfig.username, PQ_VNPTConfig.pass, txtPattern.Text, txtSerial.Text,dtTu.Value.ToString("dd/MM/yyyy"), dtDen.Value.ToString("dd/MM/yyyy"));
            if (IsBase64String(r))
            {
                byte[] xmlBytes = Convert.FromBase64String(r);

                // 2. Chuyển byte[] thành chuỗi XML
                string xmlString = Encoding.UTF8.GetString(xmlBytes);
                txtOk.Text = xmlString;
                ds.AddRange(ReadItemsFromXml(xmlString));
                txtSL.Text = dgv.RowCount.ToString();
                hDonGetInvViewByDateBindingSource.DataSource = ds.ToList();
                //xmlBytes = Convert.FromBase64String(ds.FirstOrDefault().DLieu);
                //txtbase64.Text = Encoding.UTF8.GetString(xmlBytes);
            }
            else
            {
                txtOk.Text = r;
            }
            txtSL.Text = dgv.RowCount.ToString();
        }
        public static bool IsBase64String(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            // Base64 strings must be a multiple of 4 in length
            if (input.Length % 4 != 0)
                return false;

            try
            {
                // Try to convert and see if it fails
                Convert.FromBase64String(input);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        public static List<HDon_GetInvViewByDate> ReadItemsFromXml(string xmlContent)
        {
            var items = new List<HDon_GetInvViewByDate>();
            // var doc = XDocument.Load(xmlPath);
            var doc = XDocument.Parse(xmlContent);

            foreach (var element in doc.Descendants("HDon"))
            {
                var item = new HDon_GetInvViewByDate
                {
                    DLieu = element.Element("DLieu")?.Value,
                    Loai = element.Element("Loai")?.Value,                    
                    TThai = element.Element("TThai")?.Value,
                    
                };

                items.Add(item);
            }

            return items;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hd.Clear();
            if (ds.Count > 0)
            {

                foreach (var ok in ds)
                {
                    //  MODEL_HOADON.HoaDon a = new MODEL_HOADON.HoaDon();
                    if (ok.DLieu.Trim().Length > 0)
                    {
                        byte[] xmlBytes = Convert.FromBase64String(ok.DLieu);
                        string tmp = Encoding.UTF8.GetString(xmlBytes);
                        var doc = XDocument.Parse(tmp);

                        var hoaDonElement = doc.Element("HDon")?.Element("DLHDon");

                        var hoaDon = new VNPT_INVOICE.MODEL_HOADON.HoaDon
                        {
                            SHDon = hoaDonElement?.Element("TTChung")?.Element("SHDon")?.Value,
                            NLap = hoaDonElement?.Element("TTChung")?.Element("NLap")?.Value,
                            TenNBan = hoaDonElement?.Element("NDHDon")?.Element("NBan")?.Element("Ten")?.Value,
                            TenNMua = hoaDonElement?.Element("NDHDon")?.Element("NMua")?.Element("Ten")?.Value,
                            HangHoaDichVu = hoaDonElement?.Element("NDHDon")?
                                .Element("DSHHDVu")?
                                .Elements("HHDVu")
                                .Select(h => new VNPT_INVOICE.MODEL_HOADON.HHDVu
                                {
                                    STT = h.Element("STT")?.Value,
                                    THHDVu = h.Element("THHDVu")?.Value,
                                    DVTinh = h.Element("DVTinh")?.Value,
                                    SLuong = h.Element("SLuong")?.Value,
                                    DGia = h.Element("DGia")?.Value,
                                    TSuat = h.Element("TSuat")?.Value,
                                    ThTien = h.Element("ThTien")?.Value,
                                }).ToList(),
                            TToan= hoaDonElement?.Element("NDHDon")?.Element("TToan")?.Element("TgTTTBSo") ?.Value

                        };

                        hd.Add(hoaDon);
                    }
                }
                hoaDonBindingSource.DataSource = hd.ToList();
            }
            txtSLHD.Text = dgvDSHD.RowCount.ToString();
        }
        public static List<HHDVu> ReadHHDVuFromFile(string xmlContent)
        {
            var hhdvuList = new List<HHDVu>();

            XDocument doc = XDocument.Parse(xmlContent);

            var hhdvuElements = doc.Descendants("HHDVu");

            foreach (var el in hhdvuElements)
            {
                var item = new HHDVu
                {
                    TChat = el.Element("TChat")?.Value ?? "0",
                    STT = el.Element("STT")?.Value ?? "0",
                    THHDVu = el.Element("THHDVu")?.Value,
                    DVTinh = el.Element("DVTinh")?.Value,
                    SLuong = el.Element("SLuong")?.Value ?? "0",
                    DGia = el.Element("DGia")?.Value ?? "0",
                    TLCKhau = el.Element("TLCKhau")?.Value,
                    STCKhau = el.Element("STCKhau")?.Value,
                    TSuat = el.Element("TSuat")?.Value,
                    ThTien = el.Element("ThTien")?.Value ?? "0"
                };

                // Đọc các thông tin trong <TTKhac>
                var ttKhac = el.Element("TTKhac");
                if (ttKhac != null)
                {
                    foreach (var tTin in ttKhac.Elements("TTin"))
                    {
                        var key = tTin.Element("TTruong")?.Value ?? "";
                        var value = tTin.Element("DLieu")?.Value ?? "";
                        //item.TTKhac[key] = value;
                    }
                }

                hhdvuList.Add(item);
            }

            return hhdvuList;
        }

        private void dgvDSHD_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string sohd = dgvDSHD.Rows[e.RowIndex].Cells["SHDon"].Value.ToString();
            var q = hd.Where(w=>w.SHDon==sohd).FirstOrDefault();
            if(q != null)
            {
                hHDVuBindingSource.DataSource = q.HangHoaDichVu.ToList();
            }
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string r = dgv.Rows[e.RowIndex].Cells["DLieu"].Value.ToString();
            if (IsBase64String(r))
            {
                byte[] xmlBytes = Convert.FromBase64String(r);
                txtbase64.Text = Encoding.UTF8.GetString(xmlBytes);
            }
            else
                txtbase64.Text = r;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TaiHoadon();
        }
    }
}
