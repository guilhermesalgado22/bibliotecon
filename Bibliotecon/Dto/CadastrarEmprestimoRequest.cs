using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//teste
namespace Bibliotecon.Dto
{
    public class CadastrarEmprestimoRequest
    {
        public int CodExemplar { get; set; }
        public int CodLeitor { get; set; }
        public int CodFuncionario { get; set; }
        public DateOnly? DataEmprestimo { get; set; }
        public DateOnly? DataDevolucao { get; set; }
        public int CodLivro { get; set; }
        public int CodReserva { get; set; }
    }
}
