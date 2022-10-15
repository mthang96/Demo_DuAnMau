using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IDALServices
{
    public interface IChiTietSPServices
    {
        List<ChiTietSp> getChiTietSPFromDB();
        bool addSP(ChiTietSp sp);
        bool updateSP(ChiTietSp sp);
        bool deleteSP(ChiTietSp sp);
    }
}
