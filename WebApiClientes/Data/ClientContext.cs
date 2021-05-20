using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiClientes.Models;

namespace WebApiClientes.Data
{
    public class ClientContext : DbContext
    {
        public DbSet<ClientModel> clientModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder option)
        {
            option.UseSqlServer(@"Server=DESKTP-KCH;Database=ExClientBD;Trusted_Connection=true;");
        }
    }
}
