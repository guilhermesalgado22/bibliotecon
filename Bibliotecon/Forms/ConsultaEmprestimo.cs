using Bibliotecon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibliotecon.Services;
using Bibliotecon.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Bibliotecon
{
    public partial class ConsultaEmprestimo : Form
    {
        private ICadastrarEmprestimo _cadastroEmprestimo;
        private DemoDbContext _dbContext;

        public ConsultaEmprestimo()
        {
            _cadastroEmprestimo = new CadastrarEmprestimoService(new DemoDbContext());
            _dbContext = new DemoDbContext();
            InitializeComponent();
            this.Load += ConsultaEmprestimo_Load1;
            dataGridView1.AutoGenerateColumns = true;
            //CarregarTodosEmprestimos();

            
          
        }

        private void ConsultaEmprestimo_Load1(object? sender, EventArgs e)
        {
            LoadData();
        }

        public ConsultaEmprestimo(ICadastrarEmprestimo cadastroEmprestimo, DemoDbContext dbContext)
        {
            _cadastroEmprestimo = cadastroEmprestimo;
            _dbContext = dbContext;
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
            //CarregarTodosEmprestimos();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Excluir" && e.RowIndex != -1)
            {
                // Confirmar a exclusão com o usuário
                DialogResult result = MessageBox.Show("Tem certeza de que deseja excluir este empréstimo?", "Confirmação", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Obter o código do empréstimo a ser excluído
                    int codigoEmprestimo = (int)dataGridView1.Rows[e.RowIndex].Cells["Codigo"].Value;

                    // Excluir o empréstimo do banco de dados
                    using (var contexto = new DemoDbContext())
                    {
                        try
                        {
                            var emprestimo = contexto.TbExemplarEmprestimos.FirstOrDefault(e => e.CodEmprestimo == codigoEmprestimo);

                            if (emprestimo != null)
                            {
                                // Remove o empréstimo
                                contexto.TbExemplarEmprestimos.Remove(emprestimo);
                                contexto.SaveChanges();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro ao excluir empréstimo: {ex.Message}");
                        }
                    }

                    // Atualizar o DataGridView
                    LoadData();
                }
            }




        }

        private void dataGridView1_CellContentLoad(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int codigoEmprestimo))
            {
                List<ExemplarEmprestimo> emprestimos = _cadastroEmprestimo.PesquisarEmprestimos(codigoEmprestimo);
                
                dataGridView1.AutoGenerateColumns = true;
      

                // Configure o DataSource
                dataGridView1.DataSource = emprestimos;
                
            }
            else
            {
                MessageBox.Show("Digite um código de empréstimo válido.");
            }
        }

       
        private void LoadData()
        {
            using (var context = new DemoDbContext())
            {
               
                var emprestimoss = context.TbExemplarEmprestimos
                    .Include(u => u.CodLeitorNavigation)
                    .Select(u => new
                {
                    CodEmprestimo = u.CodEmprestimo,
                    Leitor = u.CodLeitorNavigation.Nome,
                    Exemplar = u.CodExemplar,
                    CodFuncionario = u.CodFuncionario,
                    DataEmprestimo = u.DataEmprestimo,
                    DataDevolucao = u.DataDevolucao,
                    CodReserva = u.CodReserva
                    }).ToList();
                dataGridView1.DataSource = emprestimoss;

                // Configure o DataSource
                dataGridView1.DataSource = emprestimoss;
                dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    
      
    }
}


