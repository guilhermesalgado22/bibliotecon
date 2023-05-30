using System;
using System.Collections.Generic;
using System.ComponentModel;
//teste
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

    public int? CodReserva { get; set; }
    //public int CodLivro { get; set; }
   
    [Browsable(false)]
    public Reserva Reserva { get; set; }

    [Browsable(false)]
    public virtual Exemplar CodExemplarNavigation { get; set; } = null!;
    [Browsable(false)]
    public virtual Funcionario CodFuncionarioNavigation { get; set; } = null!;

    [Browsable(false)]
    public virtual Leitor CodLeitorNavigation { get; set; } = null!;
    [Browsable(false)]
    public virtual ICollection<Devolucao> TbDevolucaos { get; } = new List<Devolucao>();
}
