using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestVNPTInvoice
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DLG.frm_DlgTaiDanhsachHoadon f = new DLG.frm_DlgTaiDanhsachHoadon();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DLG.frm_DlgTaiDanhsachHoadonNgay f = new DLG.frm_DlgTaiDanhsachHoadonNgay();
            f.ShowDialog();
        }
    }
}
