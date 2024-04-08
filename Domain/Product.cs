using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^\d{4}-\d{4}$", ErrorMessage = "Формат артикула должен быть 1234-5678")]
        public string ArticleNumber { get; set; }
        [Required]
        public string ModelName { get; set; }
        
    }
}
