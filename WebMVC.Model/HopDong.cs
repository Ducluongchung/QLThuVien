using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMVC.Model
{
    public class HopDong
    {
        public int Id { set; get; }

        public DateTime StartTime { set; get; }

        public DateTime EndTime { set; get; }

        public decimal Luong { set; get; }

        public virtual IEnumerable<NhanVien> NhanViens { set; get; }
    }
}
