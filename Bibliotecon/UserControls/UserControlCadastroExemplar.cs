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
    public partial class UserControlCadastroExemplar : UserControl
    {
        private IExemplarService _exemplarService;
        public UserControlCadastroExemplar(IExemplarService exemplarService)
        {
            
            _exemplarService = exemplarService;
            this.Load += UserControlCadastroExemplar_Load;
            InitializeComponent();
        }


        public UserControlCadastroExemplar()
       {
        _exemplarService = new ExemplarService(new DemoDbContext());
            InitializeComponent();
        }

        private void UserControlCadastroExemplar_Load(object sender, EventArgs e)
        {
            PopularComboBoxLivros();
            CarregarFuncionarios();
            //InitializeComponent();

        }

        private void PopularComboBoxLivros()
        {
            //InitializeComponent();

            using (var context = new DemoDbContext())
            {
                var livros = context.TbLivro.OrderBy(l => l.Titulo).ToList();

                comboBox1.DataSource = livros;
                comboBox1.DisplayMember = "Titulo";
                comboBox1.ValueMember = "CodLivro";
            }
        }

        private void CarregarFuncionarios()
        {
            //InitializeComponent();

            using (var context = new DemoDbContext())
            {
                var funcionarios = context.TbFuncionarios.ToList();

                comboBox2.DataSource = funcionarios;
                comboBox2.DisplayMember = "NomeComCodigo";
                comboBox2.ValueMember = "CodCadastro";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var exemplar = new CadastrarExemplarRequest
            {
                CodLivro = (int)comboBox1.SelectedValue,
                CodFuncionario = (int)comboBox2.SelectedValue,
                Status = true,
                CodExemplar = int.Parse(textBox1.Text)
            };

            await _exemplarService.InserirExemplarAsync(exemplar);

            MessageBox.Show($"Exemplar cadastrado com sucesso!\n Código do exemplar: {exemplar.CodExemplar}");
        }
 
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
    }
}

