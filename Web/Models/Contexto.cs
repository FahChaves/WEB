﻿using Microsoft.EntityFrameworkCore;

namespace Web.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) 
        : base(options){ }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
