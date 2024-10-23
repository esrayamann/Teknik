namespace Teknik.Concrete
{
    public class Role
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public ICollection<UserRole> Roles { get; set; }

    }
}
