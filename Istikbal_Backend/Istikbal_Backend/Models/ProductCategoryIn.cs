namespace Istikbal_Backend.Models
{
    public class ProductCategoryIn
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CategoryInId { get; set; }
        public CategoryIn CategoryIn { get; set; }
        public Product Product { get; set; }
    }
}
