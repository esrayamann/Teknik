using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknik
{
    public class Rol
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public ICollection<KullaniciRol> Rols { get; set; }

    }
}
