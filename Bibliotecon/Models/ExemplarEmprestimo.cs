using System;
using System.Collections.Generic;

namespace Bibliotecon.Models;

public partial class ExemplarEmprestimo
{
    public int CodEmprestimo { get; set; }

    public int CodExemplar { get; set; }

   // public string DescExemplar { get; set; } = null!;

    public int CodLeitor { get; set; }

    public int CodFuncionario { get; set; }

    public DateOnly? DataEmprestimo { get; set; }

    public DateOnly? DataDevolucao { get; set; }

    public int CodReserva { get; set; }
    public Reserva Reserva { get; set; }

    public virtual Exemplar CodExemplarNavigation { get; set; } = null!;

    public virtual Funcionario CodFuncionarioNavigation { get; set; } = null!;

    public virtual Leitor CodLeitorNavigation { get; set; } = null!;

    public virtual ICollection<Devolucao> TbDevolucaos { get; } = new List<Devolucao>();
}
