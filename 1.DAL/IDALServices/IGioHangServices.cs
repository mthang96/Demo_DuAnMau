using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IDALServices
{
    public interface IGioHangServices
    {
        bool addGioHang(GioHang gh);
        bool updateGioHang(GioHang gh);
        bool deleteGioHang(GioHang gh);
        List<GioHang> getGioHangFromDB();
    }
}
