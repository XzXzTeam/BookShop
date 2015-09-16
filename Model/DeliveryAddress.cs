#region usings

using AbstractModel;

#endregion

namespace Model
{
    public class DeliveryAddress : PersistableObject
    {
        public string Address { get; set; }
        public Account Account { get; set; }
    }
}