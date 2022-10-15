using _1.DAL.IDALServices;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.DALServices
{
    public class SanPhamServices : ISanPhamServices
    {
        private FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context _DBcontext;
        private List<SanPham> _lstSanPham;
        public SanPhamServices()
        {
            _DBcontext = new FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context();
            _lstSanPham = new List<SanPham>();
        }

        public bool addSP(SanPham sp)
        {
            _DBcontext.SanPhams.Add(sp);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool deleteSP(SanPham sp)
        {
            _DBcontext.SanPhams.Remove(sp);
            _DBcontext.SaveChanges();
            return true;
        }

        public List<SanPham> getNhanViensFromDB()
        {
            _lstSanPham=_DBcontext.SanPhams.ToList();

            return _lstSanPham;
        }

        public bool updateSP(SanPham sp)
        {
            _DBcontext.SanPhams.Update(sp);
            _DBcontext.SaveChanges();
            return true;
        }
    }
}
