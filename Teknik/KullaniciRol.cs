using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknik
{
    public class KullaniciRol
    {
        public int Id { get; set; }
        public int KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }

        public int RolId { get; set; }
        public Rol Rol { get; set; }
    }
}
