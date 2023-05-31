using Bibliotecon.Dto;
using Bibliotecon.Interfaces;
using Bibliotecon.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//teste
namespace Bibliotecon.Services
{
    internal class CadastrarEmprestimoService : ICadastrarEmprestimo
    {
        private readonly DemoDbContext _dbContext;

        public CadastrarEmprestimoService(DemoDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<CadastrarEmprestimoResponse> CadastrarEmprestimoAsync(CadastrarEmprestimoRequest request)
        {
            {
                ExemplarEmprestimo emprestimo;

                if (request.CodReserva != 0)
                {
                    // Verificar se a reserva existe
                    var reserva = await _dbContext.TbReservas.FindAsync(request.CodReserva);

                    if (reserva == null)
                    {
                        throw new Exception("Reserva não encontrada");
                    }

                    // Verificar se o empréstimo com base na reserva já foi realizado
                    var emprestimoExistente = await _dbContext.TbExemplarEmprestimos.FirstOrDefaultAsync(emp => emp.CodReserva == request.CodReserva);

                    if (emprestimoExistente != null)
                    {
                        throw new Exception("Empréstimo com base nessa reserva já foi realizado");
                    }

                    // Criar um novo empréstimo com base na reserva
                    var eemprestimo = new ExemplarEmprestimo
                    {
                        CodExemplar = reserva.CodExemplar,
                        CodLeitor = reserva.CodLeitor,
                        CodFuncionario = reserva.CodFuncionario,
                        DataEmprestimo = request.DataEmprestimo,
                        DataDevolucao = reserva.DataDevolucao,
                        CodReserva = request.CodReserva
                    };

                    var exemplar = await _dbContext.TbExemplars.FindAsync(request.CodExemplar);
                    exemplar.Status = false;

                    _dbContext.TbExemplarEmprestimos.Add(eemprestimo);
                    await _dbContext.SaveChangesAsync();

                    var response = new CadastrarEmprestimoResponse
                    {
                        CodExemplar = eemprestimo.CodExemplar,
                        CodLeitor = eemprestimo.CodLeitor,
                        CodFuncionario = eemprestimo.CodFuncionario,
                        DataEmprestimo = eemprestimo.DataEmprestimo,
                        DataDevolucao = eemprestimo.DataDevolucao
                    };

                    return response;
                }
                else
                {
                    // Criar um novo empréstimo sem reserva
                    var eemprestimo = new ExemplarEmprestimo
                    {
                        CodExemplar = request.CodExemplar,
                        CodLeitor = request.CodLeitor,
                        CodFuncionario = request.CodFuncionario,
                        DataEmprestimo = request.DataEmprestimo,
                        DataDevolucao = request.DataDevolucao
                    };

                    var exemplar = await _dbContext.TbExemplars.FindAsync(request.CodExemplar);
                    exemplar.Status = false;

                    _dbContext.TbExemplarEmprestimos.Add(eemprestimo);
                    await _dbContext.SaveChangesAsync();

                    var response = new CadastrarEmprestimoResponse
                    {
                        CodExemplar = eemprestimo.CodExemplar,
                        CodLeitor = eemprestimo.CodLeitor,
                        CodFuncionario = eemprestimo.CodFuncionario,
                        DataEmprestimo = eemprestimo.DataEmprestimo,
                        DataDevolucao = eemprestimo.DataDevolucao
                    };

                    return response;
                }
            }
        }


        public List<ExemplarEmprestimo> PesquisarEmprestimos(int codigoEmprestimo)
        {
            using (var contexto = new DemoDbContext())
            {
                return contexto.TbExemplarEmprestimos
                    .Include(e => e.CodExemplarNavigation)
                    .Include(e => e.CodLeitorNavigation)
                    .OrderBy(e => codigoEmprestimo)
                    .Where(e => e.CodEmprestimo == codigoEmprestimo)
                    .Select(e => new ExemplarEmprestimo
                   {
                        CodEmprestimo = e.CodEmprestimo,
                        CodLeitor = e.CodLeitor,
                        CodExemplar = e.CodExemplar,
                        CodFuncionario = e.CodFuncionario,
                        DataEmprestimo = e.DataEmprestimo,
                        DataDevolucao = e.DataDevolucao,
                        CodReserva = e.CodReserva
                        // Mapeie outras propriedades desejadas
                    })
            .ToList();
            }
        }
    }

}

    
