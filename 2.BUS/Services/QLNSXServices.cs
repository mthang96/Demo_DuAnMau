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
    public class QLNSXServices : IQLNSXServices
    {
        private INSXServices _IGioHangServices;
        private List<Nsx> _lstNSX;
        public QLNSXServices()
        {
            _IGioHangServices = new NSXServices();
            _lstNSX = new List<Nsx>();
        }

        public List<Nsx> getNSXFromDB()
        {
            _lstNSX = _IGioHangServices.getNSXFromDB();
            return _lstNSX;
        }
    }
}
