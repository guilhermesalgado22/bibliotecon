using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Bibliotecon.Models;

public partial class Devolucao
{
    public int CodDevolucao { get; set; }

    public int CodExemplar { get; set; }

    public int CodFuncionario { get; set; } 

    public int CodEmprestimo { get; set; }

    public DateOnly? DataDevolucao { get; set; }

    public int Multa { get; set; }
    [Browsable(false)]
    public bool Status { get; set; }

    [Browsable(false)]
    public virtual ExemplarEmprestimo CodEmprestimoNavigation { get; set; } = null!;
    [Browsable(false)]
    public virtual Exemplar CodExemplarNavigation { get; set; } = null!;
    [Browsable(false)]
    public virtual Funcionario CodFuncionarioNavigation { get; set; } = null!;
}
