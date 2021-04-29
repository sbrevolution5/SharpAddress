using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using SharpAddress.Models;

namespace SharpAddress.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SharpAddress.Models.Contact> Contact { get; set; }
        public DbSet<SharpAddress.Models.Category> Category { get; set; }
    }
}
