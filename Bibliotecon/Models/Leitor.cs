using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Bibliotecon.Models;

public partial class Leitor
{
    public int CodLeitor { get; set; }

    public string Nome { get; set; } = null!;

    public string Telefone { get; set; } = null!;

    public string Sexo { get; set; } = null!;

    public DateOnly DataNascimento { get; set; }

    public string Cpf { get; set; } = null!;

    public string Rg { get; set; } = null!;
    [Browsable(false)]
    public bool Status { get; set; }
    [Browsable(false)]
    public int PrazoDevolucao { get; set; }
    [Browsable(false)]
    public int CodCidade { get; set; }
    [Browsable(false)]
    public int CodEndereco { get; set; }
    [Browsable(false)]
    public int CodEstado { get; set; }
    [Browsable(false)]
    public virtual Cidade CodCidadeNavigation { get; set; } = null!;
    [Browsable(false)]
    public virtual Endereco CodEnderecoNavigation { get; set; } = null!;
    [Browsable(false)]
    public virtual Estado CodEstadoNavigation { get; set; } = null!;
    [Browsable(false)]
    public virtual ICollection<ExemplarEmprestimo> TbExemplarEmprestimos { get; } = new List<ExemplarEmprestimo>();
    [Browsable(false)]
    public virtual ICollection<Reserva> TbReservas { get; } = new List<Reserva>();
}
