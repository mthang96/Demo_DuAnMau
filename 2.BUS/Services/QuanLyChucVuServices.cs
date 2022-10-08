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
    public class QuanLyChucVuServices : IQuanLyChucVuServices
    {
        private IChucVuServices _IChucVuServices;
        private List<ChucVu> _lstChucVu;
        public QuanLyChucVuServices()
        {
            _IChucVuServices = new ChucVuServices();
            _lstChucVu = new List<ChucVu>();
        }
        public bool addChucVu(ChucVu chucVu)
        {
            _IChucVuServices.addChucVu(chucVu);
            return true;
        }

        public bool deleteChucVu(ChucVu chucVu)
        {
            _IChucVuServices.deleteChucVu(chucVu);
            return true;
        }

        public List<ChucVu> getChucVusFromDB()
        {
            _lstChucVu = _IChucVuServices.getChucVusFromDB();
            return _lstChucVu;
        }

        public bool updateChucVu(ChucVu chucVu)
        {
            _IChucVuServices.updateChucVu(chucVu);
            return true;
        }
    }
}
