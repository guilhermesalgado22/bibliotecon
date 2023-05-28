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
    public partial class UserControlReserva : UserControl
    {
        private ICadastrarReservaService _cadastroReserva;
        public UserControlReserva(ICadastrarReservaService reservaService)

        {
            _cadastroReserva = reservaService;
            this.Load += UserControlReserva_Load;
            InitializeComponent();
        }

        public UserControlReserva()
        {
            _cadastroReserva = new CadastrarReservaService(new DemoDbContext());
    
            this.Load += UserControlReserva_Load;
            InitializeComponent();
        }

        private void UserControlReserva_Load(object sender, EventArgs e)
        {
            //InitializeComponent();
            //PopularComboBoxLivros();
           // CarregarFuncionarios();
          //  CarregarLeitores();
           // CarregarExemplar();
          

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
        private void CarregarLeitores()
        {
            using (var context = new DemoDbContext())
            {
                var leitores = context.TbLeitors.OrderBy(l => l.Nome).ToList();
                comboBox2.DataSource = leitores;
                comboBox2.DisplayMember = "Nome";
                comboBox2.ValueMember = "CodLeitor";
            }
        }

        private void CarregarExemplar()
        {
            using (var context = new DemoDbContext())
            {
                var codLivro = int.Parse(comboBox1.SelectedValue.ToString());

                var exemplares = context.TbExemplars
                    .Where(e => e.CodLivro == codLivro)
                    .OrderBy(e => e.CodExemplar)
                    .ToList();

                comboBox3.DataSource = exemplares;
                comboBox3.DisplayMember = "CodExemplar";
                comboBox3.ValueMember = "CodExemplar";
                comboBox1.SelectedIndexChanged+= new EventHandler(comboBox1_SelectedIndexChanged);
                
            }
            
        }
        private void CarregarFuncionarios()
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
        private async  void button1_Click(object sender, EventArgs e)
        {
            var reserva = new CadastrarReservaRequest
            {
                DataReserva = DateOnly.Parse(textBox1.Text),
                CodLivro = (int)comboBox1.SelectedValue,
                CodExemplar = (int)comboBox3.SelectedValue,
                CodLeitor = (int)comboBox2.SelectedValue,
                CodFuncionario = (int)comboBox4.SelectedValue,
                DataDevolucao = DateOnly.Parse(textBox9.Text),
                Status = true,
            };

           
            try
            {
                await _cadastroReserva.CadastrarReservaAsync(reserva); 
                MessageBox.Show("Reserva cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar a reserva: " + ex.Message);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

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

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.GetType() != typeof(Livro))
            {
                CarregarExemplar();
            }
;        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
