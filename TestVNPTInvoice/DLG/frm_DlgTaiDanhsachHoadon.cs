using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

using TestVNPTInvoice.MODEL;
using TestVNPTInvoice.VNPT_INVOICE.MODEL;
using Item = TestVNPTInvoice.VNPT_INVOICE.MODEL.Item;

namespace TestVNPTInvoice.DLG
{
    partial class frm_DlgTaiDanhsachHoadon : Form
    {
        public frm_DlgTaiDanhsachHoadon()
        {
            InitializeComponent();
        }

        PortalService.PortalService portalService;
        List<Item> ds;

        private void frm_DlgTaiDanhsachHoadon_Load(object sender, EventArgs e)
        {
            ds = new List<Item>();
            portalService = new PortalService.PortalService();
            portalService.Url = PQ_VNPTConfig.urlApi + PQ_VNPTConfig.PortalService;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
          
            

            var r = portalService.listInvFromNoToNo(txtTu.Text, txtDen.Text, txtPattern.Text, txtSerial.Text, PQ_VNPTConfig.username, PQ_VNPTConfig.pass);
            ds.Clear();
            ds.AddRange(ReadItemsFromXml(r));
            itemBindingSource.DataSource = ds.ToList();
            txtSL.Text = dgv.RowCount.ToString("N0");
        }

        public static List<Item> ReadItemsFromXml(string xmlContent)
        {
            var items = new List<Item>();
            // var doc = XDocument.Load(xmlPath);
            var doc = XDocument.Parse(xmlContent);

            foreach (var element in doc.Descendants("Item"))
            {
                var item = new Item
                {
                    Index = int.Parse(element.Element("index")?.Value ?? "0"),
                    InvToken = element.Element("invToken")?.Value,
                    FKey = element.Element("fkey")?.Value,
                    Name = element.Element("name")?.Value,
                    PublishDate = DateTime.Parse(element.Element("publishDate")?.Value ?? DateTime.MinValue.ToString()),
                    SignStatus = int.Parse(element.Element("signStatus")?.Value ?? "0"),
                    Total = decimal.Parse(element.Element("total")?.Value ?? "0"),
                    Amount = decimal.Parse(element.Element("amount")?.Value ?? "0"),
                    Pattern = element.Element("pattern")?.Value,
                    Serial = element.Element("serial")?.Value,
                    InvNum = element.Element("invNum")?.Value,
                    Status = int.Parse(element.Element("status")?.Value ?? "0"),
                    CusName = element.Element("cusname")?.Value,
                    Payment = int.Parse(element.Element("payment")?.Value ?? "0"),
                };

                items.Add(item);
            }

            return items;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<HHDVu> dshh = new List<HHDVu>();
            

            if (ds.Count > 0)
            {
                foreach (var ok in ds)
                {
                    var r = portalService.downloadInvFkeyNoPay(ok.FKey, PQ_VNPTConfig.username, PQ_VNPTConfig.pass);
                    if (r != null)
                    {
                        dshh.AddRange(ReadHHDVuFromFile(r));
                    }
                }
            }           
            hHDVuBindingSource.DataSource = dshh.ToList();
            txtSLMathang.Text = dgvMH.RowCount.ToString("N0");
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
    }
}
