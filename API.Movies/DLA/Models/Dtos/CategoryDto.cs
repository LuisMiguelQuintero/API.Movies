using System.ComponentModel.DataAnnotations;

namespace API.Movies.DLA.Models.Dtos
{
    public class CategoryDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la categoria es obligatorio")]
        [MaxLength(100, ErrorMessage = "El nombre de la categoria no puede exceder los 100 caracteres")]
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }


    }
}
