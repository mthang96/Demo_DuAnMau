using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLHoaDonServices
    {
        bool addHoaDon(HoaDon hdct);
        bool updateHoaDon(HoaDon hdct);
        bool deleteHoaDon(HoaDon hdct);
        List<HoaDon> getHoaDontFromDB();
    }
}
