using System.ComponentModel.DataAnnotations;

namespace CoreApp102.Mvc.DTOs
{
    public class CategoryDto
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "{0} alani gereklidir.")]
        public string Name { get; set; }
    }
}
