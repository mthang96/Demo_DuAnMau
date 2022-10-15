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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.Presentation
{
    public partial class FrmBanHang : Form
    {
        private readonly IQLSanPhamService _iQLSanPham;
        private readonly IQLChiTietSPServices _iQLChiTietSanPham;
        private readonly IQLGioHangChiTietServices _iQLGioHangChiTietServices;
        private readonly IQLHoaDonServices _iQLHoaDonServices;
        private readonly IQLHoaDonChiTietServices _iQLHoaDonChiTietServices;
        public List<GioHangChiTiet> _lstGioHang;
        public GioHang _gioHang;
        public Guid _ctspID;
        public HoaDon _hdCho;
        public FrmBanHang()
        {
            InitializeComponent();
            _iQLSanPham = new QLSanPhamService();
            _iQLChiTietSanPham = new QLChiTietSPServices();
            _iQLHoaDonServices = new QLHoaDonServices();
            _iQLHoaDonChiTietServices = new QLHoaDonChiTietServices();
            _lstGioHang = new List<GioHangChiTiet>();
            loadSanPham();
            loadgiohang();
            loadHDcho();
            _gioHang = new GioHang()
            {
                Id = Guid.NewGuid()
            };
        }

        public void loadHDcho()
        {
            dtg_hoadoncho.Rows.Clear();
            dtg_hoadoncho.ColumnCount = 3;
            dtg_hoadoncho.Columns[0].Name = "ID";
            dtg_hoadoncho.Columns[0].Visible = false;
            dtg_hoadoncho.Columns[1].Name = "Mã";
            dtg_hoadoncho.Columns[2].Name = "Tình trạng";
            var lstHDcho = _iQLHoaDonServices.getHoaDontFromDB().Where(x => x.TinhTrang == 1).ToList();

            foreach (var item in lstHDcho)
            {
                dtg_hoadoncho.Rows.Add(item.Id, item.Ma, item.TinhTrang);
            }

        }

        private void loadgiohang()
        {
            dtg_giohang.Rows.Clear();

            dtg_giohang.ColumnCount = 9;
            dtg_giohang.Columns[0].Name = "Mã";
            dtg_giohang.Columns[1].Name = "Tên";
            dtg_giohang.Columns[2].Name = "Số Lượng";
            dtg_giohang.Columns[3].Name = "Đơn Giá";
            dtg_giohang.Columns[4].Name = "Tổng";
            dtg_giohang.Columns[5].Name = "Màu sắc";
            dtg_giohang.Columns[6].Name = "Dòng SP";
            dtg_giohang.Columns[7].Name = "NSX";
            dtg_giohang.Columns[8].Name = "ID ctsp";
            dtg_giohang.Columns[8].Visible = false;
            foreach (var item in _lstGioHang)
            {
                var ctsp = _iQLChiTietSanPham.getChiTietSPFromDB().FirstOrDefault(x => x.ChiTietSp.Id == item.IdChiTietSp);
                dtg_giohang.Rows.Add(
                    ctsp.SanPham.Ma,
                    ctsp.SanPham.Ten,
                    item.SoLuong,
                    item.DonGia,
                    item.SoLuong * item.DonGia,
                    ctsp.MauSac.Ten,
                    ctsp.DongSp.Ten,
                    ctsp.Nsx.Ten,
                    item.IdChiTietSp
                    );
            }
        }
        private void loadSanPham()
        {
            dtg_listsp.Rows.Clear();
            dtg_listsp.ColumnCount = 8;
            dtg_listsp.Columns[0].Name = "Id";
            dtg_listsp.Columns[0].Visible = false;
            dtg_listsp.Columns[1].Name = "Mã";
            dtg_listsp.Columns[2].Name = "Tên";
            dtg_listsp.Columns[3].Name = "Số Lượng tồn";
            dtg_listsp.Columns[4].Name = "Đơn giá";
            dtg_listsp.Columns[5].Name = "Dòng SP";
            dtg_listsp.Columns[6].Name = "Màu Sắc";
            dtg_listsp.Columns[7].Name = "NSX";
            var listsp = _iQLChiTietSanPham.getChiTietSPFromDB();
            listsp = listsp.OrderBy(p => p.SanPham.Ma).ToList();
            foreach (var item in listsp)
            {
                dtg_listsp.Rows.Add(item.ChiTietSp.Id, item.SanPham.Ma, item.SanPham.Ten, item.ChiTietSp.SoLuongTon, item.ChiTietSp.GiaBan, item.DongSp.Ten, item.MauSac.Ten, item.Nsx.Ten);
            }
        }

        private void dtg_listsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_listsp.Rows[e.RowIndex];
                _ctspID = _iQLChiTietSanPham.getChiTietSPFromDB().FirstOrDefault(x => x.ChiTietSp.Id == Guid.Parse(r.Cells[0].Value.ToString())).ChiTietSp.Id;
                addGioHang(_ctspID);
            }
        }
        public void addGioHang(Guid id)
        {
            var sp = _iQLChiTietSanPham.getChiTietSPFromDB1().FirstOrDefault(x => x.Id == id);
            var data = _lstGioHang.FirstOrDefault(x => x.IdChiTietSp == id);
            if (data == null)
            {
                GioHangChiTiet ghct = new GioHangChiTiet()
                {
                    IdGioHang = _gioHang.Id,
                    IdChiTietSp = id,
                    SoLuong = 1,
                    DonGia = sp.GiaBan,
                };
                _lstGioHang.Add(ghct);
            }
            else
            {
                data.SoLuong++;
            }
            loadgiohang();
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            if (_lstGioHang.Any())
            {
                var hoaDon = new HoaDon()
                {
                    Id = Guid.NewGuid(),
                    Ma = (_iQLHoaDonServices.getHoaDontFromDB().Count + 1).ToString(),
                    TinhTrang = 1
                };
                _iQLHoaDonServices.addHoaDon(hoaDon);
                foreach (var item in _lstGioHang)
                {
                    var hdct = new HoaDonChiTiet()
                    {
                        IdHoaDon = hoaDon.Id,
                        IdChiTietSp = item.IdChiTietSp,
                        SoLuong = item.SoLuong,
                        DonGia = item.DonGia
                    };
                    _iQLHoaDonChiTietServices.addHoaDonChiTiet(hdct);
                    var sp = _iQLChiTietSanPham.getChiTietSPFromDB1().FirstOrDefault(x => x.Id == item.IdChiTietSp);
                    sp.SoLuongTon -= item.SoLuong;
                    _iQLChiTietSanPham.updateChiTietSp(sp);
                }
                MessageBox.Show("Tao hoa don thanh cong");
                _lstGioHang = new List<GioHangChiTiet>();
                loadgiohang();
                loadSanPham();
                loadHDcho();
            }
            else
            {
                MessageBox.Show("Chua co sp trong gio hang");
            }
        }

        private void btn_xoagiohang_Click(object sender, EventArgs e)
        {
            _lstGioHang = new List<GioHangChiTiet>();
            loadgiohang();
        }

        private void btn_xoáp_Click(object sender, EventArgs e)
        {
            var x = _lstGioHang.FirstOrDefault(x => x.IdChiTietSp == _ctspID);
            _lstGioHang.Remove(x);
            loadgiohang();
        }

        private void dtg_giohang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dtg_giohang.Rows[e.RowIndex];
            _ctspID = Guid.Parse(r.Cells[8].Value.ToString());
        }

        private void dtg_hoadoncho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_hoadoncho.Rows[e.RowIndex];
                _hdCho = _iQLHoaDonServices.getHoaDontFromDB().FirstOrDefault(x=>x.Id== Guid.Parse(r.Cells[0].Value.ToString()));
                lb_mahd.Text = r.Cells[1].Value.ToString();
                lb_tongtien.Text = _iQLHoaDonChiTietServices.getHoaDonChiTietFromDB().Where(x=>x.IdHoaDon == _hdCho.Id).Sum(x=>x.DonGia*x.SoLuong).ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tb_tienkhachdua.Text,out int x))
            {
                lb_tienthua.Text = (decimal.Parse(tb_tienkhachdua.Text) - decimal.Parse(lb_tongtien.Text)).ToString();
            }
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            if (int.Parse(lb_tienthua.Text) <0)
            {
                MessageBox.Show("Thieu tien");
            }else if(!int.TryParse(tb_tienkhachdua.Text, out int x))
            {
                MessageBox.Show("Tien khach dua ko hop le");
            }
            else
            {
                _hdCho.TinhTrang = 2;
                _iQLHoaDonServices.updateHoaDon(_hdCho);
                loadHDcho();
                MessageBox.Show("Thanh toan thanh cong");
            }
        }
    }
}
