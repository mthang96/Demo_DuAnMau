using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.Presentation
{
    public partial class FrmNhanVien : Form
    {
        public IQuanLyNhanVienServices _quanLyNhanVienServices;
        public IQuanLyCuaHangServices _quanLyCuaHangServices;
        public IQuanLyChucVuServices _quanLyChucVuServices;
        public NhanVien _nv;
        public List<ViewNhanVien> _lstNhanVien;
        public FrmNhanVien()
        {
            InitializeComponent();
            _quanLyNhanVienServices = new QuanLyNhanVienServices();
            _quanLyCuaHangServices = new QuanLyCuaHangServices();
            _quanLyChucVuServices = new QuanLyChucVuServices();
            _lstNhanVien = new List<ViewNhanVien>();
            loadComboBox();
            loadData();
        }

        public void loadComboBox()
        {
            foreach (var item in _quanLyChucVuServices.getChucVusFromDB())
            {
                cbb_chucvu.Items.Add(item.Ten);
            }
            foreach (var item in _quanLyCuaHangServices.getCuaHangsFromDB())
            {
                cbb_cuahang.Items.Add(item.Ten);
            }
            foreach (var item in _quanLyNhanVienServices.getNhanViensFromDB())
            {
                cbb_guibc.Items.Add(item.Ma);
            }
            cbb_gioitinh.Items.Add("Nam");
            cbb_gioitinh.Items.Add("Nữ");
        }

        public void loadData()
        {
            dtgv_show.ColumnCount = 11;
            dtgv_show.Columns[0].Name = "Id";
            dtgv_show.Columns[0].Visible = false;

            dtgv_show.Columns[1].Name = "Mã";
            dtgv_show.Columns[2].Name = "Tên";
            dtgv_show.Columns[3].Name = "Cửa hàng";
            dtgv_show.Columns[4].Name = "Chức vụ";
            dtgv_show.Columns[5].Name = "Người gửi BC";
            dtgv_show.Columns[6].Name = "Giới tính";
            dtgv_show.Columns[7].Name = "Ngày sinh";
            dtgv_show.Columns[8].Name = "Địa chỉ";
            dtgv_show.Columns[9].Name = "SĐT";
            dtgv_show.Columns[10].Name = "Trạng thái";

            dtgv_show.Rows.Clear();
            var lstViewNV = _quanLyNhanVienServices.getViewNhanViens();
            
            foreach (var item in lstViewNV)
            {
                dtgv_show.Rows.Add(item.nhanVien.Id,
                    item.nhanVien.Ma,
                    string.Concat(item.nhanVien.Ho, " ", item.nhanVien.TenDem, " ", item.nhanVien.Ten),
                    item.cuaHang.Ten,
                    item.chucVu.Ten,
                    item.nhanVien.IdGuiBc != null ? _quanLyNhanVienServices.getNhanViensFromDB().FirstOrDefault(x => x.Id == item.nhanVien.IdGuiBc).Ma : null,
                    item.nhanVien.GioiTinh,
                    item.nhanVien.NgaySinh.ToString(),
                    item.nhanVien.DiaChi,
                    item.nhanVien.Sdt,
                    item.nhanVien.TrangThai == 1 ? "Hoạt động" : "Không hoạt động"
                    );
            }
        }

        public void resetForm()
        {
            loadData();
            _nv = null;
            tb_ma.Text = "";
            tb_ten.Text = "";
            tb_tendem.Text = "";
            tb_ho.Text = "";
            tb_matkhau.Text = "";
            tb_diachi.Text = "";
            tb_sdt.Text = "";
            dtp_ngaysinh.Value = DateTime.Now;
            cbb_gioitinh.Text = "";
            cbb_chucvu.Text = "";
            cbb_cuahang.Text = "";
            cbb_guibc.Text = "";
            cb_hd.Checked = true;
            cb_khd.Checked = false;

        }

        private void dtgv_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtgv_show.Rows[e.RowIndex];
                _nv = _quanLyNhanVienServices.getNhanViensFromDB().FirstOrDefault(x => x.Id == Guid.Parse(r.Cells[0].Value.ToString()));
                tb_ma.Text = _nv.Ma;
                tb_ten.Text = _nv.Ten;
                tb_tendem.Text = _nv.TenDem;
                tb_ho.Text = _nv.Ho;
                cbb_cuahang.Text = _quanLyCuaHangServices.getCuaHangsFromDB().FirstOrDefault(x => x.Id == _nv.IdCh).Ten;
                cbb_chucvu.Text = _quanLyChucVuServices.getChucVusFromDB().FirstOrDefault(x => x.Id == _nv.IdCv).Ten;
                cbb_guibc.Text = _nv.IdGuiBc != null ? _quanLyNhanVienServices.getNhanViensFromDB().FirstOrDefault(x => x.Id == _nv.IdGuiBc).Ma : null;
                tb_matkhau.Text = _nv.MatKhau;
                tb_diachi.Text = _nv.DiaChi;
                tb_sdt.Text = _nv.Sdt;
                dtp_ngaysinh.Value = _nv.NgaySinh.Value;
                cbb_gioitinh.Text = _nv.GioiTinh;
                cb_hd.Checked = _nv.TrangThai == 1;
                cb_khd.Checked = _nv.TrangThai == 0;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (tb_ma.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên");
            }
            else if (_quanLyNhanVienServices.getNhanViensFromDB().Any(x => x.Ma == tb_ma.Text))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại");
            }
            else if (cbb_gioitinh.Text == "")
            {
                MessageBox.Show("Vui lòng chọn giới tính");
            }
            else if (!cb_hd.Checked && !cb_khd.Checked)
            {
                MessageBox.Show("Vui lòng chọn trạng thái");
            }
            else
            {
                var nv = new NhanVien()
                {
                    Id = new Guid(),
                    Ma = tb_ma.Text,
                    Ten = tb_ten.Text,
                    TenDem = tb_tendem.Text,
                    Ho = tb_ho.Text,
                    MatKhau = tb_matkhau.Text,
                    GioiTinh = cbb_gioitinh.Text,
                    DiaChi = tb_diachi.Text,
                    Sdt = tb_sdt.Text,
                    IdCh = cbb_cuahang.Text != "" ? _quanLyCuaHangServices.getCuaHangsFromDB().FirstOrDefault(x => x.Ten == cbb_cuahang.Text).Id : null,
                    IdCv = cbb_chucvu.Text != "" ? _quanLyChucVuServices.getChucVusFromDB().FirstOrDefault(x => x.Ten == cbb_chucvu.Text).Id : null,
                    IdGuiBc = cbb_guibc.Text != "" ? _quanLyCuaHangServices.getCuaHangsFromDB().FirstOrDefault(x => x.Ma == cbb_guibc.Text).Id : null,
                    TrangThai = cb_hd.Checked ? 1 : 0,
                    NgaySinh = dtp_ngaysinh.Value,
                };
                _quanLyNhanVienServices.addNhanVien(nv);
                MessageBox.Show("Thêm nhân viên thành công");
                resetForm();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (tb_ma.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên");
            }
            else if (_nv == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên");
            }
            else if (cbb_gioitinh.Text == "")
            {
                MessageBox.Show("Vui lòng chọn giới tính");
            }
            else if (!cb_hd.Checked && !cb_khd.Checked)
            {
                MessageBox.Show("Vui lòng chọn trạng thái");
            }
            else
            {
                if (_nv.Ma == tb_ma.Text || (_nv.Ma != tb_ma.Text && _quanLyNhanVienServices.getNhanViensFromDB().FirstOrDefault(x => x.Ma == tb_ma.Text) == null))
                {
                    _nv.Ma = tb_ma.Text;
                    _nv.Ten = tb_ten.Text;
                    _nv.TenDem = tb_tendem.Text;
                    _nv.Ho = tb_ho.Text;
                    _nv.MatKhau = tb_matkhau.Text;
                    _nv.GioiTinh = cbb_gioitinh.Text;
                    _nv.DiaChi = tb_diachi.Text;
                    _nv.Sdt = tb_sdt.Text;
                    _nv.IdCh = cbb_cuahang.Text != "" ? _quanLyCuaHangServices.getCuaHangsFromDB().FirstOrDefault(x => x.Ten == cbb_cuahang.Text).Id : null;
                    _nv.IdCv = cbb_chucvu.Text != "" ? _quanLyChucVuServices.getChucVusFromDB().FirstOrDefault(x => x.Ten == cbb_chucvu.Text).Id : null;
                    _nv.IdGuiBc = cbb_guibc.Text != "" ? _quanLyNhanVienServices.getNhanViensFromDB().FirstOrDefault(x => x.Ma == cbb_guibc.Text).Id : null;
                    _nv.TrangThai = cb_hd.Checked ? 1 : 0;
                    _nv.NgaySinh = dtp_ngaysinh.Value;
                    _quanLyNhanVienServices.updateNhanVien(_nv);
                    MessageBox.Show("Sửa nhân viên thành công");
                    resetForm();
                }
                else
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại");
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (_nv == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên");
            }
            else
            {
                _quanLyNhanVienServices.deleteNhanVien(_nv);
                MessageBox.Show("Xóa nhân viên thành công");
                resetForm();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void cb_hd_Click(object sender, EventArgs e)
        {
            if (cb_khd.Checked)
            {
                cb_khd.Checked = false;
            }
            cb_hd.Checked = true;
        }

        private void cb_khd_Click(object sender, EventArgs e)
        {
            if (cb_hd.Checked)
            {
                cb_hd.Checked = false;
            }
            cb_khd.Checked = true;
        }
    }
}
