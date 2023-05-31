using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Bibliotecon.Models;

public partial class Reserva
{
    public int CodReserva { get; set; }

    public int CodLeitor { get; set; }

    public int CodExemplar { get; set; }

    public int CodFuncionario { get; set; }

    public DateOnly DataReserva { get; set; }

    public DateOnly DataDevolucao { get; set; }
    [Browsable(false)]
    public virtual Exemplar CodExemplarNavigation { get; set; } = null!;
    [Browsable(false)]
    public virtual Funcionario CodFuncionarioNavigation { get; set; } = null!;
    [Browsable(false)]
    public virtual Leitor CodLeitorNavigation { get; set; } = null!;
}
