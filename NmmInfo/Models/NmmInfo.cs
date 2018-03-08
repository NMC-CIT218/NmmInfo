using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace NmmInfo.Models
{
    public class NmmInfo_Data : DbContext
    {
        public NmmInfo_Data()
            : base("NmmInfo")
        {

        }

        public DbSet<Brewery> Breweries { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}