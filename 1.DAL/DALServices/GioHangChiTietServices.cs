using _1.DAL.IDALServices;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.DALServices
{
    public class GioHangChiTietServices : IGioHangChiTietServices
    {
        private FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context _DBcontext;
        private List<GioHangChiTiet> _lstGioHangChiTiet;

        public GioHangChiTietServices()
        {
            _DBcontext = new FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context();
            _lstGioHangChiTiet = new List<GioHangChiTiet>();
        }

        public bool addGioHangChiTiet(GioHangChiTiet ghct)
        {
            _DBcontext.GioHangChiTiets.Add(ghct);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool deleteGioHangChiTiet(GioHangChiTiet ghct)
        {
            _DBcontext.GioHangChiTiets.Remove(ghct);
            _DBcontext.SaveChanges();
            return true;
        }

        public List<GioHangChiTiet> getGioHangFromDB()
        {
            _lstGioHangChiTiet = _DBcontext.GioHangChiTiets.ToList();
            return _lstGioHangChiTiet;
        }

        public bool updateGioHangChiTiet(GioHangChiTiet ghct)
        {
            _DBcontext.GioHangChiTiets.Update(ghct);
            _DBcontext.SaveChanges();
            return true;
        }
    }
}
