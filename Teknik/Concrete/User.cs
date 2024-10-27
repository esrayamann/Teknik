﻿using System.ComponentModel.DataAnnotations;

namespace Teknik.Concrete
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
