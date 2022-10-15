﻿using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IQLSanPhamService
    {
        bool addSanPham(SanPham sp);
        bool updateSanPham(SanPham sp);
        bool deleteSanPham(SanPham sp);
        List<SanPham> getSanPhamFromDB();
    }
}
