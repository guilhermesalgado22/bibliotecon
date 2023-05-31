using System;
using Bibliotecon.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliotecon.Dto;

namespace Bibliotecon.Interfaces
{
    public interface IExemplarService
    {
        Task<CadastrarExemplarResponse> InserirExemplarAsync(CadastrarExemplarRequest request);
        List<Exemplar> PesquisarExemplar(int codigoExemplar);

    }

}
