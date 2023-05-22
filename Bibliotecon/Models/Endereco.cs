using System;
using System.Collections.Generic;

namespace Bibliotecon.Models;

public partial class Endereco
{
    public int CodEndereco { get; set; }

    public string DescEndereco { get; set; } = null!;

    public int Numero { get; set; }

    public string Bairro { get; set; } = null!;

    public int CodCidade { get; set; }

    public virtual Cidade CodCidadeNavigation { get; set; } = null!;

    public virtual ICollection<Funcionario> TbFuncionarios { get; } = new List<Funcionario>();

    public virtual ICollection<Leitor> TbLeitors { get; } = new List<Leitor>();
}
