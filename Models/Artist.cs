using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusic.Models
{
    public class Artist
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string RealName { get; set; }
        public DateTime BornDate { get; set; }
        public string Image { get; set; }
    }
}