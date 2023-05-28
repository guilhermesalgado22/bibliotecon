using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecon.Dto
{
    public class CadastrarDevolucaoResponse
    {
        public int CodDevolucao { get; set; }

        public int CodExemplar { get; set; }

        public int CodFuncionario { get; set; }

        public int CodEmprestimo { get; set; }

        public DateOnly? DataDevolucao { get; set; }

        public int Multa { get; set; }

        public bool Status { get; set; }
    }
}
