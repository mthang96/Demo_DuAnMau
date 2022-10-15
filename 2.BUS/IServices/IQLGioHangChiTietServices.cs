using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLGioHangChiTietServices
    {
        bool addGioHangChiTiet(GioHangChiTiet ghct);
        bool updateGioHangChiTiet(GioHangChiTiet ghct);
        bool deleteGioHangChiTiet(GioHangChiTiet ghct);
        List<GioHangChiTiet> getGioHangFromDB();
    }
}
