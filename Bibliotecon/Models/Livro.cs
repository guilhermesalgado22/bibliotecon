using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Bibliotecon.Models;

public partial class Livro
{
    public int CodLivro { get; set; }

    public string Titulo { get; set; } = null!;

    public string Autor { get; set; } = null!;

    public string Editora { get; set; } = null!;

    public int AnoPublicacao { get; set; }

    public string Categoria { get; set; } = null!;
    [Browsable(false)]
    public bool Status { get; set; }
    [Browsable(false)]
    public virtual ICollection<Exemplar> TbExemplars { get; } = new List<Exemplar>();
   
}
