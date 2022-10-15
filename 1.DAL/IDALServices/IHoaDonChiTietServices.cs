using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IDALServices
{
    public interface IHoaDonChiTietServices
    {
        bool addHoaDonChiTiet(HoaDonChiTiet hdct);
        bool updateHoaDonChiTiet(HoaDonChiTiet hdct);
        bool deleteHoaDonChiTiet(HoaDonChiTiet hdct);
        List<HoaDonChiTiet> getHoaDonChiTietFromDB();
    }
}
