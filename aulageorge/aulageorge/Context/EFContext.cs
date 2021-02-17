﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using aulageorge.Models;
using System.Data.Entity;


namespace aulageorge.Context
{
    public class EFContext : System.Data.Entity.DbContext
    {
        public EFContext() : base("Asp_Net_MVC_CS") { }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }
    }
}