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
        bool addChiTietSp(CreatCTSPModel ctsp);
        bool updateChiTietSp(UpdateCTSPModel ctsp);
        bool deleteChiTietSp(Guid idctsp);
        List<ViewSanPhamChiTiet> getChiTietSPFromDB();
        List<ChiTietSp> getChiTietSPFromDB1();
        List<ViewChiTietSanPham> getCTSP();
    }
}
