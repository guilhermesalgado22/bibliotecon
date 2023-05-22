using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecon.Dto
{
   public class CadastrarEmprestimoResponse
    {
        public int CodEmprestimo { get; set; }
        public int CodExemplar { get; set; }
        public int CodLeitor { get; set; }
        public int CodFuncionario { get; set; }
        public DateOnly? DataEmprestimo { get; set; }
        public DateOnly? DataDevolucao { get; set; }
        public int CodLivro { get; set; }
        public int CodReserva { get; set; }
    }
}
