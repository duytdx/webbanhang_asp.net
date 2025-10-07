namespace Shopping_Tutorial.Models.ViewModels
{
    public class ProductDetailsViewModel
    {
        public ProductModel ProductDetails { get; set; }
        public List<RatingModel> RatingList { get; set; }
        
        // Properties for rating form
        public string Name { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
    }
}