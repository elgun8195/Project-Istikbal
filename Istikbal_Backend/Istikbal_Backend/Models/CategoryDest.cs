namespace Istikbal_Backend.Models
{
    public class CategoryDest
    {
        public int Id { get; set; }
        public int CategoryInId { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public CategoryIn CategoryIn { get; set; }
    }
}
