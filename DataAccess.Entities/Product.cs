using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

namespace DataAccess.Entities
{
    public class Product: IEntity<int>
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Цена не может быть ниже нуля.")]
        public decimal Price { get; set; }
        [Required]
        public int ArticleId { get; set; }
        public Article Article{ get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Остаток не может быть ниже нуля.")]
        public int Quantity { get; set; }
        [Required]
        public int StoreId { get; set; }
        [Required]
        public Store Store { get; set; }

    }
}
