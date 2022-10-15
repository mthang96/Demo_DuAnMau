using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class OrderDetailVM
    {
        public Guid Id { get; set; }
        public string? Ma { get; set; }
        public string? Ten { get; set; }
        public int? SoLuong { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? Tong { get; set; }
    }
}
