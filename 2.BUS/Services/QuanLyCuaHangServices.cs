using _1.DAL.DALServices;
using _1.DAL.IDALServices;
using _1.DAL.Models;
using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QuanLyCuaHangServices : IQuanLyCuaHangServices
    {
        private ICuaHangServices _ICuaHangServices;
        private List<CuaHang> _lstCuaHang;
        public QuanLyCuaHangServices()
        {
            _ICuaHangServices = new CuaHangServices();
            _lstCuaHang = new List<CuaHang>();
        }
        public bool addCuaHang(CuaHang cuahang)
        {
            _ICuaHangServices.addCuaHang(cuahang);
            return true;
        }

        public bool deleteCuaHang(CuaHang cuahang)
        {
            _ICuaHangServices.deleteCuaHang(cuahang);
            return true;
        }

        public List<CuaHang> getCuaHangsFromDB()
        {
            _lstCuaHang = _ICuaHangServices.getCuaHangsFromDB();
            return _lstCuaHang;
        }

        public bool updateCuaHang(CuaHang cuahang)
        {
            _ICuaHangServices.updateCuaHang(cuahang);
            return true;
        }
    }
}
