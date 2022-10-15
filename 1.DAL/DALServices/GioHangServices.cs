using _1.DAL.IDALServices;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.DALServices
{
    public class GioHangServices : IGioHangServices
    {
        private FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context _DBcontext;
        private List<GioHang> _lstGioHang;
        public GioHangServices()
        {
            _DBcontext = new FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context();
            _lstGioHang = new List<GioHang>();
        }

        public bool addGioHang(GioHang gh)
        {
            _DBcontext.GioHangs.Add(gh);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool deleteGioHang(GioHang gh)
        {
            _DBcontext.GioHangs.Remove(gh);
            _DBcontext.SaveChanges();
            return true;
        }

        public List<GioHang> getGioHangFromDB()
        {
            _lstGioHang = _DBcontext.GioHangs.ToList();
            return _lstGioHang;
        }

        public bool updateGioHang(GioHang gh)
        {
            _DBcontext.GioHangs.Update(gh);
            _DBcontext.SaveChanges();
            return true;
        }
    }
}
