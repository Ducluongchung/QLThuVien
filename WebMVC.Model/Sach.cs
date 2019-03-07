using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMVC.Model
{
    public class Sach
    {
        public int Id { set; get; }

        public string Name { set; get; }

        public int IdTacGia { set; get; }

        public int IdNXB { set; get; }

        public int IdChuDe { set; get; }

        public int SoLuong { set; get; }

        public virtual IEnumerable<MuonSach> MuonSaches { set; get; }

        [ForeignKey("IdChuDe")]
        public virtual ChuDe ChuDe { set; get; }

        [ForeignKey("IdNXB")]
        public virtual NhaXuatBan NhaXuatBan { set; get; }

        [ForeignKey("IdTacGia")]
        public virtual Tacgia Tacgia { set; get; }
    }
}
