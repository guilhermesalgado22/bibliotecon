using Bibliotecon.Interfaces;
using Bibliotecon.Models;
using Bibliotecon.Services;
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
    public partial class ConsultarLeitor : Form
    {
        private ILeitorService _cadastroLeitor;
        private DemoDbContext _dbContext;
        public ConsultarLeitor()
        {
            _cadastroLeitor = new LeitorService(new DemoDbContext());
            _dbContext = new DemoDbContext();
            InitializeComponent();
            this.Load += ConsultarLeitor_Load1;
            dataGridView1.AutoGenerateColumns = true;

        }

        public ConsultarLeitor(ILeitorService cadastroLeitor, DemoDbContext dbContext)
        {
            _cadastroLeitor = cadastroLeitor;
            _dbContext = dbContext;
            InitializeComponent();

        }

        private void ConsultarLeitor_Load1(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (var context = new DemoDbContext())
            {

                var leitor = context.TbLeitors
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
                dataGridView1.DataSource = leitor;

                // Configure o DataSource
                dataGridView1.DataSource = leitor;
                dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int codigoleitor))
            {
                List<Leitor> leitor = _cadastroLeitor.PesquisarLeitor(codigoleitor);

                dataGridView1.AutoGenerateColumns = true;


                // Configure o DataSource
                dataGridView1.DataSource = leitor;
            }
        }
    }
}
