﻿namespace Teknik
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public ICollection<KullaniciRol> KullaniciRols { get; set; }
    }
}