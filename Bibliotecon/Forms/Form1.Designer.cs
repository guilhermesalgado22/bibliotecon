namespace Bibliotecon
{
    public partial class Form1 : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public Form1(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.CadastrarExemplar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Cadastrar_Livros = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.SteelBlue;
            this.panelLeft.Controls.Add(this.CadastrarExemplar);
            this.panelLeft.Controls.Add(this.panel3);
            this.panelLeft.Controls.Add(this.panel2);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.pictureBox3);
            this.panelLeft.Controls.Add(this.button2);
            this.panelLeft.Controls.Add(this.button5);
            this.panelLeft.Controls.Add(this.button4);
            this.panelLeft.Controls.Add(this.button3);
            this.panelLeft.Controls.Add(this.button1);
            this.panelLeft.Controls.Add(this.Cadastrar_Livros);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 69);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(245, 528);
            this.panelLeft.TabIndex = 3;
            // 
            // CadastrarExemplar
            // 
            this.CadastrarExemplar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CadastrarExemplar.FlatAppearance.BorderSize = 0;
            this.CadastrarExemplar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.CadastrarExemplar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CadastrarExemplar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CadastrarExemplar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CadastrarExemplar.ForeColor = System.Drawing.Color.White;
            this.CadastrarExemplar.Image = global::Bibliotecon.Properties.Resources.CadastrarLivros7;
            this.CadastrarExemplar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CadastrarExemplar.Location = new System.Drawing.Point(0, 63);
            this.CadastrarExemplar.Name = "CadastrarExemplar";
            this.CadastrarExemplar.Size = new System.Drawing.Size(239, 64);
            this.CadastrarExemplar.TabIndex = 8;
            this.CadastrarExemplar.Text = "               Cadastrar Exemplares";
            this.CadastrarExemplar.UseVisualStyleBackColor = true;
            this.CadastrarExemplar.Click += new System.EventHandler(this.Cadastrar_Exemplar_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(245, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(245, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(832, 491);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bibliotecon Ltda";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Bibliotecon.Properties.Resources.livro_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(74, 435);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Bibliotecon.Properties.Resources.consulta;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(4, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 73);
            this.button2.TabIndex = 4;
            this.button2.Text = "               Consultas";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Consultar_Selecao_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::Bibliotecon.Properties.Resources.Livros;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(3, 298);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(236, 73);
            this.button5.TabIndex = 7;
            this.button5.Text = "               Realizar Devolução";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Cadastrar_Devolucao_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Bibliotecon.Properties.Resources.checklist2;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(236, 73);
            this.button4.TabIndex = 6;
            this.button4.Text = "            Realizar Empréstimo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Cadastrar_Emprestimo_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::Bibliotecon.Properties.Resources.reserva;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 73);
            this.button3.TabIndex = 5;
            this.button3.Text = "       Realizar Reserva";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.CadastrarReservas_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Bibliotecon.Properties.Resources.usuário;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(4, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 73);
            this.button1.TabIndex = 3;
            this.button1.Text = "        Cadastrar Usuário";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Cadastrar_Leitor_Click);
            // 
            // Cadastrar_Livros
            // 
            this.Cadastrar_Livros.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Cadastrar_Livros.FlatAppearance.BorderSize = 0;
            this.Cadastrar_Livros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Cadastrar_Livros.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Cadastrar_Livros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cadastrar_Livros.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cadastrar_Livros.ForeColor = System.Drawing.Color.White;
            this.Cadastrar_Livros.Image = global::Bibliotecon.Properties.Resources.CadastrarLivros7;
            this.Cadastrar_Livros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cadastrar_Livros.Location = new System.Drawing.Point(3, 3);
            this.Cadastrar_Livros.Name = "Cadastrar_Livros";
            this.Cadastrar_Livros.Size = new System.Drawing.Size(236, 66);
            this.Cadastrar_Livros.TabIndex = 2;
            this.Cadastrar_Livros.Text = "      Cadastrar Livros";
            this.Cadastrar_Livros.UseVisualStyleBackColor = true;
            this.Cadastrar_Livros.Click += new System.EventHandler(this.Cadastrar_Livros_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 69);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Bibliotecon.Properties.Resources.Logonombre;
            this.pictureBox2.Location = new System.Drawing.Point(393, -14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(373, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bibliotecon.Properties.Resources.livro_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(56, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(245, 69);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(832, 528);
            this.panel4.TabIndex = 4;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1077, 597);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelLeft;
        private Label label1;
        private PictureBox pictureBox3;
        private Button button2;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button1;
        private Button Cadastrar_Livros;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button CadastrarExemplar;
    }
}