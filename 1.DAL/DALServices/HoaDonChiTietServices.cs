using _1.DAL.IDALServices;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.DALServices
{
    public class HoaDonChiTietServices : IHoaDonChiTietServices
    {
        private FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context _DBcontext;
        private List<HoaDonChiTiet> _lstHoaDonChiTiet;
        public HoaDonChiTietServices()
        {
            _DBcontext = new FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context();
            _lstHoaDonChiTiet = new List<HoaDonChiTiet>();
        }

        public bool addHoaDonChiTiet(HoaDonChiTiet hdct)
        {
            _DBcontext.HoaDonChiTiets.Add(hdct);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool deleteHoaDonChiTiet(HoaDonChiTiet hdct)
        {
            _DBcontext.HoaDonChiTiets.Remove(hdct);
            _DBcontext.SaveChanges();
            return true;
        }

        public List<HoaDonChiTiet> getHoaDonChiTietFromDB()
        {
            _lstHoaDonChiTiet = _DBcontext.HoaDonChiTiets.ToList();
            return _lstHoaDonChiTiet;
        }

        public bool updateHoaDonChiTiet(HoaDonChiTiet hdct)
        {
            _DBcontext.HoaDonChiTiets.Update(hdct);
            _DBcontext.SaveChanges();
            return true;
        }
    }
}
