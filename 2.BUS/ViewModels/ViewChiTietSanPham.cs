using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ViewChiTietSanPham
    {
        public Guid IdCTSP { get; set; }
        public Guid? IdSP { get; set; }
        public string? TenSP { get; set; }
        public string? Mota { get; set; }
        public int? SoLuongTon { get; set; }
        public decimal? GiaNhap { get; set; }
        public decimal? GiaBan { get; set; }
        public decimal? Total { get; set; }
    }
}
