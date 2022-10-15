using _1.DAL.IDALServices;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.DALServices
{
    public class NSXServices : INSXServices
    {
        private FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context _DBcontext;
        private List<Nsx> _lstNSX;
        public NSXServices()
        {
            _DBcontext = new FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context();
            _lstNSX = new List<Nsx>();
        }

        public List<Nsx> getNSXFromDB()
        {
            _lstNSX = _DBcontext.Nsxes.ToList();
            return _lstNSX;
        }
    }
}
