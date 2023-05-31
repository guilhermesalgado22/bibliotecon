using Bibliotecon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliotecon.Models;
using Bibliotecon.Dto;
using Microsoft.EntityFrameworkCore;

namespace Bibliotecon.Services
{
    public class LivroService : ILivroService
    {
        private readonly DemoDbContext _context;

        public LivroService(DemoDbContext context)
        {
            _context = context;
        }

        public async Task<CadastroLivroResponse> InserirLivroAsync(CadastroLivroRequest request)
        {
            var livro = new Livro
            {
                Titulo = request.Titulo,
                Autor = request.Autor,
                Editora = request.Editora,
                AnoPublicacao = request.AnoPublicacao,
                Categoria = request.Categoria,
                Status = true
            };

            _context.TbLivro.Add(livro);
            await _context.SaveChangesAsync();

            var response = new CadastroLivroResponse
            {
                CodLivro = livro.CodLivro,
                Titulo = livro.Titulo,
                Autor = livro.Autor,
                Editora = livro.Editora,
                AnoPublicacao = livro.AnoPublicacao,
                Categoria = livro.Categoria,
                Status = livro.Status
            };

            return response;
        }

        List<Livro> ILivroService.PesquisarLivros(int codlivros)
        {
            using (var contexto = new DemoDbContext())
            {
                return contexto.TbLivro
                    .Where(e => e.CodLivro == codlivros)
                    .OrderBy(e => codlivros)
                    .Select(e => new Livro
                    {
                        CodLivro = e.CodLivro,
                        Titulo = e.Titulo,
                        Autor = e.Autor,
                        Editora = e.Editora,
                        AnoPublicacao = e.AnoPublicacao,
                        Categoria = e.Categoria,
                        
                        
                    })
            .ToList();
            }
        }
    }
}
