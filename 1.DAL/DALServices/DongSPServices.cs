using _1.DAL.IDALServices;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.DALServices
{
    public class DongSPServices : IDongSPServices
    {
        private FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context _DBcontext;
        private List<DongSp> _lstDongSp;
        public DongSPServices()
        {
            _DBcontext = new FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context();
            _lstDongSp = new List<DongSp>();
        }

        public List<DongSp> getDongSpFromDB()
        {
            _lstDongSp = _DBcontext.DongSps.ToList();
            return _lstDongSp;
        }
    }
}
