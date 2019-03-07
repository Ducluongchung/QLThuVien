using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMVC.Model
{
    public class DocGia
    {
        public int Id { set; get; }

        public string Name { set; get; }

        public DateTime BirthDate { set; get; }

        public string Sex { set; get; }

        public string Address { set; get; }

        public string National { set; get; }

        public string PhoneNumber { set; get; }

        public string Email { set; get; }

        public virtual IEnumerable<MuonSach> MuonSaches { set; get; }
    }
}
