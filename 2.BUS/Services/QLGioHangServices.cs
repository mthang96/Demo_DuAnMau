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
    public class QLGioHangServices : IQLGioHangServices
    {
        private IGioHangServices _IGioHangServices;
        private List<GioHang> _lstGioHang;
        public QLGioHangServices()
        {
            _IGioHangServices = new GioHangServices();
            _lstGioHang = new List<GioHang>();
        }

        public bool addGioHang(GioHang gh)
        {
            _IGioHangServices.addGioHang(gh);
            return true;
        }

        public bool deleteGioHang(GioHang gh)
        {
            _IGioHangServices.deleteGioHang(gh);
            return true;
        }

        public List<GioHang> getGioHangFromDB()
        {
            _lstGioHang = _IGioHangServices.getGioHangFromDB();
            return _lstGioHang;
        }

        public bool updateGioHang(GioHang gh)
        {
            _IGioHangServices.updateGioHang(gh);
            return true;
        }
    }
}
