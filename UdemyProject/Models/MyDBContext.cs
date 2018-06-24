using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UdemyProject.Models
{
    public class MyDBContext: DbContext
    {
        public MyDBContext() : base("UdemyProject.Models.MyDBContext")
        {

        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Customer> Customers { get; set; }
    }
}