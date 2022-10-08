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
    public class QuanLyNhanVienServices : IQuanLyNhanVienServices
    {
        private INhanVienServices _INhanVienServices;
        private ICuaHangServices _ICuaHangServices;
        private IChucVuServices _IChucVuServices;
        private List<NhanVien> _lstNhanVien;
        private List<ViewNhanVien> _lstViewNhanVien;
        public QuanLyNhanVienServices()
        {
            _INhanVienServices = new NhanVienServices();
            _ICuaHangServices = new CuaHangServices();
            _IChucVuServices = new ChucVuServices();
            _lstNhanVien = new List<NhanVien>();
        }
        public bool addNhanVien(NhanVien nhanVien)
        {
            _INhanVienServices.addNhanVien(nhanVien);
            return true;
        }

        public bool deleteNhanVien(NhanVien nhanVien)
        {
            _INhanVienServices.deleteNhanVien(nhanVien);
            return true;
        }

        public List<NhanVien> getNhanViensFromDB()
        {
            _lstNhanVien = _INhanVienServices.getNhanViensFromDB();
            return _lstNhanVien;
        }

        public List<ViewNhanVien> getViewNhanViens()
        {
            _lstViewNhanVien = (from nv in getNhanViensFromDB()
                                join ch in _ICuaHangServices.getCuaHangsFromDB() on nv.IdCh equals ch.Id
                                join cv in _IChucVuServices.getChucVusFromDB() on nv.IdCv equals cv.Id
                                select new ViewNhanVien
                                {
                                    nhanVien = nv,
                                    cuaHang = ch,
                                    chucVu = cv,
                                }).ToList();
            return _lstViewNhanVien;
        }

        public bool updateNhanVien(NhanVien nhanVien)
        {
            _INhanVienServices.updateNhanVien(nhanVien);
            return true;
        }
    }
}
