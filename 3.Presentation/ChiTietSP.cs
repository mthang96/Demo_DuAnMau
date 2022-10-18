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
    public partial class ChiTietSP : Form
    {
        private IQLChiTietSPServices _iQLChiTietSanPhamService;
        private List<ViewChiTietSanPham> _lstCTSanpham;
        private IQLSanPhamService _iQLSanPhamService;
        private Guid idctsp;
        public ChiTietSP()
        {
            InitializeComponent();
            _iQLChiTietSanPhamService = new QLChiTietSPServices();
            _lstCTSanpham = new List<ViewChiTietSanPham>();
            _iQLSanPhamService = new QLSanPhamService();
            loaddatafromdb();
            loadsptocbb();
        }

        public void loaddatafromdb()
        {
            dtg_danhsachctsp.Rows.Clear();
            dtg_danhsachctsp.ColumnCount = 8;
            dtg_danhsachctsp.Columns[0].Name = "IdCTSP";
            dtg_danhsachctsp.Columns[0].Visible = false;
            dtg_danhsachctsp.Columns[1].Name = "IDSP";
            dtg_danhsachctsp.Columns[2].Name = "Tên SP";
            dtg_danhsachctsp.Columns[3].Name = "Mô Tả";
            dtg_danhsachctsp.Columns[4].Name = "Số Lượng Tồn";
            dtg_danhsachctsp.Columns[5].Name = "Giá Nhập";
            dtg_danhsachctsp.Columns[6].Name = "Giá Bán";
            dtg_danhsachctsp.Columns[7].Name = "Tổng Giá";
            
            _lstCTSanpham = _iQLChiTietSanPhamService.getCTSP();
            if (tb_tensp.Text != "")
            {
                _lstCTSanpham = _lstCTSanpham.Where(p=> p.TenSP.Contains(tb_tensp.Text)).ToList();
            }
            if(tb_gia1.Text != "" && tb_gia2.Text != "")
            {
                _lstCTSanpham = _lstCTSanpham.Where(p => p.GiaBan <= Convert.ToDecimal(tb_gia2.Text) && p.GiaBan >= Convert.ToDecimal(tb_gia1.Text)).ToList();
            }           
            foreach (var item in _lstCTSanpham)
            {
                dtg_danhsachctsp.Rows.Add(item.IdCTSP, item.IdSP, item.TenSP, item.Mota, item.SoLuongTon, item.GiaNhap, item.GiaBan, item.Total);
            }
        }
        public void loadsptocbb()
        {
            foreach(var item in _iQLSanPhamService.getSanPhamFromDB())
            {
                cbb_sanpham.Items.Add(item.Ten);
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            var ac = _iQLSanPhamService.getSanPhamFromDB().FirstOrDefault(p => p.Ten == cbb_sanpham.Text);
            if(ac == null)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm");
            }
            else
            {
                CreatCTSPModel a = new CreatCTSPModel()
                {
                    IdSp = ac.Id,
                    MoTa = tb_mota.Text,
                    SoLuongTon = Convert.ToInt32(tb_soluongton.Text),
                    GiaNhap = Convert.ToDecimal(tb_gianhap.Text),
                    GiaBan = Convert.ToDecimal(tb_giaban.Text)

                };
                _iQLChiTietSanPhamService.addChiTietSp(a);
                loaddatafromdb();
            }
            
        }

        private void dtg_danhsachctsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_danhsachctsp.Rows[e.RowIndex];
                cbb_sanpham.Text = r.Cells[2].Value.ToString();
                tb_mota.Text = r.Cells[3].Value.ToString();
                tb_soluongton.Text = r.Cells[4].Value.ToString();
                tb_gianhap.Text = r.Cells[5].Value.ToString();
                tb_giaban.Text=r.Cells[6].Value.ToString();
                idctsp = Guid.Parse(r.Cells[0].Value.ToString());

            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var ac = _iQLSanPhamService.getSanPhamFromDB().FirstOrDefault(p => p.Ten == cbb_sanpham.Text);
            if (ac == null)
            {
                MessageBox.Show("abc");
            }
            else
            {
                UpdateCTSPModel a = new UpdateCTSPModel()
                {
                    IdCTSP = idctsp,
                    IdSp = ac.Id,
                    MoTa = tb_mota.Text,
                    SoLuongTon = Convert.ToInt32(tb_soluongton.Text),
                    GiaNhap = Convert.ToDecimal(tb_gianhap.Text),
                    GiaBan = Convert.ToDecimal(tb_giaban.Text)

                };
                _iQLChiTietSanPhamService.updateChiTietSp(a);
                loaddatafromdb();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(idctsp == Guid.Empty)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm để xóa");
            }
            else
            {
                DialogResult dlg = MessageBox.Show("Chú ý", "Bạn có muốn xóa sp ko", MessageBoxButtons.YesNo);
                if(dlg == DialogResult.Yes)
                {
                    _iQLChiTietSanPhamService.deleteChiTietSp(idctsp);
                    loaddatafromdb();
                }
                else
                {

                }
                
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            loaddatafromdb();
        }

        private void tb_soluongton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tb_tensp_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
