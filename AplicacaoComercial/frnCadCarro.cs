using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoComercial
{
    public partial class frnCadCarro : Form
    {
        public frnCadCarro()
        {
            InitializeComponent();
        }

        private void frnCadCarro_Load(object sender, EventArgs e)
        {
            
        }

        private void LimparCampos() 
        {
            txtID.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtAno.Text = "";
            txtPortas.Text = "";
            cboCor.SelectedIndex = 0;
        }

        private void InitializeComponent()
        {
            this.lblID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtPortas = new System.Windows.Forms.TextBox();
            this.cboCor = new System.Windows.Forms.ComboBox();
            this.dgvCarros = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPreencher = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(13, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ano:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Marca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Portas:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(60, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(254, 146);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(60, 37);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(269, 20);
            this.txtMarca.TabIndex = 8;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(60, 63);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(269, 20);
            this.txtModelo.TabIndex = 9;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(60, 89);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 20);
            this.txtAno.TabIndex = 10;
            // 
            // txtPortas
            // 
            this.txtPortas.Location = new System.Drawing.Point(59, 143);
            this.txtPortas.Name = "txtPortas";
            this.txtPortas.Size = new System.Drawing.Size(100, 20);
            this.txtPortas.TabIndex = 11;
            // 
            // cboCor
            // 
            this.cboCor.FormattingEnabled = true;
            this.cboCor.Location = new System.Drawing.Point(59, 115);
            this.cboCor.Name = "cboCor";
            this.cboCor.Size = new System.Drawing.Size(121, 21);
            this.cboCor.TabIndex = 12;
            // 
            // dgvCarros
            // 
            this.dgvCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarros.Location = new System.Drawing.Point(16, 228);
            this.dgvCarros.Name = "dgvCarros";
            this.dgvCarros.Size = new System.Drawing.Size(692, 256);
            this.dgvCarros.TabIndex = 13;
            this.dgvCarros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarros_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPreencher
            // 
            this.btnPreencher.Location = new System.Drawing.Point(497, 146);
            this.btnPreencher.Name = "btnPreencher";
            this.btnPreencher.Size = new System.Drawing.Size(75, 23);
            this.btnPreencher.TabIndex = 15;
            this.btnPreencher.Text = "Preencher";
            this.btnPreencher.UseVisualStyleBackColor = true;
            this.btnPreencher.Click += new System.EventHandler(this.btnPreencher_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(335, 35);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(26, 23);
            this.btnConsultar.TabIndex = 16;
            this.btnConsultar.Text = "...";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(416, 146);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frnCadCarro
            // 
            this.ClientSize = new System.Drawing.Size(720, 496);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnPreencher);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvCarros);
            this.Controls.Add(this.cboCor);
            this.Controls.Add(this.txtPortas);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblID);
            this.MaximizeBox = false;
            this.Name = "frnCadCarro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de carro";
            this.Load += new System.EventHandler(this.frnCadCarro_Load_2);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frnCadCarro_Load_2(object sender, EventArgs e)
        {
            cboCor.DataSource = Enum.GetNames(typeof(Veiculo.Cores));
            dgvCarros.DataSource = Carro.Consultar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (txtID.Text.Length == 0)
            {
                Carro c = new Carro(
                txtMarca.Text,
                txtModelo.Text,
                int.Parse(txtAno.Text),
                (Veiculo.Cores)cboCor.SelectedIndex,
                int.Parse(txtPortas.Text) );

                c.Incluir();

                PreencherGrid(Carro.Consultar());

                MessageBox.Show("Dados cadastrados com sucesso!!!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else 
            {
                Carro c = new Carro(
                    int.Parse(txtID.Text),
                    txtMarca.Text,
                    txtModelo.Text,
                    int.Parse(txtAno.Text),
                    (Veiculo.Cores)cboCor.SelectedIndex,
                    int.Parse(txtPortas.Text) );

                c.Alterar();

                MessageBox.Show("Dados Alterados com sucesso!!!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            PreencherGrid(Carro.Consultar());
            LimparCampos();

        }

        private void btnPreencher_Click(object sender, EventArgs e)
        {
            Carro.Preencher();
            PreencherGrid(Carro.Consultar());

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            PreencherGrid(Carro.Consultar(txtMarca.Text));
        }

        private void dgvCarros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;

            id = (int)dgvCarros["Id", e.RowIndex].Value;
            Carro c = new Carro(id);
            txtID.Text = c.Id.ToString();
            txtMarca.Text = c.Marca;
            txtModelo.Text = c.Modelo;
            txtAno.Text = c.Ano.ToString();
            txtPortas.Text = c.Portas.ToString();
            cboCor.SelectedIndex = (int)c.cor;
        }

        private void PreencherGrid(List<Carro> lista) 
        {
            dgvCarros.DataSource = new BindingList<Carro>(lista);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length != 0)
            {
                Carro.Excluir(int.Parse(txtID.Text));
                MessageBox.Show("Registro excluídos com sucesso!!!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                PreencherGrid(Carro.Consultar());
                LimparCampos();
            }
            else 
            {
                MessageBox.Show("Selecione um registro para excluír.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }
        }
    }
}
