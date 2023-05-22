using System;
using System.Collections.Generic;

namespace Bibliotecon.Models;

public partial class Reserva
{
    public int CodReserva { get; set; }

    public int CodLeitor { get; set; }

    public int CodExemplar { get; set; }

    public int CodFuncionario { get; set; }

    public DateOnly DataReserva { get; set; }

    public DateOnly DataDevolucao { get; set; }

    public virtual Exemplar CodExemplarNavigation { get; set; } = null!;

    public virtual Funcionario CodFuncionarioNavigation { get; set; } = null!;

    public virtual Leitor CodLeitorNavigation { get; set; } = null!;
}
