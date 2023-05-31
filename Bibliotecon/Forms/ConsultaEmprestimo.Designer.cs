namespace Bibliotecon
{
    partial class ConsultaEmprestimo
    {
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.demoDbContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exemplarEmprestimoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbCidadesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbReservaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbDevolucaosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbEnderecosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbEstadosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbExemplarsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbExemplarEmprestimosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbFuncionariosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbLeitorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbLivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbReservasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeTrackerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDbContextBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exemplarEmprestimoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(281, 16);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(213, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "Consultar Empréstimos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bibliotecon.Properties.Resources.LogoLogin;
            this.pictureBox1.Location = new System.Drawing.Point(433, 336);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(783, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 35);
            this.button1.TabIndex = 19;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbCidadesDataGridViewTextBoxColumn,
            this.tbReservaDataGridViewTextBoxColumn,
            this.tbDevolucaosDataGridViewTextBoxColumn,
            this.tbEnderecosDataGridViewTextBoxColumn,
            this.tbEstadosDataGridViewTextBoxColumn,
            this.tbExemplarsDataGridViewTextBoxColumn,
            this.tbExemplarEmprestimosDataGridViewTextBoxColumn,
            this.tbFuncionariosDataGridViewTextBoxColumn,
            this.tbLeitorsDataGridViewTextBoxColumn,
            this.tbLivroDataGridViewTextBoxColumn,
            this.tbReservasDataGridViewTextBoxColumn,
            this.databaseDataGridViewTextBoxColumn,
            this.changeTrackerDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.contextIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.demoDbContextBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(110, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(764, 210);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // demoDbContextBindingSource
            // 
            this.demoDbContextBindingSource.DataSource = typeof(Bibliotecon.Models.DemoDbContext);
            // 
            // exemplarEmprestimoBindingSource
            // 
            this.exemplarEmprestimoBindingSource.DataSource = typeof(Bibliotecon.Models.ExemplarEmprestimo);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(587, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 36);
            this.textBox1.TabIndex = 26;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbCidadesDataGridViewTextBoxColumn
            // 
            this.tbCidadesDataGridViewTextBoxColumn.DataPropertyName = "TbCidades";
            this.tbCidadesDataGridViewTextBoxColumn.HeaderText = "TbCidades";
            this.tbCidadesDataGridViewTextBoxColumn.Name = "tbCidadesDataGridViewTextBoxColumn";
            // 
            // tbReservaDataGridViewTextBoxColumn
            // 
            this.tbReservaDataGridViewTextBoxColumn.DataPropertyName = "TbReserva";
            this.tbReservaDataGridViewTextBoxColumn.HeaderText = "TbReserva";
            this.tbReservaDataGridViewTextBoxColumn.Name = "tbReservaDataGridViewTextBoxColumn";
            // 
            // tbDevolucaosDataGridViewTextBoxColumn
            // 
            this.tbDevolucaosDataGridViewTextBoxColumn.DataPropertyName = "TbDevolucaos";
            this.tbDevolucaosDataGridViewTextBoxColumn.HeaderText = "TbDevolucaos";
            this.tbDevolucaosDataGridViewTextBoxColumn.Name = "tbDevolucaosDataGridViewTextBoxColumn";
            // 
            // tbEnderecosDataGridViewTextBoxColumn
            // 
            this.tbEnderecosDataGridViewTextBoxColumn.DataPropertyName = "TbEnderecos";
            this.tbEnderecosDataGridViewTextBoxColumn.HeaderText = "TbEnderecos";
            this.tbEnderecosDataGridViewTextBoxColumn.Name = "tbEnderecosDataGridViewTextBoxColumn";
            // 
            // tbEstadosDataGridViewTextBoxColumn
            // 
            this.tbEstadosDataGridViewTextBoxColumn.DataPropertyName = "TbEstados";
            this.tbEstadosDataGridViewTextBoxColumn.HeaderText = "TbEstados";
            this.tbEstadosDataGridViewTextBoxColumn.Name = "tbEstadosDataGridViewTextBoxColumn";
            // 
            // tbExemplarsDataGridViewTextBoxColumn
            // 
            this.tbExemplarsDataGridViewTextBoxColumn.DataPropertyName = "TbExemplars";
            this.tbExemplarsDataGridViewTextBoxColumn.HeaderText = "TbExemplars";
            this.tbExemplarsDataGridViewTextBoxColumn.Name = "tbExemplarsDataGridViewTextBoxColumn";
            // 
            // tbExemplarEmprestimosDataGridViewTextBoxColumn
            // 
            this.tbExemplarEmprestimosDataGridViewTextBoxColumn.DataPropertyName = "TbExemplarEmprestimos";
            this.tbExemplarEmprestimosDataGridViewTextBoxColumn.HeaderText = "TbExemplarEmprestimos";
            this.tbExemplarEmprestimosDataGridViewTextBoxColumn.Name = "tbExemplarEmprestimosDataGridViewTextBoxColumn";
            // 
            // tbFuncionariosDataGridViewTextBoxColumn
            // 
            this.tbFuncionariosDataGridViewTextBoxColumn.DataPropertyName = "TbFuncionarios";
            this.tbFuncionariosDataGridViewTextBoxColumn.HeaderText = "TbFuncionarios";
            this.tbFuncionariosDataGridViewTextBoxColumn.Name = "tbFuncionariosDataGridViewTextBoxColumn";
            // 
            // tbLeitorsDataGridViewTextBoxColumn
            // 
            this.tbLeitorsDataGridViewTextBoxColumn.DataPropertyName = "TbLeitors";
            this.tbLeitorsDataGridViewTextBoxColumn.HeaderText = "TbLeitors";
            this.tbLeitorsDataGridViewTextBoxColumn.Name = "tbLeitorsDataGridViewTextBoxColumn";
            // 
            // tbLivroDataGridViewTextBoxColumn
            // 
            this.tbLivroDataGridViewTextBoxColumn.DataPropertyName = "TbLivro";
            this.tbLivroDataGridViewTextBoxColumn.HeaderText = "TbLivro";
            this.tbLivroDataGridViewTextBoxColumn.Name = "tbLivroDataGridViewTextBoxColumn";
            // 
            // tbReservasDataGridViewTextBoxColumn
            // 
            this.tbReservasDataGridViewTextBoxColumn.DataPropertyName = "TbReservas";
            this.tbReservasDataGridViewTextBoxColumn.HeaderText = "TbReservas";
            this.tbReservasDataGridViewTextBoxColumn.Name = "tbReservasDataGridViewTextBoxColumn";
            // 
            // databaseDataGridViewTextBoxColumn
            // 
            this.databaseDataGridViewTextBoxColumn.DataPropertyName = "Database";
            this.databaseDataGridViewTextBoxColumn.HeaderText = "Database";
            this.databaseDataGridViewTextBoxColumn.Name = "databaseDataGridViewTextBoxColumn";
            this.databaseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // changeTrackerDataGridViewTextBoxColumn
            // 
            this.changeTrackerDataGridViewTextBoxColumn.DataPropertyName = "ChangeTracker";
            this.changeTrackerDataGridViewTextBoxColumn.HeaderText = "ChangeTracker";
            this.changeTrackerDataGridViewTextBoxColumn.Name = "changeTrackerDataGridViewTextBoxColumn";
            this.changeTrackerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contextIdDataGridViewTextBoxColumn
            // 
            this.contextIdDataGridViewTextBoxColumn.DataPropertyName = "ContextId";
            this.contextIdDataGridViewTextBoxColumn.HeaderText = "ContextId";
            this.contextIdDataGridViewTextBoxColumn.Name = "contextIdDataGridViewTextBoxColumn";
            this.contextIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ConsultaEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1020, 452);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "ConsultaEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaEmprestimo";
            this.Load += new System.EventHandler(this.ConsultaEmprestimo_Load1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDbContextBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exemplarEmprestimoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private BindingSource exemplarEmprestimoBindingSource;
        private TextBox textBox1;
        private BindingSource demoDbContextBindingSource;
        private DataGridViewTextBoxColumn tbCidadesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tbReservaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tbDevolucaosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tbEnderecosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tbEstadosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tbExemplarsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tbExemplarEmprestimosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tbFuncionariosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tbLeitorsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tbLivroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tbReservasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn databaseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn changeTrackerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contextIdDataGridViewTextBoxColumn;
    }
}