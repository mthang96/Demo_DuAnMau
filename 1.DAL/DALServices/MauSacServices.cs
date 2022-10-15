using _1.DAL.IDALServices;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.DALServices
{
    public class MauSacServices : IMauSacServices
    {
        private FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context _DBcontext;
        private List<MauSac> _lstMauSac;
        public MauSacServices()
        {
            _DBcontext = new FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context();
            _lstMauSac = new List<MauSac>();
        }

        public List<MauSac> getMauSacFromDB()
        {
            _lstMauSac = _DBcontext.MauSacs.ToList();
            return _lstMauSac;
        }
    }
}
