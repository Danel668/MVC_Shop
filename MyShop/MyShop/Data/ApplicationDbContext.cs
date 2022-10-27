using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyShop.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyShop.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<OrderStock> OrderStocks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            modelBuilder.Entity<Stock>().HasData(new Domain.Models.Stock[]
            {
                new Stock {Id = 1, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.S, ProductId = 1},
                new Stock {Id = 2, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.S, ProductId = 1},
                new Stock {Id = 3, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.S, ProductId = 1},
                new Stock {Id = 4, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.S, ProductId = 1},
                new Stock {Id = 5, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.S, ProductId = 1},
                new Stock {Id = 6, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.S, ProductId = 1},

                new Stock {Id = 7, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.M, ProductId = 1},
                new Stock {Id = 8, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.M, ProductId = 1},
                new Stock {Id = 9, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.M, ProductId = 1},
                new Stock {Id = 10, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.M, ProductId = 1},
                new Stock {Id = 11, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.M, ProductId = 1},
                new Stock {Id = 12, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.M, ProductId = 1},

                new Stock {Id = 13, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.L, ProductId = 1},
                new Stock {Id = 14, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.L, ProductId = 1},
                new Stock {Id = 15, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.L, ProductId = 1},
                new Stock {Id = 16, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.L, ProductId = 1},
                new Stock {Id = 17, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.L, ProductId = 1},
                new Stock {Id = 18, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.L, ProductId = 1},

                new Stock {Id = 19, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.XL, ProductId = 1},
                new Stock {Id = 20, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.XL, ProductId = 1},
                new Stock {Id = 21, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.XL, ProductId = 1},
                new Stock {Id = 22, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.XL, ProductId = 1},
                new Stock {Id = 23, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.XL, ProductId = 1},
                new Stock {Id = 24, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.XL, ProductId = 1},

                new Stock {Id = 25, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.XXL, ProductId = 1},
                new Stock {Id = 26, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.XXL, ProductId = 1},
                new Stock {Id = 27, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.XXL, ProductId = 1},
                new Stock {Id = 28, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.XXL, ProductId = 1},
                new Stock {Id = 29, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.XXL, ProductId = 1},
                new Stock {Id = 30, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.XXL, ProductId = 1},

                new Stock {Id = 31, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.XXXL, ProductId = 1},
                new Stock {Id = 32, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.XXXL, ProductId = 1},
                new Stock {Id = 33, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.XXXL, ProductId = 1},
                new Stock {Id = 34, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.XXXL, ProductId = 1},
                new Stock {Id = 35, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.XXXL, ProductId = 1},
                new Stock {Id = 36, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.XXXL, ProductId = 1},

                 new Stock {Id = 37, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.S, ProductId = 2},
                new Stock {Id = 38, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.S, ProductId = 2},
                new Stock {Id = 39, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.S, ProductId = 2},
                new Stock {Id = 40, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.S, ProductId = 2},
                new Stock {Id = 41, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.S, ProductId = 2},
                new Stock {Id = 42, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.S, ProductId = 2},

                new Stock {Id = 43, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.M, ProductId = 2},
                new Stock {Id = 44, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.M, ProductId = 2},
                new Stock {Id = 45, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.M, ProductId = 2},
                new Stock {Id = 46, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.M, ProductId = 2},
                new Stock {Id = 47, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.M, ProductId = 2},
                new Stock {Id = 48, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.M, ProductId = 2},

                new Stock {Id = 49, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.L, ProductId = 2},
                new Stock {Id = 50, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.L, ProductId = 2},
                new Stock {Id = 51, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.L, ProductId = 2},
                new Stock {Id = 52, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.L, ProductId = 2},
                new Stock {Id = 53, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.L, ProductId = 2},
                new Stock {Id = 54, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.L, ProductId = 2},

                new Stock {Id = 55, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.XL, ProductId = 2},
                new Stock {Id = 56, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.XL, ProductId = 2},
                new Stock {Id = 57, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.XL, ProductId = 2},
                new Stock {Id = 58, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.XL, ProductId = 2},
                new Stock {Id = 59, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.XL, ProductId = 2},
                new Stock {Id = 60, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.XL, ProductId = 2},

                new Stock {Id = 61, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.XXL, ProductId = 2},
                new Stock {Id = 62, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.XXL, ProductId = 2},
                new Stock {Id = 63, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.XXL, ProductId = 2},
                new Stock {Id = 64, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.XXL, ProductId = 2},
                new Stock {Id = 65, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.XXL, ProductId = 2},
                new Stock {Id = 66, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.XXL, ProductId = 2},

                new Stock {Id = 67, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.XXXL, ProductId = 2},
                new Stock {Id = 68, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.XXXL, ProductId = 2},
                new Stock {Id = 69, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.XXXL, ProductId = 2},
                new Stock {Id = 70, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.XXXL, ProductId = 2},
                new Stock {Id = 71, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.XXXL, ProductId = 2},
                new Stock {Id = 72, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.XXXL, ProductId = 2},

                new Stock {Id = 73, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.S, ProductId = 3},
                new Stock {Id = 74, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.S, ProductId = 3},
                new Stock {Id = 75, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.S, ProductId = 3},
                new Stock {Id = 76, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.S, ProductId = 3},
                new Stock {Id = 77, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.S, ProductId = 3},
                new Stock {Id = 78, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.S, ProductId = 3},

                new Stock {Id = 79, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.M, ProductId = 3},
                new Stock {Id = 80, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.M, ProductId = 3},
                new Stock {Id = 81, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.M, ProductId = 3},
                new Stock {Id = 82, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.M, ProductId = 3},
                new Stock {Id = 83, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.M, ProductId = 3},
                new Stock {Id = 84, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.M, ProductId = 3},

                new Stock {Id = 85, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.L, ProductId = 3},
                new Stock {Id = 86, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.L, ProductId = 3},
                new Stock {Id = 87, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.L, ProductId = 3},
                new Stock {Id = 88, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.L, ProductId = 3},
                new Stock {Id = 89, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.L, ProductId = 3},
                new Stock {Id = 90, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.L, ProductId = 3},

                new Stock {Id = 91, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.XL, ProductId = 3},
                new Stock {Id = 92, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.XL, ProductId = 3},
                new Stock {Id = 93, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.XL, ProductId = 3},
                new Stock {Id = 94, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.XL, ProductId = 3},
                new Stock {Id = 95, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.XL, ProductId = 3},
                new Stock {Id = 96, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.XL, ProductId = 3},

                new Stock {Id = 97, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.XXL, ProductId = 3},
                new Stock {Id = 98, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.XXL, ProductId = 3},
                new Stock {Id = 99, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.XXL, ProductId = 3},
                new Stock {Id = 100, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.XXL, ProductId = 3},
                new Stock {Id = 101, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.XXL, ProductId = 3},
                new Stock {Id = 102, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.XXL, ProductId = 3},

                new Stock {Id = 103, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.XXXL, ProductId = 3},
                new Stock {Id = 104, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.XXXL, ProductId = 3},
                new Stock {Id = 105, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.XXXL, ProductId = 3},
                new Stock {Id = 106, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.XXXL, ProductId = 3},
                new Stock {Id = 107, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.XXXL, ProductId = 3},
                new Stock {Id = 108, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.XXXL, ProductId = 3},

                new Stock {Id = 109, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.S, ProductId = 4},
                new Stock {Id = 110, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.S, ProductId = 4},
                new Stock {Id = 111, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.S, ProductId = 4},
                new Stock {Id = 112, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.S, ProductId = 4},
                new Stock {Id = 113, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.S, ProductId = 4},
                new Stock {Id = 114, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.S, ProductId = 4},

                new Stock {Id = 115, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.M, ProductId = 4},
                new Stock {Id = 116, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.M, ProductId = 4},
                new Stock {Id = 117, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.M, ProductId = 4},
                new Stock {Id = 118, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.M, ProductId = 4},
                new Stock {Id = 119, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.M, ProductId = 4},
                new Stock {Id = 120, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.M, ProductId = 4},

                new Stock {Id = 121, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.L, ProductId = 4},
                new Stock {Id = 122, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.L, ProductId = 4},
                new Stock {Id = 123, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.L, ProductId = 4},
                new Stock {Id = 124, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.L, ProductId = 4},
                new Stock {Id = 125, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.L, ProductId = 4},
                new Stock {Id = 126, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.L, ProductId = 4},

                new Stock {Id = 127, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.XL, ProductId = 4},
                new Stock {Id = 128, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.XL, ProductId = 4},
                new Stock {Id = 129, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.XL, ProductId = 4},
                new Stock {Id = 130, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.XL, ProductId = 4},
                new Stock {Id = 131, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.XL, ProductId = 4},
                new Stock {Id = 132, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.XL, ProductId = 4},

                new Stock {Id = 133, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.XXL, ProductId = 4},
                new Stock {Id = 134, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.XXL, ProductId = 4},
                new Stock {Id = 135, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.XXL, ProductId = 4},
                new Stock {Id = 136, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.XXL, ProductId = 4},
                new Stock {Id = 137, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.XXL, ProductId = 4},
                new Stock {Id = 138, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.XXL, ProductId = 4},

                new Stock {Id = 139, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.XXXL, ProductId = 4},
                new Stock {Id = 140, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.XXXL, ProductId = 4},
                new Stock {Id = 141, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.XXXL, ProductId = 4},
                new Stock {Id = 142, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.XXXL, ProductId = 4},
                new Stock {Id = 143, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.XXXL, ProductId = 4},
                new Stock {Id = 144, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.XXXL, ProductId = 4},

                 new Stock {Id = 145, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.S, ProductId = 5},
                new Stock {Id = 146, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.S, ProductId = 5},
                new Stock {Id = 147, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.S, ProductId = 5},
                new Stock {Id = 148, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.S, ProductId = 5},
                new Stock {Id = 149, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.S, ProductId = 5},
                new Stock {Id = 150, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.S, ProductId = 5},

                new Stock {Id = 151, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.M, ProductId = 5},
                new Stock {Id = 152, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.M, ProductId = 5},
                new Stock {Id = 153, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.M, ProductId = 5},
                new Stock {Id = 154, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.M, ProductId = 5},
                new Stock {Id = 155, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.M, ProductId = 5},
                new Stock {Id = 156, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.M, ProductId = 5},

                new Stock {Id = 157, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.L, ProductId = 5},
                new Stock {Id = 158, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.L, ProductId = 5},
                new Stock {Id = 159, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.L, ProductId = 5},
                new Stock {Id = 160, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.L, ProductId = 5},
                new Stock {Id = 161, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.L, ProductId = 5},
                new Stock {Id = 162, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.L, ProductId = 5},

                new Stock {Id = 163, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.XL, ProductId = 5},
                new Stock {Id = 164, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.XL, ProductId = 5},
                new Stock {Id = 165, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.XL, ProductId = 5},
                new Stock {Id = 166, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.XL, ProductId = 5},
                new Stock {Id = 167, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.XL, ProductId = 5},
                new Stock {Id = 168, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.XL, ProductId = 5},

                new Stock {Id = 169, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.XXL, ProductId = 5},
                new Stock {Id = 170, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.XXL, ProductId = 5},
                new Stock {Id = 171, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.XXL, ProductId = 5},
                new Stock {Id = 172, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.XXL, ProductId = 5},
                new Stock {Id = 173, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.XXL, ProductId = 5},
                new Stock {Id = 174, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.XXL, ProductId = 5},

                new Stock {Id = 175, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.XXXL, ProductId = 5},
                new Stock {Id = 176, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.XXXL, ProductId = 5},
                new Stock {Id = 177, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.XXXL, ProductId = 5},
                new Stock {Id = 178, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.XXXL, ProductId = 5},
                new Stock {Id = 179, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.XXXL, ProductId = 5},
                new Stock {Id = 180, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.XXXL, ProductId = 5},

                new Stock {Id = 181, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.S, ProductId = 6},
                new Stock {Id = 182, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.S, ProductId = 6},
                new Stock {Id = 183, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.S, ProductId = 6},
                new Stock {Id = 184, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.S, ProductId = 6},
                new Stock {Id = 185, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.S, ProductId = 6},
                new Stock {Id = 186, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.S, ProductId = 6},

                new Stock {Id = 187, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.M, ProductId = 6},
                new Stock {Id = 188, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.M, ProductId = 6},
                new Stock {Id = 189, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.M, ProductId = 6},
                new Stock {Id = 190, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.M, ProductId = 6},
                new Stock {Id = 191, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.M, ProductId = 6},
                new Stock {Id = 192, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.M, ProductId = 6},

                new Stock {Id = 193, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.L, ProductId = 6},
                new Stock {Id = 194, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.L, ProductId = 6},
                new Stock {Id = 195, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.L, ProductId = 6},
                new Stock {Id = 196, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.L, ProductId = 6},
                new Stock {Id = 197, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.L, ProductId = 6},
                new Stock {Id = 198, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.L, ProductId = 6},

                new Stock {Id = 199, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.XL, ProductId = 6},
                new Stock {Id = 200, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.XL, ProductId = 6},
                new Stock {Id = 201, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.XL, ProductId = 6},
                new Stock {Id = 202, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.XL, ProductId = 6},
                new Stock {Id = 203, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.XL, ProductId = 6},
                new Stock {Id = 204, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.XL, ProductId = 6},

                new Stock {Id = 205, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.XXL, ProductId = 6},
                new Stock {Id = 206, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.XXL, ProductId = 6},
                new Stock {Id = 207, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.XXL, ProductId = 6},
                new Stock {Id = 208, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.XXL, ProductId = 6},
                new Stock {Id = 209, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.XXL, ProductId = 6},
                new Stock {Id = 210, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.XXL, ProductId = 6},

                new Stock {Id = 211, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.XXXL, ProductId = 6},
                new Stock {Id = 212, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.XXXL, ProductId = 6},
                new Stock {Id = 213, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.XXXL, ProductId = 6},
                new Stock {Id = 214, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.XXXL, ProductId = 6},
                new Stock {Id = 215, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.XXXL, ProductId = 6},
                new Stock {Id = 216, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.XXXL, ProductId = 6},

                new Stock {Id = 217, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.S, ProductId = 7},
                new Stock {Id = 218, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.S, ProductId = 7},
                new Stock {Id = 219, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.S, ProductId = 7},
                new Stock {Id = 220, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.S, ProductId = 7},
                new Stock {Id = 221, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.S, ProductId = 7},
                new Stock {Id = 222, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.S, ProductId = 7},

                new Stock {Id = 223, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.M, ProductId = 7},
                new Stock {Id = 224, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.M, ProductId = 7},
                new Stock {Id = 225, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.M, ProductId = 7},
                new Stock {Id = 226, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.M, ProductId = 7},
                new Stock {Id = 227, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.M, ProductId = 7},
                new Stock {Id = 228, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.M, ProductId = 7},

                new Stock {Id = 229, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.L, ProductId = 7},
                new Stock {Id = 230, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.L, ProductId = 7},
                new Stock {Id = 231, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.L, ProductId = 7},
                new Stock {Id = 232, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.L, ProductId = 7},
                new Stock {Id = 233, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.L, ProductId = 7},
                new Stock {Id = 234, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.L, ProductId = 7},

                new Stock {Id = 235, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.XL, ProductId = 7},
                new Stock {Id = 236, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.XL, ProductId = 7},
                new Stock {Id = 237, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.XL, ProductId = 7},
                new Stock {Id = 238, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.XL, ProductId = 7},
                new Stock {Id = 239, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.XL, ProductId = 7},
                new Stock {Id = 240, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.XL, ProductId = 7},

                new Stock {Id = 241, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.XXL, ProductId = 7},
                new Stock {Id = 242, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.XXL, ProductId = 7},
                new Stock {Id = 243, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.XXL, ProductId = 7},
                new Stock {Id = 244, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.XXL, ProductId = 7},
                new Stock {Id = 245, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.XXL, ProductId = 7},
                new Stock {Id = 246, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.XXL, ProductId = 7},

                new Stock {Id = 247, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.XXXL, ProductId = 7},
                new Stock {Id = 248, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.XXXL, ProductId = 7},
                new Stock {Id = 249, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.XXXL, ProductId = 7},
                new Stock {Id = 250, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.XXXL, ProductId = 7},
                new Stock {Id = 251, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.XXXL, ProductId = 7},
                new Stock {Id = 252, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.XXXL, ProductId = 7},

                new Stock {Id = 253, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.S, ProductId = 8},
                new Stock {Id = 254, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.S, ProductId = 8},
                new Stock {Id = 255, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.S, ProductId = 8},
                new Stock {Id = 256, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.S, ProductId = 8},
                new Stock {Id = 257, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.S, ProductId = 8},
                new Stock {Id = 258, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.S, ProductId = 8},

                new Stock {Id = 259, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.M, ProductId = 8},
                new Stock {Id = 260, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.M, ProductId = 8},
                new Stock {Id = 261, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.M, ProductId = 8},
                new Stock {Id = 262, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.M, ProductId = 8},
                new Stock {Id = 263, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.M, ProductId = 8},
                new Stock {Id = 264, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.M, ProductId = 8},

                new Stock {Id = 265, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.L, ProductId = 8},
                new Stock {Id = 266, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.L, ProductId = 8},
                new Stock {Id = 267, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.L, ProductId = 8},
                new Stock {Id = 268, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.L, ProductId = 8},
                new Stock {Id = 269, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.L, ProductId = 8},
                new Stock {Id = 270, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.L, ProductId = 8},

                new Stock {Id = 271, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.XL, ProductId = 8},
                new Stock {Id = 272, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.XL, ProductId = 8},
                new Stock {Id = 273, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.XL, ProductId = 8},
                new Stock {Id = 274, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.XL, ProductId = 8},
                new Stock {Id = 275, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.XL, ProductId = 8},
                new Stock {Id = 276, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.XL, ProductId = 8},

                new Stock {Id = 277, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.XXL, ProductId = 8},
                new Stock {Id = 278, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.XXL, ProductId = 8},
                new Stock {Id = 279, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.XXL, ProductId = 8},
                new Stock {Id = 280, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.XXL, ProductId = 8},
                new Stock {Id = 281, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.XXL, ProductId = 8},
                new Stock {Id = 282, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.XXL, ProductId = 8},

                new Stock {Id = 283, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.XXXL, ProductId = 8},
                new Stock {Id = 284, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.XXXL, ProductId = 8},
                new Stock {Id = 285, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.XXXL, ProductId = 8},
                new Stock {Id = 286, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.XXXL, ProductId = 8},
                new Stock {Id = 287, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.XXXL, ProductId = 8},
                new Stock {Id = 288, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.XXXL, ProductId = 8},

                new Stock {Id = 289, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.S, ProductId = 9},
                new Stock {Id = 290, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.S, ProductId = 9},
                new Stock {Id = 291, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.S, ProductId = 9},
                new Stock {Id = 292, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.S, ProductId = 9},
                new Stock {Id = 293, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.S, ProductId = 9},
                new Stock {Id = 294, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.S, ProductId = 9},

                new Stock {Id = 295, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.M, ProductId = 9},
                new Stock {Id = 296, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.M, ProductId = 9},
                new Stock {Id = 297, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.M, ProductId = 9},
                new Stock {Id = 298, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.M, ProductId = 9},
                new Stock {Id = 299, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.M, ProductId = 9},
                new Stock {Id = 300, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.M, ProductId = 9},

                new Stock {Id = 301, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.L, ProductId = 9},
                new Stock {Id = 302, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.L, ProductId = 9},
                new Stock {Id = 303, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.L, ProductId = 9},
                new Stock {Id = 304, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.L, ProductId = 9},
                new Stock {Id = 305, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.L, ProductId = 9},
                new Stock {Id = 306, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.L, ProductId = 9},

                new Stock {Id = 307, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.XL, ProductId = 9},
                new Stock {Id = 308, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.XL, ProductId = 9},
                new Stock {Id = 309, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.XL, ProductId = 9},
                new Stock {Id = 310, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.XL, ProductId = 9},
                new Stock {Id = 311, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.XL, ProductId = 9},
                new Stock {Id = 312, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.XL, ProductId = 9},

                new Stock {Id = 313, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.XXL, ProductId = 9},
                new Stock {Id = 314, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.XXL, ProductId = 9},
                new Stock {Id = 315, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.XXL, ProductId = 9},
                new Stock {Id = 316, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.XXL, ProductId = 9},
                new Stock {Id = 317, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.XXL, ProductId = 9},
                new Stock {Id = 318, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.XXL, ProductId = 9},

                new Stock {Id = 319, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.XXXL, ProductId = 9},
                new Stock {Id = 320, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.XXXL, ProductId = 9},
                new Stock {Id = 321, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.XXXL, ProductId = 9},
                new Stock {Id = 322, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.XXXL, ProductId = 9},
                new Stock {Id = 323, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.XXXL, ProductId = 9},
                new Stock {Id = 324, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.XXXL, ProductId = 9},

                new Stock {Id = 325, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.S, ProductId = 10},
                new Stock {Id = 326, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.S, ProductId = 10},
                new Stock {Id = 327, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.S, ProductId = 10},
                new Stock {Id = 328, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.S, ProductId = 10},
                new Stock {Id = 329, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.S, ProductId = 10},
                new Stock {Id = 330, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.S, ProductId = 10},

                new Stock {Id = 331, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.M, ProductId = 10},
                new Stock {Id = 332, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.M, ProductId = 10},
                new Stock {Id = 333, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.M, ProductId = 10},
                new Stock {Id = 334, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.M, ProductId = 10},
                new Stock {Id = 335, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.M, ProductId = 10},
                new Stock {Id = 336, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.M, ProductId = 10},

                new Stock {Id = 337, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.L, ProductId = 10},
                new Stock {Id = 338, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.L, ProductId = 10},
                new Stock {Id = 339, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.L, ProductId = 10},
                new Stock {Id = 340, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.L, ProductId = 10},
                new Stock {Id = 341, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.L, ProductId = 10},
                new Stock {Id = 342, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.L, ProductId = 10},

                new Stock {Id = 343, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.XL, ProductId = 10},
                new Stock {Id = 344, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.XL, ProductId = 10},
                new Stock {Id = 345, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.XL, ProductId = 10},
                new Stock {Id = 346, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.XL, ProductId = 10},
                new Stock {Id = 347, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.XL, ProductId = 10},
                new Stock {Id = 348, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.XL, ProductId = 10},

                new Stock {Id = 349, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.XXL, ProductId = 10},
                new Stock {Id = 350, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.XXL, ProductId = 10},
                new Stock {Id = 351, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.XXL, ProductId = 10},
                new Stock {Id = 352, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.XXL, ProductId = 10},
                new Stock {Id = 353, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.XXL, ProductId = 10},
                new Stock {Id = 354, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.XXL, ProductId = 10},

                new Stock {Id = 355, Qty = 10, Color = Domain.Enums.ProductColor.White, Size = Domain.Enums.ProductSize.XXXL, ProductId = 10},
                new Stock {Id = 356, Qty = 10, Color = Domain.Enums.ProductColor.Black, Size = Domain.Enums.ProductSize.XXXL, ProductId = 10},
                new Stock {Id = 357, Qty = 10, Color = Domain.Enums.ProductColor.Blue, Size = Domain.Enums.ProductSize.XXXL, ProductId = 10},
                new Stock {Id = 358, Qty = 10, Color = Domain.Enums.ProductColor.Green, Size = Domain.Enums.ProductSize.XXXL, ProductId = 10},
                new Stock {Id = 359, Qty = 10, Color = Domain.Enums.ProductColor.Red, Size = Domain.Enums.ProductSize.XXXL, ProductId = 10},
                new Stock {Id = 360, Qty = 10, Color = Domain.Enums.ProductColor.Yellow, Size = Domain.Enums.ProductSize.XXXL, ProductId = 10},

            });

            modelBuilder.Entity<Product>().HasData(new Product[]
            {
                SeedData.product1, SeedData.product2, SeedData.product3, SeedData.product4, SeedData.product5,
                SeedData.product6, SeedData.product7, SeedData.product8, SeedData.product9, SeedData.product10,
            });
            
            modelBuilder.Entity<OrderStock>().HasKey(x => new { x.StockId, x.OrderId });  // будет иметь 2 первичных ключа

        }
    }
}
