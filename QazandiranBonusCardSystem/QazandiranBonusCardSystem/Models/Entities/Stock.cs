using System;
using System.Collections;
using System.Collections.Generic;

namespace QazandiranBonusCardSystem.Models.Entities
{
    public class Stock : BaseEntity
    {
        public virtual Shop Shop { get; set; }
        public Guid ShopId { get; set; }
        public virtual Product Product { get; set; }
        public Guid ProductId { get; set; }
        public Decimal Price { get; set; }
        public virtual ICollection<BasketStock> BasketStocks { get; set; }
        
    }
}
