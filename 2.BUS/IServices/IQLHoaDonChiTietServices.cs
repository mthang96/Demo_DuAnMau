using _1.DAL.Models;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLHoaDonChiTietServices
    {
        bool addHoaDonChiTiet(HoaDonChiTiet hdct);
        bool updateHoaDonChiTiet(HoaDonChiTiet hdct);
        bool deleteHoaDonChiTiet(HoaDonChiTiet hdct);
        List<ViewHoaDonChiTiet> getHoaDonChiTietById(Guid idhoadon);
        List<HoaDonChiTiet> getHoaDonChiTietFromDB();
    }
}
