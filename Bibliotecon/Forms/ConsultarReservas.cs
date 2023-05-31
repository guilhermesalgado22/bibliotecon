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
    public partial class ConsultarReservas : Form
    {
        private ICadastrarReservaService _cadastroReserva;
        private DemoDbContext _dbContext;
        public ConsultarReservas()
        {
            _cadastroReserva = new CadastrarReservaService(new DemoDbContext());
            _dbContext = new DemoDbContext();
            InitializeComponent();
            this.Load += ConsultarReservas_Load1;
            dataGridView1.AutoGenerateColumns = true;
        }

        public ConsultarReservas(ICadastrarReservaService cadastrarReserva, DemoDbContext dbContext)
        {
            _cadastroReserva = cadastrarReserva;
            _dbContext = dbContext;
            InitializeComponent();

        }

        private void ConsultarReservas_Load1(object? sender, EventArgs e)
        {
            LoadData();
        }
        private void ConsultarReservas_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (var context = new DemoDbContext())
            {

                var livro = context.TbReserva
                     .Include(e => e.CodExemplarNavigation)
                    .Include(e => e.CodLeitorNavigation)
                    .Include(e => e.CodFuncionarioNavigation)
                    .Select(e => new Reserva
                    {
                        CodReserva = e.CodReserva,
                        CodLeitor = e.CodLeitor,
                        CodExemplar = e.CodExemplar,
                        CodFuncionario = e.CodFuncionario,
                        DataReserva = e.DataReserva,
                        DataDevolucao = e.DataDevolucao,

                        // Mapeie outras propriedades desejadas
                    })
            .ToList();
                dataGridView1.DataSource = livro;

                // Configure o DataSource
                dataGridView1.DataSource = livro;
                dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int codigoReserva))
            {
                List<Reserva> reserva = _cadastroReserva.PesquisarReserva(codigoReserva);

                dataGridView1.AutoGenerateColumns = true;

                dataGridView1.DataSource = reserva;

            }
            else
            {
                MessageBox.Show("Digite um código de empréstimo válido.");
            }
        }
    }
}
