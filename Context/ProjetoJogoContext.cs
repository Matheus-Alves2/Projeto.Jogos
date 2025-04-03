using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Projeto_Jogos.Domains;
using ProjetoDeJogos.Domains;

namespace Projeto_Jogos.Context
{
    public class ProjetoJogoContext : DbContext
    {
        //Metodo construtor tem o mesmo nome da classe
        public ProjetoJogoContext() { }

        public ProjetoJogoContext(DbContextOptions<ProjetoJogoContext> options) : base(options)
        {

        }
        //Cria a tabela de jogos
        public DbSet<Jogo> Jogo { get; set; }
        public DbSet<Usuarios> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=NOTE25-S28\\SQLEXPRESS; Database=ProjetoJogos; User Id = sa; Pwd=Senai@134; TrustServerCertificate=True;");
            }
        }
    }
}
