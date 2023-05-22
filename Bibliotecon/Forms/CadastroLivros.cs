using Bibliotecon.Dto;
using Bibliotecon.Interfaces;
using Bibliotecon.Services;

namespace Bibliotecon
{
    public partial class CadastroLivros : Form
    {

        private readonly ILivroService _livroService;

        public CadastroLivros(ILivroService livroService)
        {
            _livroService = livroService;
            InitializeComponent();
        }


        public CadastroLivros()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Codi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void finalizarcadastrolivro_Click(object sender, EventArgs e)
        {
            var livro = new CadastroLivroRequest
            {
                Titulo = textBox1.Text,
                Autor = textBox5.Text,
                Editora = textBox7.Text,
                AnoPublicacao = Convert.ToInt32(textBox3.Text),
                Categoria = textBox2.Text,
                Status = true
            };
            var response = await _livroService.InserirLivroAsync(livro);
            MessageBox.Show($"Livro cadastrado com sucesso!\nCódigo do livro: {response.CodLivro}");
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void CadastroLivros_Load(object sender, EventArgs e)
        {

        }
    }
}

