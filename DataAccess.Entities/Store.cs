using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities;

public class Store : IEntity<int>
{
    [Key]
    public int Id { get; set; }
    [Required]
    [RegularExpression("^[a-zA-Z]\\d{3}$", ErrorMessage = "StoreCode должен соответствовать шаблону 'хууу', где х - буквенный символ (латиница), у - цифры.")]
    public string StoreCode { get; set; }
    [Required]
    public ICollection<Product> Products { get; set; }
}