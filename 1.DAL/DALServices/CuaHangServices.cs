using _1.DAL.IDALServices;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.DALServices
{
    public class CuaHangServices : ICuaHangServices
    {
        private FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context _DBcontext;
        private List<CuaHang> _lstCuaHang;

        public CuaHangServices()
        {
            _DBcontext = new FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context();
            _lstCuaHang = new List<CuaHang>();
        }
        public bool addCuaHang(CuaHang cuahang)
        {
            _DBcontext.CuaHangs.Add(cuahang);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool deleteCuaHang(CuaHang cuahang)
        {
            _DBcontext.CuaHangs.Remove(cuahang);
            _DBcontext.SaveChanges();
            return true;
        }

        public List<CuaHang> getCuaHangsFromDB()
        {
            _lstCuaHang = _DBcontext.CuaHangs.ToList();
            return _lstCuaHang;
        }

        public bool updateCuaHang(CuaHang cuahang)
        {
            _DBcontext.CuaHangs.Update(cuahang);
            _DBcontext.SaveChanges();
            return true;
        }
    }
}
