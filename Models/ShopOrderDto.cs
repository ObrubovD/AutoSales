using System.ComponentModel.DataAnnotations;

namespace AutoSales.Data.Models
{
    public class ShopOrderDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Поле должно содержать от 3 символов")]
        public string? Name { get; set; }

        [StringLength(15, MinimumLength = 3, ErrorMessage = "Поле должно быть установлено")]
        [Required(ErrorMessage = "Поле должно содержать от 3 символов")]
        public string? SurName { get; set; }

        [StringLength(11, MinimumLength = 3, ErrorMessage = "Поле должно быть установлено")]
        [Required(ErrorMessage = "Поле должно содержать от 3 символов")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Поле должно содержать от 3 символов")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Поле должно содержать от 3 символов")]
        public string? Email { get; set; }

    }
}
