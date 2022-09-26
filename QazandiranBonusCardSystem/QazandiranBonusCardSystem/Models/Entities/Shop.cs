using System.Collections;

namespace QazandiranBonusCardSystem.Models.Entities
{
    public class Shop : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }

    }
}
