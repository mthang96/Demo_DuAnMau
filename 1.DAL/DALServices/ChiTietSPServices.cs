using _1.DAL.IDALServices;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.DALServices
{
    public class ChiTietSPServices : IChiTietSPServices
    {
        private FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context _DBcontext;
        private List<ChiTietSp> _lstChiTietSp;
        public ChiTietSPServices()
        {
            _DBcontext = new FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context();
            _lstChiTietSp = new List<ChiTietSp>();
        }

        public List<ChiTietSp> getChiTietSPFromDB()
        {
            _lstChiTietSp = _DBcontext.ChiTietSps.ToList();
            return _lstChiTietSp;
        }
        public bool addSP(ChiTietSp sp)
        {
            _DBcontext.ChiTietSps.Add(sp);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool deleteSP(ChiTietSp sp)
        {
            _DBcontext.ChiTietSps.Remove(sp);
            _DBcontext.SaveChanges();
            return true;
        }
        public bool updateSP(ChiTietSp sp)
        {
            _DBcontext.ChiTietSps.Update(sp);
            _DBcontext.SaveChanges();
            return true;
        }
    }
}
