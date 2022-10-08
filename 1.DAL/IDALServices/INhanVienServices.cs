﻿using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IDALServices
{
    public interface INhanVienServices
    {
        bool addNhanVien(NhanVien nhanVien);
        bool updateNhanVien(NhanVien nhanVien);
        bool deleteNhanVien(NhanVien nhanVien);
        List<NhanVien> getNhanViensFromDB();
    }
}
