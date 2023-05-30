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
         
            CarregarFuncionarios3();
           
            
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
             
               // comboBox4.SelectedValue = emprestimo.CodFuncionario;

                return true;
            }

            return false;
        }

    }
    }


