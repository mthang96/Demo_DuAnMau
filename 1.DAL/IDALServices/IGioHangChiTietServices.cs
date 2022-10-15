using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IDALServices
{
    public interface IGioHangChiTietServices
    {
        bool addGioHangChiTiet(GioHangChiTiet ghct);
        bool updateGioHangChiTiet(GioHangChiTiet ghct);
        bool deleteGioHangChiTiet(GioHangChiTiet ghct);
        List<GioHangChiTiet> getGioHangFromDB();
    }
}
