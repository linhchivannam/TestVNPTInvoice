namespace TestVNPTInvoice.DLG
{
    partial class frm_DlgTaiDanhsachHoadonNgay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOk = new System.Windows.Forms.TextBox();
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.DLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tThaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDonGetInvViewByDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSL = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDSHD = new System.Windows.Forms.DataGridView();
            this.SHDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNMuaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtbase64 = new System.Windows.Forms.TextBox();
            this.dgvMH = new System.Windows.Forms.DataGridView();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHHDVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dVTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hHDVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSLHD = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDonGetInvViewByDateBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hHDVuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtOk);
            this.panel1.Controls.Add(this.dtDen);
            this.panel1.Controls.Add(this.dtTu);
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Controls.Add(this.txtSL);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSerial);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPattern);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 507);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 324;
            this.label4.Text = "Kết quả:";
            // 
            // txtOk
            // 
            this.txtOk.Location = new System.Drawing.Point(75, 80);
            this.txtOk.Name = "txtOk";
            this.txtOk.Size = new System.Drawing.Size(347, 21);
            this.txtOk.TabIndex = 323;
            // 
            // dtDen
            // 
            this.dtDen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDen.CustomFormat = "dd/MM/yyyy";
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDen.Location = new System.Drawing.Point(75, 48);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(82, 21);
            this.dtDen.TabIndex = 322;
            // 
            // dtTu
            // 
            this.dtTu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTu.CustomFormat = "dd/MM/yyyy";
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTu.Location = new System.Drawing.Point(75, 21);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(82, 21);
            this.dtTu.TabIndex = 321;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DLieu,
            this.loaiDataGridViewTextBoxColumn,
            this.tThaiDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.hDonGetInvViewByDateBindingSource;
            this.dgv.Location = new System.Drawing.Point(8, 107);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 10;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(413, 395);
            this.dgv.TabIndex = 320;
            this.dgv.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_RowEnter);
            // 
            // DLieu
            // 
            this.DLieu.DataPropertyName = "DLieu";
            this.DLieu.HeaderText = "DLieu";
            this.DLieu.Name = "DLieu";
            // 
            // loaiDataGridViewTextBoxColumn
            // 
            this.loaiDataGridViewTextBoxColumn.DataPropertyName = "Loai";
            this.loaiDataGridViewTextBoxColumn.HeaderText = "Loai";
            this.loaiDataGridViewTextBoxColumn.Name = "loaiDataGridViewTextBoxColumn";
            // 
            // tThaiDataGridViewTextBoxColumn
            // 
            this.tThaiDataGridViewTextBoxColumn.DataPropertyName = "TThai";
            this.tThaiDataGridViewTextBoxColumn.HeaderText = "TThai";
            this.tThaiDataGridViewTextBoxColumn.Name = "tThaiDataGridViewTextBoxColumn";
            // 
            // hDonGetInvViewByDateBindingSource
            // 
            this.hDonGetInvViewByDateBindingSource.DataSource = typeof(TestVNPTInvoice.VNPT_INVOICE.MODEL.HDon_GetInvViewByDate);
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(322, 50);
            this.txtSL.MaxLength = 250;
            this.txtSL.Name = "txtSL";
            this.txtSL.ReadOnly = true;
            this.txtSL.Size = new System.Drawing.Size(79, 23);
            this.txtSL.TabIndex = 319;
            this.txtSL.Text = "0";
            this.txtSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 318;
            this.button1.Text = "Tãi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 317;
            this.label3.Text = "Ký hiệu:";
            // 
            // txtSerial
            // 
            this.txtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.Location = new System.Drawing.Point(218, 50);
            this.txtSerial.MaxLength = 250;
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(79, 23);
            this.txtSerial.TabIndex = 316;
            this.txtSerial.Text = "C25TMD";
            this.txtSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 315;
            this.label2.Text = "Mãu số:";
            // 
            // txtPattern
            // 
            this.txtPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPattern.Location = new System.Drawing.Point(218, 21);
            this.txtPattern.MaxLength = 250;
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(79, 23);
            this.txtPattern.TabIndex = 314;
            this.txtPattern.Text = "1/001";
            this.txtPattern.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 313;
            this.label1.Text = "Đến ngày:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 311;
            this.label8.Text = "Từ ngày:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.dgvDSHD);
            this.panel2.Controls.Add(this.txtbase64);
            this.panel2.Controls.Add(this.dgvMH);
            this.panel2.Controls.Add(this.txtSLHD);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(439, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(507, 507);
            this.panel2.TabIndex = 1;
            // 
            // dgvDSHD
            // 
            this.dgvDSHD.AllowUserToAddRows = false;
            this.dgvDSHD.AllowUserToDeleteRows = false;
            this.dgvDSHD.AutoGenerateColumns = false;
            this.dgvDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SHDon,
            this.NLap,
            this.tenNBanDataGridViewTextBoxColumn,
            this.tenNMuaDataGridViewTextBoxColumn,
            this.TToan});
            this.dgvDSHD.DataSource = this.hoaDonBindingSource;
            this.dgvDSHD.Location = new System.Drawing.Point(6, 43);
            this.dgvDSHD.Name = "dgvDSHD";
            this.dgvDSHD.RowHeadersWidth = 10;
            this.dgvDSHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSHD.Size = new System.Drawing.Size(496, 147);
            this.dgvDSHD.TabIndex = 325;
            this.dgvDSHD.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHD_RowEnter);
            // 
            // SHDon
            // 
            this.SHDon.DataPropertyName = "SHDon";
            this.SHDon.HeaderText = "SHDon";
            this.SHDon.Name = "SHDon";
            // 
            // NLap
            // 
            this.NLap.DataPropertyName = "NLap";
            this.NLap.HeaderText = "NLap";
            this.NLap.Name = "NLap";
            // 
            // tenNBanDataGridViewTextBoxColumn
            // 
            this.tenNBanDataGridViewTextBoxColumn.DataPropertyName = "TenNBan";
            this.tenNBanDataGridViewTextBoxColumn.HeaderText = "TenNBan";
            this.tenNBanDataGridViewTextBoxColumn.Name = "tenNBanDataGridViewTextBoxColumn";
            this.tenNBanDataGridViewTextBoxColumn.Visible = false;
            this.tenNBanDataGridViewTextBoxColumn.Width = 120;
            // 
            // tenNMuaDataGridViewTextBoxColumn
            // 
            this.tenNMuaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenNMuaDataGridViewTextBoxColumn.DataPropertyName = "TenNMua";
            this.tenNMuaDataGridViewTextBoxColumn.HeaderText = "TenNMua";
            this.tenNMuaDataGridViewTextBoxColumn.Name = "tenNMuaDataGridViewTextBoxColumn";
            // 
            // TToan
            // 
            this.TToan.DataPropertyName = "TToan";
            this.TToan.HeaderText = "TToan";
            this.TToan.Name = "TToan";
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataSource = typeof(TestVNPTInvoice.VNPT_INVOICE.MODEL_HOADON.HoaDon);
            // 
            // txtbase64
            // 
            this.txtbase64.Location = new System.Drawing.Point(7, 377);
            this.txtbase64.Multiline = true;
            this.txtbase64.Name = "txtbase64";
            this.txtbase64.Size = new System.Drawing.Size(495, 125);
            this.txtbase64.TabIndex = 324;
            // 
            // dgvMH
            // 
            this.dgvMH.AllowUserToAddRows = false;
            this.dgvMH.AllowUserToDeleteRows = false;
            this.dgvMH.AutoGenerateColumns = false;
            this.dgvMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTTDataGridViewTextBoxColumn,
            this.tHHDVuDataGridViewTextBoxColumn,
            this.dVTinhDataGridViewTextBoxColumn,
            this.sLuongDataGridViewTextBoxColumn,
            this.dGiaDataGridViewTextBoxColumn,
            this.thTienDataGridViewTextBoxColumn,
            this.tSuatDataGridViewTextBoxColumn});
            this.dgvMH.DataSource = this.hHDVuBindingSource;
            this.dgvMH.Location = new System.Drawing.Point(6, 196);
            this.dgvMH.Name = "dgvMH";
            this.dgvMH.RowHeadersWidth = 10;
            this.dgvMH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMH.Size = new System.Drawing.Size(501, 175);
            this.dgvMH.TabIndex = 323;
            // 
            // sTTDataGridViewTextBoxColumn
            // 
            this.sTTDataGridViewTextBoxColumn.DataPropertyName = "STT";
            this.sTTDataGridViewTextBoxColumn.HeaderText = "STT";
            this.sTTDataGridViewTextBoxColumn.Name = "sTTDataGridViewTextBoxColumn";
            this.sTTDataGridViewTextBoxColumn.Width = 30;
            // 
            // tHHDVuDataGridViewTextBoxColumn
            // 
            this.tHHDVuDataGridViewTextBoxColumn.DataPropertyName = "THHDVu";
            this.tHHDVuDataGridViewTextBoxColumn.HeaderText = "Tên";
            this.tHHDVuDataGridViewTextBoxColumn.Name = "tHHDVuDataGridViewTextBoxColumn";
            this.tHHDVuDataGridViewTextBoxColumn.Width = 150;
            // 
            // dVTinhDataGridViewTextBoxColumn
            // 
            this.dVTinhDataGridViewTextBoxColumn.DataPropertyName = "DVTinh";
            this.dVTinhDataGridViewTextBoxColumn.HeaderText = "ĐVT";
            this.dVTinhDataGridViewTextBoxColumn.Name = "dVTinhDataGridViewTextBoxColumn";
            // 
            // sLuongDataGridViewTextBoxColumn
            // 
            this.sLuongDataGridViewTextBoxColumn.DataPropertyName = "SLuong";
            this.sLuongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.sLuongDataGridViewTextBoxColumn.Name = "sLuongDataGridViewTextBoxColumn";
            // 
            // dGiaDataGridViewTextBoxColumn
            // 
            this.dGiaDataGridViewTextBoxColumn.DataPropertyName = "DGia";
            this.dGiaDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.dGiaDataGridViewTextBoxColumn.Name = "dGiaDataGridViewTextBoxColumn";
            // 
            // thTienDataGridViewTextBoxColumn
            // 
            this.thTienDataGridViewTextBoxColumn.DataPropertyName = "ThTien";
            this.thTienDataGridViewTextBoxColumn.HeaderText = "ThTien";
            this.thTienDataGridViewTextBoxColumn.Name = "thTienDataGridViewTextBoxColumn";
            // 
            // tSuatDataGridViewTextBoxColumn
            // 
            this.tSuatDataGridViewTextBoxColumn.DataPropertyName = "TSuat";
            this.tSuatDataGridViewTextBoxColumn.HeaderText = "TSuat";
            this.tSuatDataGridViewTextBoxColumn.Name = "tSuatDataGridViewTextBoxColumn";
            this.tSuatDataGridViewTextBoxColumn.Visible = false;
            // 
            // hHDVuBindingSource
            // 
            this.hHDVuBindingSource.DataSource = typeof(TestVNPTInvoice.VNPT_INVOICE.MODEL_HOADON.HHDVu);
            // 
            // txtSLHD
            // 
            this.txtSLHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLHD.Location = new System.Drawing.Point(423, 14);
            this.txtSLHD.MaxLength = 250;
            this.txtSLHD.Name = "txtSLHD";
            this.txtSLHD.ReadOnly = true;
            this.txtSLHD.Size = new System.Drawing.Size(79, 23);
            this.txtSLHD.TabIndex = 322;
            this.txtSLHD.Text = "0";
            this.txtSLHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 29);
            this.button2.TabIndex = 319;
            this.button2.Text = "Chuyển thành hóa đơn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(224, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 29);
            this.button3.TabIndex = 326;
            this.button3.Text = "Tãi PDF";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frm_DlgTaiDanhsachHoadonNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 527);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_DlgTaiDanhsachHoadonNgay";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tãi ds hoá đơn theo ngày";
            this.Load += new System.EventHandler(this.frm_DlgTaiDanhsachHoadon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDonGetInvViewByDateBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hHDVuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSLHD;
        private System.Windows.Forms.DataGridView dgvMH;
        private System.Windows.Forms.DateTimePicker dtDen;
        private System.Windows.Forms.DateTimePicker dtTu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOk;
        private System.Windows.Forms.BindingSource hDonGetInvViewByDateBindingSource;
        private System.Windows.Forms.TextBox txtbase64;
        private System.Windows.Forms.DataGridView dgvDSHD;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private System.Windows.Forms.BindingSource hHDVuBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHHDVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dVTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tSuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tThaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNMuaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TToan;
        private System.Windows.Forms.Button button3;
    }
}
