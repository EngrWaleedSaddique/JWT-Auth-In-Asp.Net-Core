using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_JWT.Models;

namespace WebAPI_JWT.Context
{

    public class JwtContext : DbContext
    {
        public JwtContext(DbContextOptions<JwtContext> options) : base(options) {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
