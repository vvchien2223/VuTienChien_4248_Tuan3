namespace VuTienChien_4248_Tuan3.Models
{
	public class ImageProduct
	{
		public int Id { get; set; }
		public string? Url { get; set; }
		public int ProductId { get; set; }
		public Product? Product { get; set; }
	}
}
