using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecon.Dto
{
    public class CadastroLivroResponse
    {
        public int CodLivro { get; set; }
        public string ?Titulo { get; set; }
        public string ?Autor { get; set; }
        public string ?Editora { get; set; }
        public int AnoPublicacao { get; set; }
        public string ?Categoria { get; set; }
        public bool Status { get; set; }
    }

}
