using CrudWebProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrudWebProject.Context
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}