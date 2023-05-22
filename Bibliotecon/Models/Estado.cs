using System;
using System.Collections.Generic;

namespace Bibliotecon.Models;

public partial class Estado
{
    public int CodEstado { get; set; }

    public string Nome { get; set; } = null!;

    public string Sigla { get; set; } = null!;

    public virtual ICollection<Cidade> TbCidades { get; } = new List<Cidade>();

    public virtual ICollection<Funcionario> TbFuncionarios { get; } = new List<Funcionario>();

    public virtual ICollection<Leitor> TbLeitors { get; } = new List<Leitor>();
}
