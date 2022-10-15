using _1.DAL.DALServices;
using _1.DAL.IDALServices;
using _1.DAL.Models;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class QLChiTietSPServices : IQLChiTietSPServices
    {
        private IChiTietSPServices _IChiTietSPServices;
        private List<ViewSanPhamChiTiet> _lstChiTietSp;
        private List<ChiTietSp> _lstChiTietSp1;
        private INSXServices _INSXServices;
        private IDongSPServices _IDongSPServices;
        private IMauSacServices _IMauSacServices;
        private ISanPhamServices _ISanPhamServices;
        public QLChiTietSPServices()
        {
            _IChiTietSPServices = new ChiTietSPServices();
            _lstChiTietSp = new List<ViewSanPhamChiTiet>();
            _INSXServices = new NSXServices();
            _IDongSPServices = new DongSPServices();
            _IMauSacServices = new MauSacServices();
            _ISanPhamServices = new SanPhamServices();
            _lstChiTietSp1 = new List<ChiTietSp>();
        }

        public List<ViewSanPhamChiTiet> getChiTietSPFromDB()
        {
            _lstChiTietSp = (from a in _IChiTietSPServices.getChiTietSPFromDB()
                             join e in _ISanPhamServices.getNhanViensFromDB() on a.IdSp equals e.Id
                             join b in _INSXServices.getNSXFromDB() on a.IdNsx equals b.Id
                             join c in _IDongSPServices.getDongSpFromDB() on a.IdDongSp equals c.Id
                             join d in _IMauSacServices.getMauSacFromDB() on a.IdMauSac equals d.Id
                             select new ViewSanPhamChiTiet
                             {
                                 ChiTietSp = a,
                                 DongSp = c,
                                 MauSac = d,
                                 Nsx = b,
                                 SanPham = e,
                             }).ToList();
            return _lstChiTietSp;
        }

        public List<ChiTietSp> getChiTietSPFromDB1()
        {
            _lstChiTietSp1 = _IChiTietSPServices.getChiTietSPFromDB();
            return _lstChiTietSp1;
        }
        public bool addChiTietSp(ChiTietSp sp)
        {
            _IChiTietSPServices.addSP(sp);
            return true;


        }

        public bool deleteChiTietSp(ChiTietSp sp)
        {
            _IChiTietSPServices.deleteSP(sp);
            return true;
        }


        public bool updateChiTietSp(ChiTietSp sp)
        {
            _IChiTietSPServices.updateSP(sp);
            return true;
        }
    }
}
