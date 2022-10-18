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
        private List<ViewChiTietSanPham> _lstCTSanPham;
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
            _lstCTSanPham = new List<ViewChiTietSanPham>();
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
        public List<ViewChiTietSanPham> getCTSP()
        {
            _lstCTSanPham = (from a in _IChiTietSPServices.getChiTietSPFromDB()
                             join b in _ISanPhamServices.getNhanViensFromDB() on a.IdSp equals b.Id
                             select new ViewChiTietSanPham
                             {
                                 IdCTSP = a.Id,
                                 TenSP = b.Ten,
                                 IdSP = a.IdSp,
                                 Mota = a.MoTa,
                                 SoLuongTon = a.SoLuongTon,
                                 GiaNhap = a.GiaNhap,
                                 GiaBan = a.GiaBan,
                                 Total = a.SoLuongTon * a.GiaNhap,
                             }).ToList();
            return _lstCTSanPham;
        }
        public List<ChiTietSp> getChiTietSPFromDB1()
        {
            _lstChiTietSp1 = _IChiTietSPServices.getChiTietSPFromDB();
            return _lstChiTietSp1;
        }
        public bool addChiTietSp(CreatCTSPModel ctsp)
        {
            ChiTietSp ctsps = new ChiTietSp()
            {
                IdSp = ctsp.IdSp,
                MoTa = ctsp.MoTa,
                SoLuongTon = ctsp.SoLuongTon,
                GiaNhap = ctsp.GiaNhap,
                GiaBan=ctsp.GiaBan,
            };
            _IChiTietSPServices.addSP(ctsps);
            return true;


        }

        public bool deleteChiTietSp(Guid idctsp)
        {
            var x = _IChiTietSPServices.getChiTietSPFromDB().FirstOrDefault(p => p.Id == idctsp);
            _IChiTietSPServices.deleteSP(x);
            return true;
        }


        public bool updateChiTietSp(UpdateCTSPModel ctsp)
        {
            var x = _IChiTietSPServices.getChiTietSPFromDB().FirstOrDefault(p => p.Id == ctsp.IdCTSP);
            x.IdSp = ctsp.IdSp;
            x.MoTa = ctsp.MoTa;
            x.SoLuongTon = ctsp.SoLuongTon;
            x.GiaNhap = ctsp.GiaNhap;
            x.GiaBan = ctsp.GiaBan;
            _IChiTietSPServices.updateSP(x);
            return true;
        }
    }
}
