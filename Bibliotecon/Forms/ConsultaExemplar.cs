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

namespace Bibliotecon.Forms
{
    public partial class ConsultaExemplar : Form
    {
        private IExemplarService _cadastroExemplar;
        private DemoDbContext _dbContext;
        public ConsultaExemplar()
        {
            _cadastroExemplar = new ExemplarService(new DemoDbContext());
            _dbContext = new DemoDbContext();
            InitializeComponent();
            this.Load += ConsultaExemplar_Load1;
            dataGridView1.AutoGenerateColumns = true;
           
        }
        private void ConsultaExemplar_Load1(object? sender, EventArgs e)
        {
            LoadData();
        }

        public ConsultaExemplar(IExemplarService cadastroExemplar, DemoDbContext dbContext)
        {
            _cadastroExemplar = cadastroExemplar;
            _dbContext = dbContext;
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
           
        }

        private void dataGridView1_CellContentLoad(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();

        }

        private void LoadData()
        {
            using (var context = new DemoDbContext())
            {

                var exemplar = context.TbExemplars
                    .Include(u => u.CodFuncionarioNavigation)
                    .Include(u => u.CodLivroNavigation)
                    .Select(u => new 
                    {
                      
                        CodExemplar = u.CodExemplar,
                        CodLivro = u.CodLivro,
                        Titulo = u.CodLivroNavigation.Titulo,
                        CodFuncionario = u.CodFuncionario,
                        NomeFuncionario = u.CodFuncionarioNavigation.Nome
                        
                    }).ToList();
                dataGridView1.DataSource = exemplar;

                // Configure o DataSource
                dataGridView1.DataSource = exemplar;


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int codigoExemplar))
            {
                List<Exemplar> exemplar = _cadastroExemplar.PesquisarExemplar(codigoExemplar);

                dataGridView1.AutoGenerateColumns = true;


                // Configure o DataSource
                dataGridView1.DataSource = exemplar;

            }
            else
            {
                MessageBox.Show("Digite um código de empréstimo válido.");
            }
        }
    }
}
