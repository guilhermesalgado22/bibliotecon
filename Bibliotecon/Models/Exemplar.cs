using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Bibliotecon.Models;

public partial class Exemplar
{
    public int CodExemplar { get; set; }

    public int CodLivro { get; set; }
    [Browsable(false)]
    public bool Status { get; set; }

    public int CodFuncionario { get; set; }
    [Browsable(false)]
    public virtual Funcionario CodFuncionarioNavigation { get; set; } = null!;
    [Browsable(false)]
    public virtual Livro CodLivroNavigation { get; set; } = null!;
    [Browsable(false)]
    public virtual ICollection<Devolucao> TbDevolucaos { get; } = new List<Devolucao>();
    [Browsable(false)]
    public virtual ICollection<ExemplarEmprestimo> TbExemplarEmprestimos { get; } = new List<ExemplarEmprestimo>();
    [Browsable(false)]
    public virtual ICollection<Reserva> TbReservas { get; } = new List<Reserva>();
}
