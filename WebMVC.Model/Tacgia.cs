using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMVC.Model
{
    public class Tacgia
    {
        public int Id { set; get; }

        public string Name { set; get; }

        public DateTime BirthDate { set; get; }

        public string Address { set; get; }

        public string National { set; get; }

        public virtual IEnumerable<Sach> Saches { set; get; }
    }
}
