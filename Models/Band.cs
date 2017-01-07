using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcMusic.Models
{
    public class Band
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Debiut { get; set; }
        public int End { get; set; }
        public List<Artist> ActualArtists { get; set; }
        public List<Artist> ExArtists { get; set; }
        [Display (Name = "Obrazek")]
        public string Image { get; set; }
        public List<string> Songs { get; set; }
    }
    public class BandDbContext : DbContext
    {
        public DbSet<Band> Bands { get; set; }
    }
}