namespace Model
{
    public abstract class Account : PersistableObject
    {
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public string Name { get; set; }
    }
}
