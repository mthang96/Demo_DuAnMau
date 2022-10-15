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
    public class QLDongSPServices : IQLDongSPServices
    {
        private IDongSPServices _IDongSPServices;
        private List<DongSp> _lstDongSP;
        public QLDongSPServices() 
        {
            _IDongSPServices = new DongSPServices();
            _lstDongSP = new List<DongSp>();
        }

        public List<DongSp> getDongSpFromDB()
        {
            _lstDongSP = _IDongSPServices.getDongSpFromDB();
            return _lstDongSP;
        }
    }
}
