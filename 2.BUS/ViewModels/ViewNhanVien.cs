using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ViewNhanVien
    {
        public NhanVien nhanVien { get; set; }
        public CuaHang cuaHang { get; set; }
        public ChucVu chucVu { get; set; }
    }
}
