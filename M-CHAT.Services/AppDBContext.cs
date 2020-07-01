using System;
using System.Collections.Generic;
using System.Text;
using M_CHAT.Models;
using Microsoft.EntityFrameworkCore;

namespace M_CHAT.Services
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        public DbSet<Tutor> Tutores { get; set; }
        public DbSet<CentroE> CentrosE { get; set; }
        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<Ninio> Ninios { get; set; }
        public DbSet<Respuesta> Respuestas { get; set; }
        public DbSet<Pregunta> Preguntas { get; set; }



    }
}
