using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookStore.Domain;
using BookStore.Mapping;


namespace BookStore.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext (DbContextOptions<BookStoreContext> options)
            : base(options)
        {
        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Livro> Livros { get; set; }
        
        protected void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AutorMap());
            modelBuilder.Configurations.Add(new CategoriaMap());
            modelBuilder.Configurations.Add(new LivroMap());

        }

        
    }
}
