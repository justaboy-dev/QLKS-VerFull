using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYKHACHSAN.Model;

namespace QUANLYKHACHSAN
{
    public partial class frmThietbi : UserControl
    {
        QLKS_DB context = new QLKS_DB();
        string maTbGlobal = "";
        public frmThietbi()
        {
            InitializeComponent();
        }
        // Load grid control
        public void loadData()
        {
            gridControlThietbi.DataSource = context.THIET_BI.ToList();
        }

        //Lay thiet bi cuoi
        public THIET_BI getLastTB()
        {
            THIET_BI tb = null;
            List<THIET_BI> list = context.THIET_BI.ToList();
            foreach (var temp in list)
            {
                tb = temp;
            }
            return tb;
        }

        //Chuyen so thanh ma  "01" -> "TB02"
        public string convertNumbtoID(string n)
        {
            int numb = int.Parse(n);
            numb++;
            if (numb.ToString().Length == 2)
            {
                return "TB" + numb.ToString();
            }
            return "TB0" + numb.ToString();
        }

        //Clear textbox
        public void clearTxt()
        {
            txtTenthietbi.Clear();
            txtSoluong.Clear();
        }

        private void frmThietbi_Load(object sender, EventArgs e)
        {
            loadData();
            txtTenthietbi.Focus();
            capNhat();
        }

        private void icoBtnThem_Click(object sender, EventArgs e)
        {
            if (txtTenthietbi.Text == "" || txtSoluong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo");
            }
            else
            {
                THIET_BI tb = getLastTB();
                THIET_BI isExits = context.THIET_BI.FirstOrDefault(p=>p.TenThietBi.ToLower() == txtTenthietbi.Text.Trim().ToLower());
                if (isExits == null)
                {
                    if (tb == null)
                    {
                        THIET_BI temp = new THIET_BI() { MaThietBi = "TB01", TenThietBi = txtTenthietbi.Text.Trim(), SoLuong = txtSoluong.Text == "" ? 0 : int.Parse(txtSoluong.Text) };
                        context.THIET_BI.Add(temp);
                        context.SaveChanges();
                        loadData();
                        clearTxt();
                        MessageBox.Show("Thêm thành công!", "Thông báo");
                    }
                    else
                    {
                        string sttCuoi = tb.MaThietBi.Replace("TB", "");
                        string maTbMoi = convertNumbtoID(sttCuoi);
                        THIET_BI temp = new THIET_BI() { MaThietBi = maTbMoi, TenThietBi = txtTenthietbi.Text.Trim(), SoLuong = txtSoluong.Text == "" ? 0 : int.Parse(txtSoluong.Text) };
                        context.THIET_BI.Add(temp);
                        context.SaveChanges();
                        loadData();
                        clearTxt();
                        MessageBox.Show("Thêm thành công!", "Thông báo");
                    }
                }else
                {
                    MessageBox.Show("Đã tồn tại tên thiết bị!", "Thông báo");
                }
            }
        }

        public void capNhat()
        {
            foreach (var thietBi in context.THIET_BI.ToList())
            {
                int count = 0;
                foreach (var sohuu in context.SO_HUU_THIET_BI.ToList())
                {
                    if(sohuu.MaThietBi == thietBi.MaThietBi)
                    {
                        count++;
                    }
                }
                thietBi.SoLuong = count;
                context.SaveChanges();
            }
        }


        private void icoBtnSua_Click(object sender, EventArgs e)
        {
            if (maTbGlobal != "")
            {
                THIET_BI tb = context.THIET_BI.FirstOrDefault(p => p.MaThietBi.Equals(maTbGlobal));
                tb.TenThietBi = txtTenthietbi.Text.Trim();
                tb.SoLuong = txtSoluong.Text == "" ? 0 : int.Parse(txtSoluong.Text);
                context.SaveChanges();
                loadData();
                clearTxt();
                MessageBox.Show("Sửa thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thiết bị muốn sửa!", "Thông báo");
            }
        }

        private void icoBtnXoa_Click(object sender, EventArgs e)
        {

            if (maTbGlobal != "")
            {
                THIET_BI tb = context.THIET_BI.FirstOrDefault(p => p.MaThietBi.Equals(maTbGlobal));
                if (tb != null)
                {
                    if (MessageBox.Show("Xác nhận xóa!", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        context.THIET_BI.Remove(tb);
                        context.SaveChanges();
                        loadData();
                        clearTxt();
                        MessageBox.Show("Xóa thành công!", "Thông báo");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thiết bị muốn xóa!", "Thông báo");
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string maTB = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]).ToString();

            THIET_BI tb = context.THIET_BI.FirstOrDefault(p => p.MaThietBi.ToLower() == maTB.ToLower());
            if (tb != null)
            {
                maTbGlobal = maTB;
                txtTenthietbi.Text = tb.TenThietBi;
                txtSoluong.Text = tb.SoLuong == null ? "0" : tb.SoLuong.ToString();
            }
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void icoBtnXuatthietbi_Click(object sender, EventArgs e)
        {
            FormReport.ReportThietBi Frm = new FormReport.ReportThietBi();
            Frm.DataSource = context.THIET_BI.ToList();
            frmReportViewer Rpv = new frmReportViewer(Frm);
            Rpv.ShowDialog();
        }
    }
}
