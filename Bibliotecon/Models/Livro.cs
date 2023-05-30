using System;
using System.Collections.Generic;

namespace Bibliotecon.Models;

public partial class Livro
{
    public int CodLivro { get; set; }

    public string Titulo { get; set; } = null!;

    public string Autor { get; set; } = null!;

    public string Editora { get; set; } = null!;

    public int AnoPublicacao { get; set; }

    public string Categoria { get; set; } = null!;

    public bool Status { get; set; }

    public virtual ICollection<Exemplar> TbExemplars { get; } = new List<Exemplar>();
   
}
