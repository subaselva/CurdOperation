using System.ComponentModel.DataAnnotations;

namespace CurdProject.Model
{
    public class Product   //Property,model,Entity prop tab
    {
        [Key]
        public int Id { get; set; }
        [Required]  
        public string Name { get; set; } = null!;  // not null
        public string? Description { get; set; }  // null
        public int Price { get; set; }
        public int Quantity { get; set; } 
    }
}
