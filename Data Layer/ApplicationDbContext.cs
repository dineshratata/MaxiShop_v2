using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data_Layer
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
    }
}