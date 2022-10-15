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
    public class QLMauSacServices : IQLMauSacServices
    {
        private IMauSacServices _IMauSacServices;
        private List<MauSac> _lstMauSac;
        public QLMauSacServices()
        {
            _IMauSacServices = new MauSacServices();
            _lstMauSac = new List<MauSac>();
        }

        public List<MauSac> getMauSacFromDB()
        {
            _lstMauSac = _IMauSacServices.getMauSacFromDB();
            return _lstMauSac;
        }
    }
}
