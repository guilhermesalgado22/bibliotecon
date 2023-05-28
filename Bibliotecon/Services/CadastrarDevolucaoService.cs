using Bibliotecon.Dto;
using Bibliotecon.Interfaces;
using Bibliotecon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecon.Services
{
    public class CadastrarDevolucaoService : ICadastrarDevolucao
    {
        private readonly DemoDbContext _dbContext;

        public CadastrarDevolucaoService(DemoDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<CadastrarDevolucaoResponse> CadastrarDevolucaoAsync(CadastrarDevolucaoRequest request)
        {
            var emprestimo = await _dbContext.TbExemplarEmprestimos.FindAsync(request.CodEmprestimo);

            if (emprestimo == null)
            {
                throw new Exception("Empréstimo não encontrado");
            }

            var exemplar = await _dbContext.TbExemplars.FindAsync(emprestimo.CodExemplar);

            if (exemplar == null)
            {
                throw new Exception("Exemplar não encontrado");
            }

            // Atualizar o status do exemplar para disponível
            exemplar.Status = true;
            // Calcular a diferença de dias entre as datas de devolução
            int diasAtraso = CalcularDiferencaDias((DateOnly)request.DataDevolucao, (DateOnly)emprestimo.DataDevolucao);

            // Calcular o valor da multa (1 real por dia de atraso)
            decimal multa = diasAtraso * 1;

            // Criar uma nova devolução
            var devolucao = new Devolucao
            {
                CodEmprestimo = request.CodEmprestimo,
                DataDevolucao = request.DataDevolucao,
                CodFuncionario = request.CodFuncionario,
                Multa = (int)multa,
                CodExemplar = emprestimo.CodExemplar,
            };

           

            var response = new CadastrarDevolucaoResponse
            {
                CodEmprestimo = devolucao.CodEmprestimo,
                DataDevolucao = devolucao.DataDevolucao,
                CodFuncionario = devolucao.CodFuncionario,
                Multa = devolucao.Multa,
                CodExemplar = emprestimo.CodExemplar,
                
            };
            _dbContext.TbDevolucaos.Add(devolucao);
            await _dbContext.SaveChangesAsync();
            return response;
            // Adicionar a devolução ao contexto e salvar as alterações
          
        }


        private int CalcularDiferencaDias(DateOnly dataInicio, DateOnly dataFim)
        {
            int dias = 0;
            DateOnly dataAtual = dataInicio;

            while (dataAtual < dataFim)
            {
                dias++;
                dataAtual = dataAtual.AddDays(1);
            }

            return dias;
        }
    }


}
    
