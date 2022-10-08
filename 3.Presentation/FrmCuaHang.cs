using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.Services;
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
    public partial class FrmCuaHang : Form
    {
        public IQuanLyCuaHangServices _quanLyCuaHangServices;
        public CuaHang _ch;
        public FrmCuaHang()
        {
            InitializeComponent();
            _quanLyCuaHangServices = new QuanLyCuaHangServices();
            loadData();
        }

        public void loadData()
        {
            dtgv_show.ColumnCount = 6;
            dtgv_show.Columns[0].Name = "Id";
            dtgv_show.Columns[0].Visible = false;

            dtgv_show.Columns[1].Name = "Mã";
            dtgv_show.Columns[2].Name = "Tên";
            dtgv_show.Columns[3].Name = "Địa chỉ";
            dtgv_show.Columns[4].Name = "Thành phố";
            dtgv_show.Columns[5].Name = "Quốc gia";

            dtgv_show.Rows.Clear();
            var lstCuaHang = _quanLyCuaHangServices.getCuaHangsFromDB();

            if (tb_timkiem.Text != "")
            {
                lstCuaHang = lstCuaHang.Where(x => x.Ma.ToLower().Contains(tb_timkiem.Text.ToLower()) || x.Ten.ToLower().Contains(tb_timkiem.Text.ToLower())).ToList();
            }

            foreach (var item in lstCuaHang)
            {
                dtgv_show.Rows.Add(item.Id, item.Ma, item.Ten, item.DiaChi, item.ThanhPho, item.QuocGia);
            }
        }

        public void resetForm()
        {
            loadData();
            _ch = null;
            tb_ma.Text = "";
            tb_ten.Text = "";
            tb_diachi.Text = "";
            tb_thanhpho.Text = "";
            tb_quocgia.Text = "";
            tb_timkiem.Text = "";
        }

        private void dtgv_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtgv_show.Rows[e.RowIndex];
                _ch = _quanLyCuaHangServices.getCuaHangsFromDB().FirstOrDefault(x => x.Id == Guid.Parse(r.Cells[0].Value.ToString()));
                tb_ma.Text = r.Cells[1].Value.ToString();
                tb_ten.Text = r.Cells[2].Value.ToString();
                tb_diachi.Text = r.Cells[3].Value.ToString();
                tb_thanhpho.Text = r.Cells[4].Value.ToString();
                tb_quocgia.Text = r.Cells[5].Value.ToString();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (tb_ma.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã cửa hàng");
            }
            else if (_quanLyCuaHangServices.getCuaHangsFromDB().Any(x => x.Ma == tb_ma.Text))
            {
                MessageBox.Show("Mã cửa hàng đã tồn tại");
            }
            else
            {
                var ch = new CuaHang()
                {
                    Id = new Guid(),
                    Ma = tb_ma.Text,
                    Ten = tb_ten.Text,
                    DiaChi = tb_diachi.Text,
                    ThanhPho = tb_thanhpho.Text,
                    QuocGia = tb_quocgia.Text,
                };
                _quanLyCuaHangServices.addCuaHang(ch);
                MessageBox.Show("Thêm cửa hàng thành công");
                resetForm();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (tb_ma.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã cửa hàng");
            }
            else if (_ch == null)
            {
                MessageBox.Show("Vui lòng chọn cửa hàng");
            }
            else
            {
                if (_ch.Ma == tb_ma.Text || (_ch.Ma != tb_ma.Text && _quanLyCuaHangServices.getCuaHangsFromDB().FirstOrDefault(x => x.Ma == tb_ma.Text) == null))
                {
                    _ch.Ma = tb_ma.Text;
                    _ch.Ten = tb_ten.Text;
                    _ch.DiaChi = tb_diachi.Text;
                    _ch.ThanhPho = tb_thanhpho.Text;
                    _ch.QuocGia = tb_quocgia.Text;
                    _quanLyCuaHangServices.updateCuaHang(_ch);
                    MessageBox.Show("Sửa cửa hàng thành công");
                    resetForm();
                }
                else
                {
                    MessageBox.Show("Mã cửa hàng đã tồn tại");
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (_ch == null)
            {
                MessageBox.Show("Vui lòng chọn cửa hàng");
            }
            else
            {
                _quanLyCuaHangServices.deleteCuaHang(_ch);
                MessageBox.Show("Xóa cửa hàng thành công");
                resetForm();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
