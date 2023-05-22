using System;
using System.Collections.Generic;

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

    public bool Status { get; set; }

    public int PrazoDevolucao { get; set; }

    public int CodCidade { get; set; }

    public int CodEndereco { get; set; }

    public int CodEstado { get; set; }

    public virtual Cidade CodCidadeNavigation { get; set; } = null!;

    public virtual Endereco CodEnderecoNavigation { get; set; } = null!;

    public virtual Estado CodEstadoNavigation { get; set; } = null!;

    public virtual ICollection<ExemplarEmprestimo> TbExemplarEmprestimos { get; } = new List<ExemplarEmprestimo>();

    public virtual ICollection<Reserva> TbReservas { get; } = new List<Reserva>();
}
