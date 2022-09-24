using System.ComponentModel.DataAnnotations;

namespace QazandiranBonusCardSystem.DTOs
{
    public class UserCreationDTO
    {
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
    }
}
