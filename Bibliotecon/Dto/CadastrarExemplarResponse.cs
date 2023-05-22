using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecon.Dto
{
    public class CadastrarExemplarResponse
    {
        public int CodExemplar { get; set; }
        public int CodLivro { get; set; }
        public int CodFuncionario { get; set; }
        public bool Status { get; set; }
    }
}

