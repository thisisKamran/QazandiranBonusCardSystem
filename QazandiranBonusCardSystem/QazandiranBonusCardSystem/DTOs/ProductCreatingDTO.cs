using System.ComponentModel.DataAnnotations;

namespace QazandiranBonusCardSystem.DTOs
{
    public class ProductCreatingDTO
    {
        [Required]
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
