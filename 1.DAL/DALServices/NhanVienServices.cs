using _1.DAL.IDALServices;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.DALServices
{
    public class NhanVienServices : INhanVienServices
    {
        private FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context _DBcontext;
        private List<NhanVien> _lstNhanVien;

        public NhanVienServices()
        {
            _DBcontext = new FINALASS_FPOLYSHOP_FA22_SOF205__SOF2041Context();
            _lstNhanVien = new List<NhanVien>();
        }
        public bool addNhanVien(NhanVien nhanVien)
        {
            _DBcontext.NhanViens.Add(nhanVien);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool deleteNhanVien(NhanVien nhanVien)
        {
            _DBcontext.NhanViens.Remove(nhanVien);
            _DBcontext.SaveChanges();
            return true;
        }

        public List<NhanVien> getNhanViensFromDB()
        {
            _lstNhanVien = _DBcontext.NhanViens.ToList();
            return _lstNhanVien;
        }

        public bool updateNhanVien(NhanVien nhanVien)
        {
            _DBcontext.NhanViens.Update(nhanVien);
            _DBcontext.SaveChanges();
            return true;
        }
    }
}
