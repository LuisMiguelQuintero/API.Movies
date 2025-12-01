using System.ComponentModel.DataAnnotations;

namespace API.Movies.DLA.Models
{
    public class Category: AuditBase
    {
        [Required] //Indica que este tampoco es obligatorio
        [Display(Name = "Nombre de la categoria")] // me sirve para personalizar el nombre que se muestra en las vistas
        public string Name { get; set; }

    }
}

