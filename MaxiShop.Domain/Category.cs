using System.ComponentModel.DataAnnotations;

namespace MaxiShop.Domain
{

    public class Category
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;



    }
}