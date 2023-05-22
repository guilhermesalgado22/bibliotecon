using System;
using System.Collections.Generic;

namespace Bibliotecon.Models;

public partial class Devolucao
{
    public int CodDevolucao { get; set; }

    public int CodExemplar { get; set; }

    public int CodFuncionario { get; set; }

    public int CodEmprestimo { get; set; }

    public DateOnly? DataDevolucao { get; set; }

    public int Multa { get; set; }

    public bool Status { get; set; }

    public virtual ExemplarEmprestimo CodEmprestimoNavigation { get; set; } = null!;

    public virtual Exemplar CodExemplarNavigation { get; set; } = null!;

    public virtual Funcionario CodFuncionarioNavigation { get; set; } = null!;
}
