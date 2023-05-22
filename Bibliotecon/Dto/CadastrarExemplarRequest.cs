using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    using Bibliotecon.Dto;

namespace Bibliotecon.Dto
{
    public class CadastrarExemplarRequest
    {
            public int CodExemplar { get; set; }
            public int CodLivro { get; set; }
            public int CodFuncionario { get; set; }
            public bool Status { get; set; }
        }

    }

