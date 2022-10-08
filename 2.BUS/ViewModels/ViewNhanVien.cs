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
        public NhanVien nv { get; set; }
        public CuaHang ch { get; set; }
        public ChucVu cv { get; set; }
    }
}
