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
    public partial class FrmChucVu : Form
    {
        public IQuanLyChucVuServices _quanLyChucVuServices;
        public ChucVu _cv;
        public FrmChucVu()
        {
            InitializeComponent();
            _quanLyChucVuServices = new QuanLyChucVuServices();
            loadData();
        }

        public void loadData()
        {
            dtgv_show.ColumnCount = 3;
            dtgv_show.Columns[0].Name = "Id";
            dtgv_show.Columns[0].Visible = false;

            dtgv_show.Columns[1].Name = "Mã";
            dtgv_show.Columns[2].Name = "Tên";

            dtgv_show.Rows.Clear();
            var lstChucVu = _quanLyChucVuServices.getChucVusFromDB();
            foreach (var item in lstChucVu)
            {
                dtgv_show.Rows.Add(item.Id, item.Ma, item.Ten);
            }
        }

        public void resetForm()
        {
            loadData();
            _cv = null;
            tb_ma.Text = "";
            tb_ten.Text = "";
        }

        private void dtgv_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtgv_show.Rows[e.RowIndex];
                _cv = _quanLyChucVuServices.getChucVusFromDB().FirstOrDefault(x => x.Id == Guid.Parse(r.Cells[0].Value.ToString()));
                tb_ma.Text = r.Cells[1].Value.ToString();
                tb_ten.Text = r.Cells[2].Value.ToString();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (tb_ma.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã chức vụ");
            }
            else if (_quanLyChucVuServices.getChucVusFromDB().Any(x => x.Ma == tb_ma.Text))
            {
                MessageBox.Show("Mã chức vụ đã tồn tại");
            }
            else
            {
                var cv = new ChucVu()
                {
                    Id = new Guid(),
                    Ma = tb_ma.Text,
                    Ten = tb_ten.Text
                };
                _quanLyChucVuServices.addChucVu(cv);
                MessageBox.Show("Thêm chức vụ thành công");
                resetForm();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (tb_ma.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã chức vụ");
            }else if (_cv == null)
            {
                MessageBox.Show("Vui lòng chọn chức vụ");
            }
            else
            {
                if (_cv.Ma == tb_ma.Text || (_cv.Ma != tb_ma.Text && _quanLyChucVuServices.getChucVusFromDB().FirstOrDefault(x => x.Ma == tb_ma.Text) == null))
                {
                    _cv.Ma = tb_ma.Text;
                    _cv.Ten = tb_ten.Text;
                    _quanLyChucVuServices.updateChucVu(_cv);
                    MessageBox.Show("Sửa chức vụ thành công");
                    resetForm();
                }
                else
                {
                    MessageBox.Show("Mã chức vụ đã tồn tại");
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (_cv == null)
            {
                MessageBox.Show("Vui lòng chọn chức vụ");
            }
            else
            {
                _quanLyChucVuServices.deleteChucVu(_cv);
                MessageBox.Show("Xóa chức vụ thành công");
                resetForm();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            resetForm();
        }
    }
}
