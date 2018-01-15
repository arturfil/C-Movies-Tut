using System;
using System.Data.Entity;

namespace ASP_MVC_5_Basics.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }

    public class MovieDBContext: DbContext
    {
        public DbSet<Movie> Movies { get; set; }

    }
}