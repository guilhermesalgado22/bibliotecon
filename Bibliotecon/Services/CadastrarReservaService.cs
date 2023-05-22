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
    public class CadastrarReservaService : ICadastrarReservaService
    {
        private readonly DemoDbContext _dbContext;

        public CadastrarReservaService(DemoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CadastrarReservaResponse> CadastrarReservaAsync(CadastrarReservaRequest request)
        {
            try
            {
                // Verificar disponibilidade do exemplar
                bool exemplarDisponivel = await VerificarExemplarDisponivelAsync(request.CodLivro, request.CodExemplar);

                if (exemplarDisponivel == false)
                {
                    throw new Exception("Exemplar não está disponível para reserva");
                }

                var novaReserva = new Reserva
                {
                    DataReserva = request.DataReserva,
                    CodExemplar = request.CodExemplar,
                    CodLeitor = request.CodLeitor,
                    CodFuncionario = request.CodFuncionario,
                    DataDevolucao = request.DataDevolucao,
                };
                var exemplar = await _dbContext.TbExemplars.FindAsync(request.CodExemplar);
                exemplar.Status = false;

                _dbContext.TbReservas.Add(novaReserva);
                await _dbContext.SaveChangesAsync();


                var response = new CadastrarReservaResponse
                {
                    DataReserva = novaReserva.DataReserva,
                    CodExemplar = novaReserva.CodExemplar,
                    CodLeitor = novaReserva.CodLeitor,
                    CodFuncionario = novaReserva.CodFuncionario,
                    DataDevolucao = novaReserva.DataDevolucao,
                    Status = true,
                };

                return response;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao cadastrar a reserva.", ex);
            }
        }



        public async Task<bool> VerificarExemplarDisponivelAsync(int codLivro, int codExemplar)
        {
            try
            {
                using (var context = new DemoDbContext())
                {
                    var exemplar = await context.TbExemplars.FirstOrDefaultAsync(e => e.CodLivro ==codLivro  && e.CodExemplar == codExemplar);

                    if (exemplar == null)
                    {
                        throw new Exception("Exemplar não encontrado");
                    }

                    return exemplar.Status;
                }
            }
            catch (Exception ex)
            {
                // Tratar a exceção conforme necessário
                // Por exemplo, registrar o erro ou lançar uma exceção personalizada
                throw new Exception("Erro ao verificar disponibilidade do exemplar", ex);
            }
        }








    }
}
