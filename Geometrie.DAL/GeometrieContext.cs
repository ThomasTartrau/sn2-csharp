using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie.DAL
{
    /// <summary>
    /// Classe d'accès aux données pour les formes géométriques
    /// en Entity Framework (Code First)
    /// </summary>
    public class GeometrieContext : DbContext
    {
        //on va récupérer la chaîne de connexion dans le fichier de configuration
        private readonly IConfiguration configuration;

        public GeometrieContext()
            : base(new DbContextOptions<GeometrieContext>())
        {
            //on récupère un objet de configuration
            //à partir d'un fichier de configuration appsettings.json
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional:false, reloadOnChange:false);

            configuration = builder.Build();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //on configure le provider et la chaîne de connexion
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("Geometrie"));
            }
        }
    }
}
