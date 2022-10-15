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
    public class QLHoaDonChiTietServices : IQLHoaDonChiTietServices
    {
        private IHoaDonChiTietServices _IHoaDonChiTietServices;
        private IHoaDonServices _IHoaDonServices;
        private INSXServices _INSXServices;
        private IDongSPServices _IDongSPServices;
        private IMauSacServices _IMauSacServices;
        private IQLChiTietSPServices _IChiTietSPServices;
        private List<ViewSanPhamChiTiet> _lstHoaDonChiTietByID;
        private List<ViewHoaDonChiTiet> _lstHoaDonChiTiet1;
        private List<HoaDonChiTiet> _lstHoaDonChiTiet;
        private ISanPhamServices _ISanPhamServices;
        public QLHoaDonChiTietServices()
        {
            _IHoaDonChiTietServices = new HoaDonChiTietServices();
            _IHoaDonServices = new HoaDonServices();
            _INSXServices = new NSXServices();
            _IDongSPServices = new DongSPServices();
            _IMauSacServices = new MauSacServices();
            _lstHoaDonChiTietByID = new List<ViewSanPhamChiTiet>();
            _lstHoaDonChiTiet = new List<HoaDonChiTiet>();
            _IChiTietSPServices= new QLChiTietSPServices();
            _lstHoaDonChiTiet1 = new List<ViewHoaDonChiTiet>();
            _ISanPhamServices = new SanPhamServices();
        }

        public bool addHoaDonChiTiet(HoaDonChiTiet hdct)
        {
            _IHoaDonChiTietServices.addHoaDonChiTiet(hdct);
            return true;
        }

        public bool deleteHoaDonChiTiet(HoaDonChiTiet hdct)
        {
            _IHoaDonChiTietServices.deleteHoaDonChiTiet(hdct);
            return true;
        }

        public List<ViewHoaDonChiTiet> getHoaDonChiTietById(Guid idhoadon)
        {
            _lstHoaDonChiTiet1 = (from a in _IHoaDonChiTietServices.getHoaDonChiTietFromDB()
                                     join b in _IChiTietSPServices.getChiTietSPFromDB1() on a.IdChiTietSp equals b.Id
                                     join f in _ISanPhamServices.getNhanViensFromDB() on b.IdSp equals f.Id
                                     join c in _IMauSacServices.getMauSacFromDB() on b.IdMauSac equals c.Id
                                     join d in _INSXServices.getNSXFromDB() on b.IdNsx equals d.Id
                                     join e in _IDongSPServices.getDongSpFromDB() on b.IdDongSp equals e.Id
                                     where a.IdHoaDon == idhoadon
                                     select new ViewHoaDonChiTiet
                                     {
                                         Id = a.IdChiTietSp,
                                         MaSP = f.Ma,
                                         TenSP = f.Ten,
                                         DongSp = e.Ten,
                                         Nsx = d.Ten,
                                         MauSac = c.Ten,
                                         SoLuong = a.SoLuong,
                                         DonGia = b.GiaBan,
                                         Tong = a.SoLuong * b.GiaBan
                                     }).ToList();


            return _lstHoaDonChiTiet1;
        }

        public List<HoaDonChiTiet> getHoaDonChiTietFromDB()
        {
            _lstHoaDonChiTiet = _IHoaDonChiTietServices.getHoaDonChiTietFromDB();
            return _lstHoaDonChiTiet;
        }

        public bool updateHoaDonChiTiet(HoaDonChiTiet hdct)
        {
            _IHoaDonChiTietServices.updateHoaDonChiTiet(hdct);
            return true;
        }
    }
}
