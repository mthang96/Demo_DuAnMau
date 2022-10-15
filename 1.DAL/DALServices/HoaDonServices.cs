using _1.DAL.IDALServices;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.DALServices
{
    public class HoaDonServices : IHoaDonServices
    {
        private FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context _DBcontext;
        private List<HoaDon> _lstHoaDon;
        public HoaDonServices()
        {
            _DBcontext = new FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context();
            _lstHoaDon = new List<HoaDon>();
        }

        public bool addHoaDon(HoaDon hdct)
        {
            _DBcontext.HoaDons.Add(hdct);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool deleteHoaDon(HoaDon hdct)
        {
            _DBcontext.HoaDons.Remove(hdct);
            _DBcontext.SaveChanges();
            return true;
        }

        public List<HoaDon> getHoaDontFromDB()
        {
            _lstHoaDon = _DBcontext.HoaDons.ToList();
            return _lstHoaDon;
        }

        public bool updateHoaDon(HoaDon hdct)
        {
            _DBcontext.HoaDons.Update(hdct);
            _DBcontext.SaveChanges();
            return true;
        }
    }
}
