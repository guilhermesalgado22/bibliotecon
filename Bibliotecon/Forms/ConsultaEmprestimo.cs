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
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                // Se o campo de texto está vazio, retorne a pesquisa completa
                LoadData();
            }
            else if (int.TryParse(textBox1.Text, out int codigoEmprestimo))
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
               

            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


