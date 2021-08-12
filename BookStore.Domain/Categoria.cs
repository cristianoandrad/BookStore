using System;
using System.Collections.Generic;
//sing System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Domain
{
    public class Categoria
    {
        public Categoria()
        {
            this.Livros = new List<Livro>();
        }
        //[Key]
        public int Id { get; set; }
        //[Required(ErrorMessage = "*")]
        //[StringLength(30, MinimumLength = 3, ErrorMessage = "Campo Inválido")]
        public string Nome { get; set; }
        public ICollection<Livro> Livros { get; set; }
    }
}
