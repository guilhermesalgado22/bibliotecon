using Bibliotecon.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecon.Interfaces
{
    public interface ICadastrarReservaService
    {
        Task<CadastrarReservaResponse> CadastrarReservaAsync(CadastrarReservaRequest request);
        Task<bool> VerificarExemplarDisponivelAsync(int codLivro, int codExemplar);
    }
}
