using System;
using System.Collections.Generic;

namespace Bibliotecon.Models;

public partial class Cidade
{
    public int CodCidade { get; set; }

    public string Nome { get; set; } = null!;

    public int? CodEstado { get; set; }

    public virtual Estado? CodEstadoNavigation { get; set; }

    public virtual ICollection<Endereco> TbEnderecos { get; } = new List<Endereco>();

    public virtual ICollection<Funcionario> TbFuncionarios { get; } = new List<Funcionario>();

    public virtual ICollection<Leitor> TbLeitors { get; } = new List<Leitor>();
}
