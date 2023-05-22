using System;
using System.Collections.Generic;

namespace Bibliotecon.Models;

public partial class Exemplar
{
    public int CodExemplar { get; set; }

    public int CodLivro { get; set; }

    public bool Status { get; set; }

    public int CodFuncionario { get; set; }

    public virtual Funcionario CodFuncionarioNavigation { get; set; } = null!;

    public virtual Livro CodLivroNavigation { get; set; } = null!;

    public virtual ICollection<Devolucao> TbDevolucaos { get; } = new List<Devolucao>();

    public virtual ICollection<ExemplarEmprestimo> TbExemplarEmprestimos { get; } = new List<ExemplarEmprestimo>();

    public virtual ICollection<Reserva> TbReservas { get; } = new List<Reserva>();
}
