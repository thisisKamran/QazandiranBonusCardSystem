using System;

namespace QazandiranBonusCardSystem.Models.Entities
{
    public class BasketStock:BaseEntity
    {
        public virtual Basket Basket { get; set; }
        public Guid BasketId { get; set; }
        public virtual Stock Stock { get; set; }
        public Guid StockId { get; set; }
        public int Count { get; set; }
        
    }
}
