namespace Teknik
{
    public partial class Servis_Kayıt
    {
        public int SicilNo { get; set; }
        public string Ad {  get; set; }
        public string Soyad {  get; set; }
        public int TelNo {  get; set; }
        public string Email {  get; set; }
        public string Arıza { get; set; }
        public string Birim { get; set; }
        public string Bölüm { get; set; }
        public DateTime Tarih { get; set; }=DateTime.Now;
    }
}
