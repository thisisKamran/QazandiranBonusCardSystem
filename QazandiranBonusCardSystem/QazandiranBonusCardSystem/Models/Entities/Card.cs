using System;
using System.ComponentModel.DataAnnotations;

namespace QazandiranBonusCardSystem.Models.Entities
{
    public class Card : BaseEntity
    {
        public Card()
        {
            Expire = DateTimeOffset.UtcNow.AddYears(3);
            Code = Guid.NewGuid();
        }
        public Guid Code { get; set; }
        public DateTimeOffset Expire { get; set; }
        public virtual User User { get; set; }
        public Guid UserId { get; set; }
    }
}
