using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities;

public class ProductModel : IEntity<int>
{
    [Key]
    public int Id { get; set; }
    [Required] 
    public string Name { get; set; }
    [Required]
    public ICollection<Article> Articles { get; set; }
}