using _1.DAL.Models;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLChiTietSPServices
    {
        bool addChiTietSp(ChiTietSp sp);
        bool updateChiTietSp(ChiTietSp sp);
        bool deleteChiTietSp(ChiTietSp sp);
        List<ViewSanPhamChiTiet> getChiTietSPFromDB();
        List<ChiTietSp> getChiTietSPFromDB1();
    }
}
