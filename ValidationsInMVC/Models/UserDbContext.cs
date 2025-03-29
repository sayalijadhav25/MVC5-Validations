using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ValidationsInMVC.Models.Entities;

namespace ValidationsInMVC.Models
{
    public class UserDbContext:DbContext
    {
        public UserDbContext(): base("Validations")
        {
        }
        public DbSet<User> Users { get; set; }
    }
}