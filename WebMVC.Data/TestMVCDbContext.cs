using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using WebMVC.Model;

namespace WebMVC.Data
{
    public class TestMVCDbContext:DbContext
    {
        public TestMVCDbContext():base("LibraryDbContext")
        {

        }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<ChuDe> ChuDes { get; set; }
        public DbSet<DocGia> DocGias { get; set; }
        public DbSet<HopDong> HopDongs { get; set; }
        public DbSet<MuonSach> MuonSaches { get; set; }
        public DbSet<NhaXuatBan> NhaXuatBans { get; set; }
        public DbSet<Sach> Saches { get; set; }
        public DbSet<Tacgia> Tacgias { get; set; }

    }
}
