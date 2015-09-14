using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Abstract;
using Persistence.Entities.Base;

namespace Persistence.Entities
{
    public class DiliveryAddressEntity : PersistableEntity, IDeliveryAddress
    {
        public string Address { get; set; }
        public IAccount Account { get; set; }
    }
}
