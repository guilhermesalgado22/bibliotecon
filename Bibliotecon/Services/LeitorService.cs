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
    public class LeitorService : ILeitorService
    {
        private readonly DemoDbContext _dbContext;

        public LeitorService(DemoDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<CadastrarLeitorResponse> InserirLeitorAsync(CadastrarLeitorRequest leitor)
        {
            using var transaction = await _dbContext.Database.BeginTransactionAsync();

            try
            {
                var endereco = new Endereco { DescEndereco = leitor.Endereco, Bairro = leitor.Bairro ?? "N/A" };
                _dbContext.TbEnderecos.Add(endereco);

                var cidade = await _dbContext.TbCidades.FirstOrDefaultAsync(c => c.Nome == leitor.Cidade);
                if (cidade == null)
                {
                    cidade = new Cidade { Nome = leitor.Cidade };
                    _dbContext.TbCidades.Add(cidade);
                }

                var novoLeitor = new Leitor
                {
                    Nome = leitor.Nome,
                    Telefone = leitor.Telefone,
                    Sexo = leitor.Sexo,
                    DataNascimento = leitor.DataNascimento,
                    Cpf = leitor.CPF,
                    Rg = leitor.RG,
                    Status = leitor.Status,
                    //Endereco = endereco,
                    //Cidade = cidade
                };
                _dbContext.TbLeitors.Add(novoLeitor);

                await _dbContext.SaveChangesAsync();
                await transaction.CommitAsync();

                return new CadastrarLeitorResponse { CodLeitor = novoLeitor.CodLeitor };
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw ex;
            }
        }

        List<Leitor> ILeitorService.PesquisarLeitor(int codigoLeitor)
        {
            using (var contexto = new DemoDbContext())
            {
                return contexto.TbLeitors
                    .OrderBy(e => codigoLeitor)
                    .Where(e => e.CodLeitor == codigoLeitor)
                    .Select(e => new Leitor
                    {
                        CodLeitor = e.CodLeitor,
                        Nome = e.Nome,
                        Telefone = e.Nome,
                        Sexo = e.Sexo,
                        DataNascimento = e.DataNascimento,
                        Cpf = e.Cpf,
                        Rg = e.Rg
                    })
            .ToList();
            }
        }
    }
}
