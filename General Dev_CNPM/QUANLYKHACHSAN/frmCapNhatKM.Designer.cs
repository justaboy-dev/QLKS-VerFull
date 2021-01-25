namespace QUANLYKHACHSAN
{
    partial class frmCapNhatKM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapNhatKM));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iconbtnHuy = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.icoBtnCapNhat = new FontAwesome.Sharp.IconButton();
            this.txtTile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLoaiphong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoNguoiToiDa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLoaiPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaLoaiPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKhuyenMai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlPhong = new DevExpress.XtraGrid.GridControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.iconbtnHuy);
            this.groupBox1.Controls.Add(this.iconButton2);
            this.groupBox1.Controls.Add(this.icoBtnCapNhat);
            this.groupBox1.Controls.Add(this.txtTile);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboLoaiphong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(533, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 485);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cập nhật KM";
            // 
            // iconbtnHuy
            // 
            this.iconbtnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconbtnHuy.FlatAppearance.BorderSize = 0;
            this.iconbtnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnHuy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnHuy.ForeColor = System.Drawing.Color.Red;
            this.iconbtnHuy.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconbtnHuy.IconColor = System.Drawing.Color.Red;
            this.iconbtnHuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnHuy.IconSize = 32;
            this.iconbtnHuy.Location = new System.Drawing.Point(185, 366);
            this.iconbtnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.iconbtnHuy.Name = "iconbtnHuy";
            this.iconbtnHuy.Size = new System.Drawing.Size(104, 35);
            this.iconbtnHuy.TabIndex = 27;
            this.iconbtnHuy.Text = "Hủy";
            this.iconbtnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnHuy.UseVisualStyleBackColor = true;
            this.iconbtnHuy.Click += new System.EventHandler(this.iconbtnHuy_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(100, 425);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(6, 6);
            this.iconButton2.TabIndex = 26;
            this.iconButton2.Text = "iconButton2";
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // icoBtnCapNhat
            // 
            this.icoBtnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icoBtnCapNhat.BackColor = System.Drawing.Color.Transparent;
            this.icoBtnCapNhat.FlatAppearance.BorderSize = 0;
            this.icoBtnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtnCapNhat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoBtnCapNhat.ForeColor = System.Drawing.Color.DarkGreen;
            this.icoBtnCapNhat.IconChar = FontAwesome.Sharp.IconChar.Gift;
            this.icoBtnCapNhat.IconColor = System.Drawing.Color.DarkGreen;
            this.icoBtnCapNhat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnCapNhat.IconSize = 32;
            this.icoBtnCapNhat.Location = new System.Drawing.Point(20, 366);
            this.icoBtnCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.icoBtnCapNhat.Name = "icoBtnCapNhat";
            this.icoBtnCapNhat.Size = new System.Drawing.Size(140, 35);
            this.icoBtnCapNhat.TabIndex = 25;
            this.icoBtnCapNhat.Text = "Cập nhật";
            this.icoBtnCapNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnCapNhat.UseVisualStyleBackColor = false;
            this.icoBtnCapNhat.Click += new System.EventHandler(this.icoBtnCapNhat_Click);
            // 
            // txtTile
            // 
            this.txtTile.AcceptsTab = true;
            this.txtTile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTile.Location = new System.Drawing.Point(20, 161);
            this.txtTile.Multiline = true;
            this.txtTile.Name = "txtTile";
            this.txtTile.Size = new System.Drawing.Size(269, 27);
            this.txtTile.TabIndex = 18;
            this.txtTile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTile_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Phần trăm KM";
            // 
            // cboLoaiphong
            // 
            this.cboLoaiphong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiphong.FormattingEnabled = true;
            this.cboLoaiphong.Location = new System.Drawing.Point(20, 66);
            this.cboLoaiphong.Name = "cboLoaiphong";
            this.cboLoaiphong.Size = new System.Drawing.Size(269, 26);
            this.cboLoaiphong.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại Phòng";
            // 
            // colDonGia
            // 
            this.colDonGia.Caption = "Đơn giá";
            this.colDonGia.DisplayFormat.FormatString = "c0";
            this.colDonGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDonGia.FieldName = "DonGia";
            this.colDonGia.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colDonGia.ImageOptions.Image")));
            this.colDonGia.MinWidth = 19;
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.OptionsColumn.AllowEdit = false;
            this.colDonGia.OptionsColumn.ReadOnly = true;
            this.colDonGia.Visible = true;
            this.colDonGia.VisibleIndex = 3;
            this.colDonGia.Width = 106;
            // 
            // colSoNguoiToiDa
            // 
            this.colSoNguoiToiDa.Caption = "Số Người Tối Đa";
            this.colSoNguoiToiDa.FieldName = "SoNguoiToiDa";
            this.colSoNguoiToiDa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colSoNguoiToiDa.ImageOptions.Image")));
            this.colSoNguoiToiDa.MinWidth = 19;
            this.colSoNguoiToiDa.Name = "colSoNguoiToiDa";
            this.colSoNguoiToiDa.OptionsColumn.AllowEdit = false;
            this.colSoNguoiToiDa.OptionsColumn.ReadOnly = true;
            this.colSoNguoiToiDa.Visible = true;
            this.colSoNguoiToiDa.VisibleIndex = 2;
            this.colSoNguoiToiDa.Width = 108;
            // 
            // colTenLoaiPhong
            // 
            this.colTenLoaiPhong.Caption = "Tên loại phòng";
            this.colTenLoaiPhong.FieldName = "TenLoaiPhong";
            this.colTenLoaiPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colTenLoaiPhong.ImageOptions.Image")));
            this.colTenLoaiPhong.MinWidth = 19;
            this.colTenLoaiPhong.Name = "colTenLoaiPhong";
            this.colTenLoaiPhong.OptionsColumn.AllowEdit = false;
            this.colTenLoaiPhong.OptionsColumn.ReadOnly = true;
            this.colTenLoaiPhong.Visible = true;
            this.colTenLoaiPhong.VisibleIndex = 1;
            this.colTenLoaiPhong.Width = 107;
            // 
            // colMaLoaiPhong
            // 
            this.colMaLoaiPhong.Caption = "Mã Loại Phòng";
            this.colMaLoaiPhong.FieldName = "MaLoaiPhong";
            this.colMaLoaiPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colMaLoaiPhong.ImageOptions.Image")));
            this.colMaLoaiPhong.MinWidth = 19;
            this.colMaLoaiPhong.Name = "colMaLoaiPhong";
            this.colMaLoaiPhong.OptionsColumn.AllowEdit = false;
            this.colMaLoaiPhong.OptionsColumn.ReadOnly = true;
            this.colMaLoaiPhong.Visible = true;
            this.colMaLoaiPhong.VisibleIndex = 0;
            this.colMaLoaiPhong.Width = 115;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaLoaiPhong,
            this.colTenLoaiPhong,
            this.colSoNguoiToiDa,
            this.colDonGia,
            this.colKhuyenMai});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControlPhong;
            this.gridView1.GroupPanelText = " ";
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colKhuyenMai
            // 
            this.colKhuyenMai.Caption = "KM";
            this.colKhuyenMai.FieldName = "KhuyenMai";
            this.colKhuyenMai.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("colKhuyenMai.ImageOptions.SvgImage")));
            this.colKhuyenMai.Name = "colKhuyenMai";
            this.colKhuyenMai.Visible = true;
            this.colKhuyenMai.VisibleIndex = 4;
            // 
            // gridControlPhong
            // 
            this.gridControlPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlPhong.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlPhong.Location = new System.Drawing.Point(15, 5);
            this.gridControlPhong.MainView = this.gridView1;
            this.gridControlPhong.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlPhong.Name = "gridControlPhong";
            this.gridControlPhong.Size = new System.Drawing.Size(472, 477);
            this.gridControlPhong.TabIndex = 10;
            this.gridControlPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // frmCapNhatKM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 459);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridControlPhong);
            this.Name = "frmCapNhatKM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCapNhatKM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton iconbtnHuy;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton icoBtnCapNhat;
        private System.Windows.Forms.TextBox txtTile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboLoaiphong;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colSoNguoiToiDa;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLoaiPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLoaiPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControlPhong;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraGrid.Columns.GridColumn colKhuyenMai;
    }
}