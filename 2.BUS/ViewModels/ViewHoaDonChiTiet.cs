using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ViewHoaDonChiTiet
    {
        public Guid Id { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string DongSp { get; set; }
        public string Nsx { get; set; }
        public string MauSac { get; set; }
        public int? SoLuong { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? Tong { get; set; }
    }
}
