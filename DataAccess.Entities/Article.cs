using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities;

public class Article: IEntity<int>
{
    [Key]
    public int Id { get; set; }
    //сделать проверку на шаблон
    [Required]
    [RegularExpression(@"\d{4}-\d{4}", ErrorMessage = "Формат артикула должен быть 'хххх-хххх', где х - цифры.")]
    public string ArticleCode { get; set; }
    [Required]
    public ICollection<Product> Products { get; set; }
    [Required]
    public int ProductModelId { get; set; }
    [Required]
    public ProductModel ProductModel { get; set; }
}