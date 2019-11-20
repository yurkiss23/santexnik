using System;
using System.Collections.Generic;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class EFContext : DbContext
    {
        public EFContext() : base("defaultStr")
        {

        }

        public DbSet<User> Users { get; set; }
    }
}