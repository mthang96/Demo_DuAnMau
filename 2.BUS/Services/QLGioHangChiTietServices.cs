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
    public class QLGioHangChiTietServices : IQLGioHangChiTietServices
    {
        private IGioHangChiTietServices _IGioHangChiTietServices;
        private List<GioHangChiTiet> _lstGioHangChiTietServices;
        public QLGioHangChiTietServices()
        {
            _IGioHangChiTietServices = new GioHangChiTietServices();
            _lstGioHangChiTietServices = new List<GioHangChiTiet>();
        }

        public bool addGioHangChiTiet(GioHangChiTiet ghct)
        {
            _IGioHangChiTietServices.addGioHangChiTiet(ghct);
            return true;
        }

        public bool deleteGioHangChiTiet(GioHangChiTiet ghct)
        {
            _IGioHangChiTietServices.deleteGioHangChiTiet(ghct);
            return true;
        }

        public List<GioHangChiTiet> getGioHangFromDB()
        {
            _lstGioHangChiTietServices=_IGioHangChiTietServices.getGioHangFromDB();
            return _lstGioHangChiTietServices;
        }

        public bool updateGioHangChiTiet(GioHangChiTiet ghct)
        {
            _IGioHangChiTietServices.updateGioHangChiTiet(ghct);
            return true;
        }
    }
}
