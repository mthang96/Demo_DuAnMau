using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ViewSanPham
    {
        public Guid id { get; set; }
        public string masp { get; set; }
        public string tensp { get; set; }
        public string? Nsx { get; set; }
        public string? MauSac { get; set; }
        public string? IdDongSp { get; set; }
        public int? NamBh { get; set; }
        public int? SoLuongTon { get; set; }
        public decimal? ĐonGia{ get; set; }
    }
}
