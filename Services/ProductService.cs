using ShopInterface1.Models;

namespace ShopInterface1.Services
{
    public class ProductService
    {
        private readonly List<Product> _products = new()
        {
            new Product
            {
                Id = 1,
                Name = "Nike Air Max",
                Description = "Giày thể thao Nike Air Max phong cách hiện đại.",
                Price = 2490000,
                ImageUrl = "https://placehold.co/600x400?text=Nike+Air+Max"
            },

            new Product
            {
                Id = 2,
                Name = "Adidas Ultraboost",
                Description = "Giày chạy bộ Adidas với đệm Boost êm ái.",
                Price = 3200000,
                ImageUrl = "https://placehold.co/600x400?text=Adidas+Ultraboost"
            },

            new Product
            {
                Id = 3,
                Name = "New Balance 530",
                Description = "Thiết kế retro, phù hợp sử dụng hàng ngày.",
                Price = 2100000,
                ImageUrl = "https://placehold.co/600x400?text=New+Balance+530"
            },

            new Product
            {
                Id = 4,
                Name = "Nike Dunk Low",
                Description = "Nike Dunk Low với thiết kế cổ điển.",
                Price = 2890000,
                ImageUrl = "https://placehold.co/600x400?text=Nike+Dunk+Low"
            },

            new Product
            {
                Id = 5,
                Name = "Adidas Samba",
                Description = "Một trong những thiết kế kinh điển của Adidas.",
                Price = 2500000,
                ImageUrl = "https://placehold.co/600x400?text=Adidas+Samba"
            },

            new Product
            {
                Id = 6,
                Name = "New Balance 2002R",
                Description = "Sneaker lifestyle với thiết kế cao cấp.",
                Price = 3500000,
                ImageUrl = "https://placehold.co/600x400?text=NB+2002R"
            },

                new Product
            {
                Id = 7,
                Name = "Nike Air Force 1",
                Description = "Thiết kế kinh điển phù hợp sử dụng hàng ngày.",
                Price = 2800000,
                ImageUrl = "https://placehold.co/600x400?text=Nike+Air+Force+1"
            },
            new Product
            {
                Id = 8,
                Name = "Adidas Campus 00s",
                Description = "Phong cách retro lấy cảm hứng từ những năm 2000.",
                Price = 2600000,
                ImageUrl = "https://placehold.co/600x400?text=Adidas+Campus"
            },
            new Product
            {
                Id = 9,
                Name = "New Balance 9060",
                Description = "Thiết kế chunky hiện đại và thoải mái.",
                Price = 3900000,
                ImageUrl = "https://placehold.co/600x400?text=NB+9060"
            },
            new Product
            {
                Id = 10,
                Name = "Nike Vomero 5",
                Description = "Sneaker phong cách running hiện đại.",
                Price = 4200000,
                ImageUrl = "https://placehold.co/600x400?text=Nike+Vomero+5"
            },
            new Product
            {
                Id = 11,
                Name = "Adidas Gazelle",
                Description = "Một thiết kế cổ điển của Adidas.",
                Price = 2400000,
                ImageUrl = "https://placehold.co/600x400?text=Adidas+Gazelle"
            },
            new Product
            {
                Id = 12,
                Name = "New Balance 1906R",
                Description = "Thiết kế running retro với công nghệ hiện đại.",
                Price = 3800000,
                ImageUrl = "https://placehold.co/600x400?text=NB+1906R"
            },
            new Product
            {
                Id = 13,
                Name = "Nike P-6000",
                Description = "Phong cách Y2K lấy cảm hứng từ giày chạy bộ.",
                Price = 2900000,
                ImageUrl = "https://placehold.co/600x400?text=Nike+P6000"
            },
            new Product
            {
                Id = 14,
                Name = "Adidas Handball Spezial",
                Description = "Sneaker retro với kiểu dáng thấp cổ.",
                Price = 2700000,
                ImageUrl = "https://placehold.co/600x400?text=Adidas+Spezial"
            },
            new Product
            {
                Id = 15,
                Name = "New Balance 574",
                Description = "Một trong những dòng sneaker biểu tượng của New Balance.",
                Price = 2300000,
                ImageUrl = "https://placehold.co/600x400?text=NB+574"
            },
            new Product
            {
                Id = 16,
                Name = "Nike Cortez",
                Description = "Thiết kế Nike cổ điển từ thập niên 70.",
                Price = 2500000,
                ImageUrl = "https://placehold.co/600x400?text=Nike+Cortez"
            },
            new Product
            {
                Id = 17,
                Name = "Adidas SL 72",
                Description = "Thiết kế retro nhẹ nhàng dành cho lifestyle.",
                Price = 2300000,
                ImageUrl = "https://placehold.co/600x400?text=Adidas+SL72"
            },
            new Product
            {
                Id = 17,
                Name = "Nasser SL 72",
                Description = "Thiết kế đen nhẹ nhàng dành cho chủ.",
                Price = 2300000,
                ImageUrl = "https://placehold.co/600x400?text=Adidas+SL72"
            },
            new Product
            {
                Id = 17,
                Name = "Tust TLK",
                Description = "Thiết kế xoắn nhẹ nhàng cho cảm giác khác biệt.",
                Price = 2300000,
                ImageUrl = "https://placehold.co/600x400?text=Adidas+SL72"
            },
            new Product
            {
                Id = 18,
                Name = "New Balance 327",
                Description = "Thiết kế lấy cảm hứng từ giày chạy bộ cổ điển.",
                Price = 2600000,
                ImageUrl = "https://placehold.co/600x400?text=NB+327"
            }

        };

        public List<Product> GetProducts()
        {
            return _products;
        }

        public Product? GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
    }
}