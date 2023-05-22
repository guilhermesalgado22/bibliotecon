using Bibliotecon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliotecon.Models;
using Bibliotecon.Dto;

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
    }
}
