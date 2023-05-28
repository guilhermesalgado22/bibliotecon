using Bibliotecon.Dto;
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
    public partial class UserControlDevolucao : UserControl
    {
        private ICadastrarDevolucao _cadastroDevolucao;
        private DemoDbContext _dbContext;
        public UserControlDevolucao(ICadastrarDevolucao cadastrodevolucaoservice, DemoDbContext dbContext)
        {
            _cadastroDevolucao = cadastrodevolucaoservice;
            _dbContext = dbContext;
            this.Load += UserControlDevolucao_Load;
            InitializeComponent();
        }

        public UserControlDevolucao()
        {
            _cadastroDevolucao = new CadastrarDevolucaoService(new DemoDbContext());
            _dbContext = new DemoDbContext();

            this.Load += UserControlDevolucao_Load;
        }
        private void UserControlDevolucao_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            PopularComboBoxLivros3();
            CarregarFuncionarios3();
            CarregarExemplar3();
            CarregarLeitores3();
        }

        private void PopularComboBoxLivros3()
        {
            //InitializeComponent();

            using (var context = new DemoDbContext())
            {
                var livross = context.TbLivro.OrderBy(l => l.Titulo).ToList();

                comboBox1.DataSource = livross;
                comboBox1.DisplayMember = "Titulo";
                comboBox1.ValueMember = "CodLivro";

            }
        }
        private void CarregarLeitores3()
        {
            using (var context = new DemoDbContext())
            {
                var leitores = context.TbLeitors.OrderBy(l => l.Nome).ToList();
                comboBox3.DataSource = leitores;
                comboBox3.DisplayMember = "Nome";
                comboBox3.ValueMember = "CodLeitor";
            }
        }

        private void CarregarExemplar3()
        {
            using (var context = new DemoDbContext())
            {
                var codLivro = int.Parse(comboBox1.SelectedValue.ToString());

                var exemplares = context.TbExemplars
                    .Where(e => e.CodLivro == codLivro)
                    .OrderBy(e => e.CodExemplar)
                    .ToList();

                comboBox2.DataSource = exemplares;
                comboBox2.DisplayMember = "CodExemplar";
                comboBox2.ValueMember = "CodExemplar";
                comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);

            }

        }
        private void CarregarFuncionarios3()
        {
            //InitializeComponent();

            using (var context = new DemoDbContext())
            {
                var funcionarios = context.TbFuncionarios.ToList();

                comboBox4.DataSource = funcionarios;
                comboBox4.DisplayMember = "NomeComCodigo";
                comboBox4.ValueMember = "CodCadastro";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.GetType() != typeof(Livro))
            {
                CarregarExemplar3();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Codi.Text, out int codigoEmprestimo))
            {
                MessageBox.Show("Insira um código válido de empréstimo.");
                return;
            }

            var emprestimo = await _dbContext.TbExemplarEmprestimos.FindAsync(codigoEmprestimo);
          

            if (emprestimo == null)
            {
                MessageBox.Show("Empréstimo não encontrado.");
                return;
            }



            var devolucaoRequest = new CadastrarDevolucaoRequest
            {
                CodEmprestimo = codigoEmprestimo,
                DataDevolucao = DateOnly.Parse(textBox9.Text),
                CodFuncionario = (int)comboBox4.SelectedValue,
                
            };

            var devolucaoResponse = await _cadastroDevolucao.CadastrarDevolucaoAsync(devolucaoRequest);

            var multaMessage = devolucaoResponse.Multa > 0 ? $"Existe uma multa de R${devolucaoResponse.Multa} para esse empréstimo." : "Não há multa para esse empréstimo.";

            MessageBox.Show($"Devolução realizada com sucesso.\n{multaMessage}");

        }

        private async Task Codi_TextChangedAsync(object sender, EventArgs e)
        {
            if (!int.TryParse(Codi.Text, out int codigoEmprestimo))
            {
                return;
            }
            bool emprestimoEncontrado = await CarregarInformacoesEmprestimo(codigoEmprestimo);

            if (!emprestimoEncontrado)
            {
                MessageBox.Show("Código de empréstimo inválido.");
            }
        }
        private async Task<bool> CarregarInformacoesEmprestimo(int codigoEmprestimo)
        {
            var emprestimo = await _dbContext.TbExemplarEmprestimos.FindAsync(codigoEmprestimo);

            if (emprestimo != null)
            {
                comboBox2.SelectedValue = emprestimo.CodExemplar;
                comboBox3.SelectedValue = emprestimo.CodLeitor;
             
               // comboBox4.SelectedValue = emprestimo.CodFuncionario;

                return true;
            }

            return false;
        }

    }
    }


