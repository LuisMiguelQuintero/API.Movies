using API.Movies.DLA.Models;

namespace API.Movies.Repository.IRepository
{
    public interface ICategoryRepository
    {
        Task<ICollection<Category>> GetCategoriesAsync();// Me retorna una lista de categorias

        Task<Category> GetCategoryAsync(int id);// Me retorna una categoria por su Id

        Task<bool> CategoryExistsByIdAsync(int id);// Verifica si una categoria existe por su Id
        Task<bool> CategoryExistsByNameAsync(string name);// Verifica si una categoria existe por su Nombre

        Task<bool> CreateCategoryAsync(Category category);// Crea una nueva categoria
        
        Task<bool> UpdateCategoryAsync(Category category);// Actualiza una categoria existente

        Task<bool> DeleteCategoryAsync(int id);// Elimina una categoria existente por Id

    }
}
