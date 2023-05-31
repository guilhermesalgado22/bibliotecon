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
    public partial class ConsultarLivros : Form
    {
        private ILivroService _cadastroLivro;
        private DemoDbContext _dbContext;
        public ConsultarLivros()
        {
            _cadastroLivro = new LivroService(new DemoDbContext());
            _dbContext = new DemoDbContext();
            InitializeComponent();
            this.Load += ConsultarLivros_Load1;
            dataGridView1.AutoGenerateColumns = true;
           
        }
        public ConsultarLivros(ILivroService cadastroLivro, DemoDbContext dbContext)
        {
            _cadastroLivro = cadastroLivro;
            _dbContext = dbContext;
            InitializeComponent();

        }
        private void ConsultarLivros_Load1(object? sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            using (var context = new DemoDbContext())
            {

                var livro = context.TbLivro
                    .Select(e => new Livro
                    {
                        CodLivro = e.CodLivro,
                        Titulo = e.Titulo,
                        Autor = e.Autor,
                        Editora = e.Editora,
                        AnoPublicacao = e.AnoPublicacao,
                        Categoria = e.Categoria,
                        Status = e.Status
                    })
                    .ToList();
                dataGridView1.DataSource = livro;

                // Configure o DataSource
                dataGridView1.DataSource = livro;
                dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int codigolivro))
            {
                List<Livro> livros = _cadastroLivro.PesquisarLivros(codigolivro);

                dataGridView1.AutoGenerateColumns = true;


                // Configure o DataSource
                dataGridView1.DataSource = livros;
            }
        }
    }
}
