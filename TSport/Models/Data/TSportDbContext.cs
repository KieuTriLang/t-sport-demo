using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TSport.Models.Data
{
    public class TSportDbContext : IdentityDbContext
    {
        private static Random random = new Random();
        private static string alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private static string[] wordPool = { "pin", "numberless", "industrious", "worried", "cent", "walk", "well-made", "pig", "naive", "thick", "tired", "fix", "hello", "bye", "one", "two", "something", "else", "text", "paragragh", "ten", "three", "love", "you", "anything", "body" };
        private int randomFromTo(int min = 0, int max = 100)
        {
            return random.Next(min, max);
        }
        private string randomSentence(int countOfWord)
        {
            string sentence = string.Empty;
            while (countOfWord > 0)
            {
                sentence += wordPool[randomFromTo(0, wordPool.Length)] + " ";
                countOfWord -= 1;
            }
            return sentence;
        }
        private string randomString(int charInWord)
        {
            string text = "";
            while (charInWord > 0)
            {
                text += alphabets[randomFromTo(0, alphabets.Length)];
                charInWord--;
            }
            return text;
        }
        public TSportDbContext(DbContextOptions<TSportDbContext> options) : base(options)
        {

        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<OHProduct> OHProducts { get; set; }
        public DbSet<OrderHistory> OrderHistories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<User> Users { get; set; }

        private static string[] arrNameCategory = { "Shoes", "Computer", "Covid-19", "Electronics", "Frame sunglasses", "Funiture", "Genuine leather" };
        private static string[] arrNameBrand = { "Lakmetao", "Beautifullis", "Mate in TW", "Percifco", "Xlowete" };
        private static string[] arrHexCode = { "#586882", "#505050", "#73707A", "#C7BB9B" };
        private static string[] arrNameSize = { "S", "M", "L", "XL", "XXL" };
        private static string[] arrNameFile = { "1.webp","2.webp","3.webp","4.webp" };


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Product>().HasMany(p => p.Colors).WithMany(p => p.Products);
            

            this.SeedUsers(builder);
            this.SeedBlog(builder, 16);
            this.SeedBrand(builder, arrNameBrand);
            this.SeedCategory(builder, arrNameCategory);
            this.SeedColor(builder, arrHexCode);
            this.SeedImage(builder, arrNameFile);
            this.SeedSize(builder, arrNameSize);
            this.SeedOrderHistory(builder, 5);
            this.SeedProduct(builder, 30, arrHexCode, arrNameSize, arrNameFile);
            this.SeedReview(builder, 25);
            this.SeedOHProduct(builder, 40);
        }
        private void SeedUsers(ModelBuilder builder)
        {
            User user = new User()
            {
                Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                UserName = "Admin",
                Email = "admin@gmail.com",
                LockoutEnabled = false,
                PhoneNumber = "123456"
            };

            PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
            passwordHasher.HashPassword(user, "Admin*123");

            builder.Entity<User>().HasData(user);
        }
        private void SeedBlog(ModelBuilder builder, int quantity)
        {
            List<Blog> blogs = new List<Blog>();
            for (int i = 1; i <= quantity; i++)
            {
                blogs.Add(new Blog
                {
                    Id = i,
                    Title = randomSentence(10),
                    Content = randomSentence(100),
                    Author = randomSentence(2),
                    Tag = randomSentence(4),
                    TimePosted = DateTime.Now
                });
            }
            builder.Entity<Blog>().HasData(blogs);
        }
        private void SeedBrand(ModelBuilder builder, string[] arrNameBrand)
        {
            List<Brand> brands = new List<Brand>();
            for (int i = 0; i < arrNameBrand.Length; i++)
            {
                brands.Add(new Brand
                {
                    Id = i + 1,
                    Name = arrNameBrand[i]
                });
            }
            builder.Entity<Brand>().HasData(brands);
        }
        private void SeedCategory(ModelBuilder builder, string[] arrNameCategory)
        {
            List<Category> categories = new List<Category>();
            for (int i = 0; i < arrNameCategory.Length; i++)
            {
                categories.Add(new Category
                {
                    Id = i + 1,
                    Name = arrNameCategory[i]
                });
            }
            builder.Entity<Category>().HasData(categories);
        }
        private void SeedColor(ModelBuilder builder, string[] arrHexCode)
        {
            List<Color> colors = new List<Color>();
            for (int i = 0; i < arrHexCode.Length; i++)
            {
                colors.Add(new Color
                {
                    Id = i + 1,
                    HexCode = arrHexCode[i]
                });
            }
            builder.Entity<Color>().HasData(colors);
        }
        private void SeedImage(ModelBuilder builder, string[] arrNameFile)
        {
            List<Image> images = new List<Image>();
            for (int i = 0; i < arrNameFile.Length; i++)
            {
                images.Add(new Image
                {
                    Id = i + 1,
                    Url = $"assets/img/shop/product-single/{arrNameFile[i]}"
                }) ;
            }
            builder.Entity<Image>().HasData(images);
        }
        private void SeedOrderHistory(ModelBuilder builder, int quantity)
        {
            List<OrderHistory> orders = new List<OrderHistory>();
            for (int i = 0; i < quantity; i++)
            {
                orders.Add(new OrderHistory
                {
                    Id = i + 1,
                    UserId = "b74ddd14-6340-4840-95c2-db12554843e5",
                    CouponCode = randomString(6),
                    ToLocation = randomSentence(10),
                    ReceiverPhone = "1234567890",
                    TimeCreated = DateTime.Now
                });
            }
            builder.Entity<OrderHistory>().HasData(orders);
        }
        private void SeedSize(ModelBuilder builder, string[] arrNameSize)
        {
            List<Size> sizes = new List<Size>();
            for (int i = 0; i < arrNameSize.Length; i++)
            {
                sizes.Add(new Size
                {
                    Id = i + 1,
                    Name = arrNameSize[i]
                });
            }
            builder.Entity<Size>().HasData(sizes);
        }
        private void SeedProduct(ModelBuilder builder, int quantity, string[] arrHexCode, string[] arrNameSize,string[] arrNameFile)
        {
            object[] colorProducts = new object[quantity * arrHexCode.Length];
            object[] sizeProducts = new object[quantity * arrNameSize.Length];
            object[] imageProducts = new object[quantity * arrNameFile.Length];

            List<Product> products = new List<Product>();
            for (int i = 0; i < quantity; i++)
            {
                for (int j = 0; j < arrHexCode.Length; j++)
                {
                    colorProducts[i * arrHexCode.Length + j] = new { ProductsId = i + 1, ColorsId = j + 1 };
                }
                for (int j = 0; j < arrNameSize.Length; j++)
                {
                    sizeProducts[i * arrNameSize.Length + j] = new { ProductsId = i + 1, SizesId = j + 1 };
                }
                for (int j = 0; j < arrNameFile.Length; j++)
                {
                    imageProducts[i * arrNameFile.Length + j] = new { ProductsId = i + 1, ImagesId = j + 1 };
                }
                products.Add(new Product
                {
                    Id = i + 1,
                    Code = randomString(6),
                    Name = randomSentence(4),
                    BrandId = randomFromTo(1, 5),
                    CategoryId = randomFromTo(1, 6),
                    Overeview = randomSentence(20),
                    Description = randomSentence(50),
                    Price = (randomFromTo(10, 1000) / 10) * 10,
                    Total = randomFromTo(100, 2000),
                    InStock = randomFromTo(0, 2000),
                    SalesOff = randomFromTo(0, 15)
                });
            }
            builder.Entity<Product>().HasData(products);
            builder.Entity<Color>().HasMany(p => p.Products).WithMany(c => c.Colors).UsingEntity(j => j.HasData(colorProducts));
            builder.Entity<Size>().HasMany(p => p.Products).WithMany(c => c.Sizes).UsingEntity(j => j.HasData(sizeProducts));
            builder.Entity<Image>().HasMany(p => p.Products).WithMany(c => c.Images).UsingEntity(j => j.HasData(imageProducts));
        }
        private void SeedReview(ModelBuilder builder, int quantity)
        {
            List<Review> reviews = new List<Review>();
            for (int i = 0; i < quantity; i++)
            {
                reviews.Add(new Review
                {
                    Id = i + 1,
                    Title = randomSentence(7),
                    Rate = randomFromTo(1, 5),
                    Comment = randomSentence(30),
                    ProductId = randomFromTo(1, 30),
                    UserId = "b74ddd14-6340-4840-95c2-db12554843e5",
                    TimePosted = DateTime.Now
                }) ; ;
            }
            builder.Entity<Review>().HasData(reviews);
        }
        private void SeedOHProduct(ModelBuilder builder, int quantity)
        {
            List<OHProduct> ohProducts = new List<OHProduct>();
            for (int i = 0; i < quantity; i++)
            {
                ohProducts.Add(new OHProduct
                {
                    Id = i + 1,
                    OrderHistoryId = randomFromTo(1, 5),
                    ProductId = randomFromTo(1, 30),
                    Quantity = randomFromTo(1, 20)
                });
            }
            builder.Entity<OHProduct>().HasData(ohProducts);
        }
    }
}
