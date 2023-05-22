using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecon.Dto
{
    public class CadastrarLeitorRequest
    {
        public string Nome { get; set; }
        public int CodLeitor { get; set; }
        //public int CodCidade { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public DateOnly DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Sexo { get; set; }
        public string Bairro { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public bool Status { get; set; }
    }
}
