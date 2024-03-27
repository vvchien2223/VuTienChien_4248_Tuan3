using VuTienChien_4248_Tuan3.Models;

namespace VuTienChien_4248_Tuan3.Repository
{
	public interface IProductRepository
	{
		Task<IEnumerable<Product>> GetAllAsync();
		Task<Product> GetByIdAsync(int id);
		Task AddAsync(Product product);
		Task UpdateAsync(Product product);
		Task DeleteAsync(int id);
	}
}
