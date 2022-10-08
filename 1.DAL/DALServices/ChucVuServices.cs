using _1.DAL.IDALServices;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.DALServices
{
    public class ChucVuServices : IChucVuServices
    {
        private FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context _DBcontext;
        private List<ChucVu> _lstChucVu;
        public ChucVuServices()
        {
            _DBcontext = new FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context();
            _lstChucVu = new List<ChucVu>();

        }
        public bool addChucVu(ChucVu chucVu)
        {
            _DBcontext.ChucVus.Add(chucVu);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool deleteChucVu(ChucVu chucVu)
        {
            _DBcontext.ChucVus.Remove(chucVu);
            _DBcontext.SaveChanges();
            return true;
        }

        public List<ChucVu> getChucVusFromDB()
        {
            _lstChucVu = _DBcontext.ChucVus.ToList();
            return _lstChucVu;
        }

        public bool updateChucVu(ChucVu chucVu)
        {
            _DBcontext.ChucVus.Update(chucVu);
            _DBcontext.SaveChanges();
            return true;
        }
    }
}
