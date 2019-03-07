using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMVC.Model
{
    public class ChuDe
    {
        public int Id { set; get; }

        public string Name { set;get;}

        public string Position { set; get; }

        public virtual IEnumerable<Sach> Saches { set; get; }
    }
}
