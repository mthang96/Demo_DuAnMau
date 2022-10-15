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
    public class QLSanPhamService : IQLSanPhamService
    {
        private  ISanPhamServices _ISanPhamServices;
        private  List<SanPham> _lstSanPham;
        public QLSanPhamService()
        {
            _ISanPhamServices= new SanPhamServices();
            _lstSanPham = new List<SanPham>();
        }

        public bool addSanPham(SanPham sp)
        {
            _ISanPhamServices.addSP(sp);
            return true;


        }

        public bool deleteSanPham(SanPham sp)
        {
            _ISanPhamServices.deleteSP(sp);
            return true ;
        }

        public List<SanPham> getSanPhamFromDB()
        {
            _lstSanPham = _ISanPhamServices.getNhanViensFromDB();
            return _lstSanPham;
        }

        public bool updateSanPham(SanPham sp)
        {
            _ISanPhamServices.updateSP(sp);
            return true;
        }
    }
}
