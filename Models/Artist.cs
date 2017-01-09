using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjektASP.Models
{
    public class Artist
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string RealName { get; set; }
        public DateTime BornDate { get; set; }
        public string Image { get; set; }
    }
    public class ArtistDbContext : DbContext
    {
        public DbSet<Band> Artists { get; set; }
    }
}