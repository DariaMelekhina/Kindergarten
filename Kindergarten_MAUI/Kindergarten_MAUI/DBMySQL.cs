using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Kindergarten_MAUI
{
    internal class DBMySQL: DbContext
    {
        public DBMySQL()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;user=root;password=12345678;database=usersdb5;",
                new MySqlServerVersion(new Version(8, 0, 11))
            );
        }
    }
}
