using QUANLYKHACHSAN.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYKHACHSAN
{
    public partial class frmCapNhatKM : Form
    {
        QLKS_DB context = new QLKS_DB();
        public frmCapNhatKM()
        {
            InitializeComponent();
        }

        //loadData
        public void loadData()
        {
            gridControlPhong.DataSource = context.LOAI_PHONG.ToList();

            //Combo box
            cboLoaiphong.DataSource = context.LOAI_PHONG.ToList();
            cboLoaiphong.DisplayMember = "TenLoaiPhong";
            cboLoaiphong.ValueMember = "MaLoaiPhong";
            
        }
        private void iconbtnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void icoBtnCapNhat_Click(object sender, EventArgs e)
        {
            LOAI_PHONG loaiPhong = context.LOAI_PHONG.FirstOrDefault(p => p.MaLoaiPhong == cboLoaiphong.SelectedValue.ToString());

            if(txtTile.Text == "")
            {
                MessageBox.Show("Vui lòng nhập % khuyến mãi");
            }else
            {
                //Nếu mà khuyến mãi đã có và lớn hơn 0 thì vầy "1.000.000.00   đã giảm 50%" =>> giá gốc "2.000.000"
                
                    Double donGia = Double.Parse(loaiPhong.DonGia.ToString());
                    Double tienGoc = (donGia * 100) / Double.Parse((100-loaiPhong.KhuyenMai).ToString());

                   loaiPhong.KhuyenMai = int.Parse(txtTile.Text);
                   loaiPhong.DonGia = tienGoc - ((tienGoc * int.Parse(txtTile.Text)) / 100);
                   context.SaveChanges();
                    MessageBox.Show("Cập nhật thành công!");
                   txtTile.Clear();
                   loadData();
            }

        }

        private void txtTile_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || (char)Keys.Back == e.KeyChar);
            if (txtTile.Text.Length > 1)
            {
                e.Handled = true;
            }
            if ((char)Keys.Back == e.KeyChar)
            {
                e.Handled = false;
            }
        }

        private void frmCapNhatKM_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string maLoai = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();
            LOAI_PHONG loaiPhong = context.LOAI_PHONG.FirstOrDefault(p => p.MaLoaiPhong == maLoai);
            cboLoaiphong.Text = loaiPhong.TenLoaiPhong;
        }
    }
}
