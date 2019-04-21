using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Cliente.Domain.Entity;

namespace Cliente.Infra.Data.Context
{
    public class ClienteContext : DbContext
    {
        public DbSet<Clientes> MyProperty { get; set; }
        public ClienteContext(DbContextOptions option) : base(option)
        {

        }
    }
}
