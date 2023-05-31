using Bibliotecon.Dto;
using Bibliotecon.Interfaces;
using Bibliotecon.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecon.Services
{
    public class ExemplarService : IExemplarService
    {
        private readonly DemoDbContext _context;

        public ExemplarService(DemoDbContext context)
        {
            _context = context;
        }
        public async Task<CadastrarExemplarResponse> InserirExemplarAsync(CadastrarExemplarRequest request)
        {
            var novoExemplar = new Exemplar
            {
                CodLivro = (int)request.CodLivro,
                CodFuncionario = (int)request.CodFuncionario,
                Status = true,
                CodExemplar = (int)request.CodExemplar
            };

            _context.TbExemplars.Add(novoExemplar);
            await _context.SaveChangesAsync();

            var response = new CadastrarExemplarResponse
            {
                CodLivro = novoExemplar.CodLivro,
                CodFuncionario = novoExemplar.CodFuncionario,
                Status = true,
                CodExemplar = novoExemplar.CodExemplar
            };

            return response;
        }

        List<Exemplar> IExemplarService.PesquisarExemplar(int codigoExemplar)
        {
            using (var contexto = new DemoDbContext())
            {
                return contexto.TbExemplars
                    .Include(e => e.CodLivroNavigation)
                    .OrderBy(e => codigoExemplar)
                    .Where(e => e.CodExemplar == codigoExemplar)
                    .Select(e => new Exemplar
                    {
                        CodExemplar = e.CodExemplar,
                        CodLivro = e.CodLivro,
                        CodFuncionario = e.CodFuncionario,
                    })
            .ToList();
            }
        }
    }
}


