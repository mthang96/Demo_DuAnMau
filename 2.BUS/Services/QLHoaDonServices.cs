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
    public class QLHoaDonServices : IQLHoaDonServices
    {
        private IHoaDonServices _IHoaDonServices;
        private List<HoaDon> _lstHoaDon;
        public QLHoaDonServices()
        {
            _IHoaDonServices = new HoaDonServices();
            _lstHoaDon = new List<HoaDon>();
        }
        public bool addHoaDon(HoaDon HoaDon)
        {
            _IHoaDonServices.addHoaDon(HoaDon);
            return true;
        }

        public bool deleteHoaDon(HoaDon HoaDon)
        {
            _IHoaDonServices.deleteHoaDon(HoaDon);
            return true;
        }


        public List<HoaDon> getHoaDontFromDB()
        {
            _lstHoaDon = _IHoaDonServices.getHoaDontFromDB();
            return _lstHoaDon;
        }

        public bool updateHoaDon(HoaDon HoaDon)
        {
            _IHoaDonServices.updateHoaDon(HoaDon);
            return true;
        }
    }
}
