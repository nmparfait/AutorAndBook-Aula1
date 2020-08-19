using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutorAndBook_A1.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Livro { get; set; }
        public int LivrosVendidos { get; set; }
    }
}
