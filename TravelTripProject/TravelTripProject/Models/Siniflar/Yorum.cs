﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Siniflar
{
    public class Yorum
    {
        [Key]
        public int ID { get; set; }
        public string Kullanici { get; set; }
        public string Mail { get; set; }
        public string Yorumlar { get; set; }
        public virtual Blog Blog { get; set; }
        public int BlogID { get; set; }
    }
}