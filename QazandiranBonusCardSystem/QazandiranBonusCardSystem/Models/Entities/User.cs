using System.Collections.Generic;

namespace QazandiranBonusCardSystem.Models.Entities
{
    public class User : BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public virtual ICollection<Card> Cards { get; set; }
        public  virtual ICollection<Basket> Baskets  { get; set; }
        
    }
}
