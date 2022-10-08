using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQuanLyCuaHangServices
    {
        bool addCuaHang(CuaHang cuaHang);
        bool updateCuaHang(CuaHang cuaHang);
        bool deleteCuaHang(CuaHang cuaHang);
        List<CuaHang> getCuaHangsFromDB();
    }
}
