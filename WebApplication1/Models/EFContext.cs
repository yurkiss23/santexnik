using System;
using System.Collections.Generic;
using System.Web;
using System.Data.Entity;
using WebApplication1.Entities;

namespace WebApplication1.Models
{
    public class EFContext : DbContext
    {
        public EFContext() : base("EFContext")
        {

        }

        public DbSet<Users> Users { get; set; }
    }
}