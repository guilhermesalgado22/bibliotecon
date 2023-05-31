using Bibliotecon.Dto;
using Bibliotecon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecon.Interfaces
{
    public interface ILeitorService
    {
        Task<CadastrarLeitorResponse> InserirLeitorAsync(CadastrarLeitorRequest leitor);
        List<Leitor> PesquisarLeitor(int codigoLeitor);
    }
}
