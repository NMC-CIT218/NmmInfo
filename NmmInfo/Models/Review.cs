using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NmmInfo.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public int BreweryId { get; set; }
    }
}