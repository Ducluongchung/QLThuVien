using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMVC.Model
{
    public class MuonSach
    {
        public int Id { set; get; }

        public int NhanVienId { set; get; }

        public int DocGiaId { set; get; }

        public int SachId { set; get; }

        public DateTime NgayMuon { set; get; }

        public DateTime NgayTra { set; get; }

        public bool Status { set; get; }

        [ForeignKey("SachId")]
        public virtual Sach Sach { set; get; }

        [ForeignKey("DocGiaId")]
        public virtual DocGia DocGia  { set; get; }

        [ForeignKey("NhanVienId")]
        public virtual NhanVien NhanVien { set; get; }
    }
}
