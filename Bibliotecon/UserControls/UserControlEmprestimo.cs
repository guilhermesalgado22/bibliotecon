using Bibliotecon.Dto;
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
//aqui teste
namespace Bibliotecon
{
    public partial class UserControlEmprestimo : UserControl
    {
        private ICadastrarEmprestimo _cadastroEmprestimo;
        private DemoDbContext _dbContext;
        
        public UserControlEmprestimo(ICadastrarEmprestimo emprestimoservice, DemoDbContext dbContext)
        {
            _cadastroEmprestimo = emprestimoservice;
            _dbContext = dbContext;
            this.Load += UserControlEmprestimo_Load;
            InitializeComponent();
        }

        public UserControlEmprestimo()
        {
            _cadastroEmprestimo = new CadastrarEmprestimoService(new DemoDbContext());
            _dbContext = new DemoDbContext();

            this.Load += UserControlEmprestimo_Load;
         //   InitializeComponent();
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                int? codReserva = null;
                bool emprestimoRealizado = false;

                if (!string.IsNullOrEmpty(textBox2.Text) && int.TryParse(textBox2.Text, out int reserva))
                {
                    codReserva = reserva;
                }

                if (codReserva.HasValue)
                {
                    // Consultar a reserva pelo código
                    var reservas = await _dbContext.TbReservas.FindAsync(codReserva.Value);

                    if (reservas != null)
                    {
                        // Preencher os campos com as informações da reserva
                        comboBox2.SelectedValue = reservas.CodLeitor;
                        comboBox3.SelectedValue = reservas.CodExemplar;
                        comboBox4.SelectedValue = reservas.CodFuncionario;

                        // Verificar se o empréstimo já foi realizado com base na reserva
                        var emprestimoExistente = await _dbContext.TbExemplarEmprestimos.FirstOrDefaultAsync(emp => emp.CodReserva == codReserva.Value);

                        if (emprestimoExistente == null)
                        {
                            // Criar um novo empréstimo com base na reserva
                            var emprestimoRequests = new CadastrarEmprestimoRequest
                            {
                                CodLivro = (int)comboBox1.SelectedValue,
                                CodExemplar = reservas.CodExemplar,
                                CodLeitor = reservas.CodLeitor,
                                CodFuncionario = reservas.CodFuncionario,
                                DataEmprestimo = DateOnly.Parse(textBox1.Text),
                                DataDevolucao = DateOnly.Parse(textBox9.Text),
                                CodReserva = codReserva.Value
                            };

                            var emprestimoResponses = await _cadastroEmprestimo.CadastrarEmprestimoAsync(emprestimoRequests);

                            // Exibir uma mensagem de sucesso
                            MessageBox.Show("Empréstimo com base em uma reserva realizado com sucesso!");

                            // Encerrar o método após realizar o empréstimo
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Reserva não encontrada.");
                        return;
                    }
                }

                // Criar um novo empréstimo sem reserva
                var emprestimoRequest = new CadastrarEmprestimoRequest
                {
                    CodLivro = (int)comboBox1.SelectedValue,
                    CodExemplar = (int)comboBox2.SelectedValue,
                    CodLeitor = (int)comboBox3.SelectedValue,
                    CodFuncionario = (int)comboBox4.SelectedValue,
                    DataEmprestimo = DateOnly.Parse(textBox1.Text),
                    DataDevolucao = DateOnly.Parse(textBox9.Text)
                };

                var emprestimoResponse = await _cadastroEmprestimo.CadastrarEmprestimoAsync(emprestimoRequest);


                // Exibir uma mensagem de sucesso
                MessageBox.Show("Empréstimo realizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar o empréstimo: " + ex.Message);
            }
        }
        private void UserControlEmprestimo_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            PopularComboBoxLivros2();
            CarregarFuncionarios2();
            CarregarExemplar2();
            CarregarLeitores2();
        }

        private void PopularComboBoxLivros2()
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
        private void CarregarLeitores2()
        {
            using (var context = new DemoDbContext())
            {
                var leitores = context.TbLeitors.OrderBy(l => l.Nome).ToList();
                comboBox3.DataSource = leitores;
                comboBox3.DisplayMember = "Nome";
                comboBox3.ValueMember = "CodLeitor";
            }
        }

        private void CarregarExemplar2()
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
        private void CarregarFuncionarios2()
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
                CarregarExemplar2();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
