using QazandiranBonusCardSystem.Enums;
using System;
using System.Collections.Generic;

namespace QazandiranBonusCardSystem.Models.Entities
{
    public class Basket : BaseEntity
    {
        public Basket()
        {
            CreatedDate = DateTimeOffset.UtcNow;
            Status = BASKETSTATUS.OPENED;
        }

        public virtual ICollection<BasketStock> BasketStocks { get; set; }

        public virtual User User { get; set; }
        public Guid UserId { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset ClosedDate { get; set; }
        public BASKETSTATUS Status { get; set; }
    }
}
