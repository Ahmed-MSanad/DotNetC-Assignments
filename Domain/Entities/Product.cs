namespace Domain.Entities
{
    public class Product : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public decimal Price { get; set; }

        public int BrandId { get; set; } // Brand Foreign Key
        public ProductBrand ProductBrand { get; set; } // Brand Navigational Property

        public int TypeId { get; set; } // Type Foreign Key
        public ProductType ProductType { get; set; } // Type Navigational Property
    }
}
