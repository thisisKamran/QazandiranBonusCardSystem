using System;
using System.Collections;
using System.Collections.Generic;

namespace QazandiranBonusCardSystem.Models.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public Guid BasketId { get; set; }
        public virtual ICollection<Basket> Baskets { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }

    }
}
