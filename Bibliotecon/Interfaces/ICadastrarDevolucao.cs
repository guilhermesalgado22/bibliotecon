using Bibliotecon.Dto;
using Bibliotecon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecon.Interfaces
{
    public interface ICadastrarDevolucao
    {
        Task<CadastrarDevolucaoResponse> CadastrarDevolucaoAsync(CadastrarDevolucaoRequest request);
        List<Devolucao> PesquisarDevolucao(int codigoDevolucao);
    }
}
