namespace Model
{
    public  class Book : PersistableObject
    {
        public string Name { get; set; }
        public string Publisher { get; set; } 
        public int Year { get; set; }
    }
}
