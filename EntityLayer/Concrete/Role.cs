﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Role
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public ICollection<UserRole> Roles { get; set; }

    }
}
