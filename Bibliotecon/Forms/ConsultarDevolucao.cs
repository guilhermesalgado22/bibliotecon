using Bibliotecon.Interfaces;
using Bibliotecon.Models;
using Bibliotecon.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotecon
{
    public partial class ConsultarDevolucao : Form
    {
        private ICadastrarDevolucao _cadastroDevolucao;
        private DemoDbContext _dbContext;
        public ConsultarDevolucao()
        {
            _cadastroDevolucao = new CadastrarDevolucaoService(new DemoDbContext());
            _dbContext = new DemoDbContext();
            InitializeComponent();
            this.Load += ConsultarDevolucao_Load1;
            dataGridView1.AutoGenerateColumns = true;
        }

        public ConsultarDevolucao(ICadastrarDevolucao cadastroDevolucao, DemoDbContext dbContext)
        {
            _cadastroDevolucao = cadastroDevolucao;
            _dbContext = dbContext;
            InitializeComponent();
           // dataGridView1.AutoGenerateColumns = false;
            //CarregarTodosEmprestimos();
        }
        private void ConsultarDevolucao_Load1(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadData()
        {
            using (var context = new DemoDbContext())
            {

                var devolucao = context.TbDevolucaos
                     .Include(e => e.CodExemplarNavigation)
                    .Include(e => e.CodEmprestimoNavigation)
                    .Include(e => e.CodFuncionarioNavigation)
                    .Select(d => new Devolucao
                    {
                        CodDevolucao = d.CodDevolucao,
                        CodExemplar = d.CodExemplar,
                        CodEmprestimo = d.CodEmprestimo,
                        DataDevolucao = d.DataDevolucao,
                        Multa = d.Multa,
                        CodFuncionario = d.CodFuncionario,
                        
                        

                    })
                    .ToList();
                dataGridView1.DataSource = devolucao;

                // Configure o DataSource
                dataGridView1.DataSource = devolucao;
                dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int codigoDevolucao))
            {
                List<Devolucao> devolucao = _cadastroDevolucao.PesquisarDevolucao(codigoDevolucao);

                dataGridView1.AutoGenerateColumns = true;


                // Configure o DataSource
                dataGridView1.DataSource = devolucao;

            }
        }
    }
}
