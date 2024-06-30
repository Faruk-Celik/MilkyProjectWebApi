namespace MilkyProject.WebUI.Dtos.ProductDto
{
    public class ResultProductWithCategoryDto
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public decimal oldPrice { get; set; }
        public decimal newPrice { get; set; }
        public string productImageUrl { get; set; }
        public bool status { get; set; }
        public int? categoryId { get; set; }
        public Category category { get; set; }
        public class Category
        {

            public string categoryName { get; set; }

        }
    }
}
