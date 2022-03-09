using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Siniflar
{
    public class Listele
    {
        public IEnumerable<Blog> BlogDeger { get; set; }
        public IEnumerable<Blog> BlogDeger2 { get; set; }
        public IEnumerable<Yorum> YorumDeger { get; set; }
        public IEnumerable<AnaSayfa> AnaDeger { get; set; }
    }
}