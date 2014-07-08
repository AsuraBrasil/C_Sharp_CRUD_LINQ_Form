namespace CrudBasicoLinqToSql
{
    partial class frmCadastroDePessoas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroDePessoas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.cbxUf = new System.Windows.Forms.ComboBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.gpbInformacaoPessoa = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgvPessoas = new System.Windows.Forms.DataGridView();
            this.idPessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobreNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ufDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseDeDadosDataSet = new CrudBasicoLinqToSql.baseDeDadosDataSet();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.txtSobrenomePesquisa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNomePesquisa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pessoasTableAdapter = new CrudBasicoLinqToSql.baseDeDadosDataSetTableAdapters.PessoasTableAdapter();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pcbImage1 = new System.Windows.Forms.PictureBox();
            this.pcbSearch = new System.Windows.Forms.PictureBox();
            this.gpbInformacaoPessoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDeDadosDataSet)).BeginInit();
            this.gpbPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sobrenome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rua:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bairro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "UF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Telefone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Celular:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(68, 16);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(142, 20);
            this.txtNome.TabIndex = 8;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(297, 13);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(137, 20);
            this.txtSobrenome.TabIndex = 9;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(68, 42);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(142, 20);
            this.txtRua.TabIndex = 10;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(297, 42);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(137, 20);
            this.txtBairro.TabIndex = 11;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(68, 69);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(142, 20);
            this.txtCidade.TabIndex = 12;
            // 
            // cbxUf
            // 
            this.cbxUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbxUf.Location = new System.Drawing.Point(297, 68);
            this.cbxUf.Name = "cbxUf";
            this.cbxUf.Size = new System.Drawing.Size(85, 21);
            this.cbxUf.TabIndex = 13;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(68, 94);
            this.txtTelefone.Mask = "(00) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 14;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(297, 95);
            this.txtCelular.Mask = "(00) 00000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 20);
            this.txtCelular.TabIndex = 15;
            // 
            // gpbInformacaoPessoa
            // 
            this.gpbInformacaoPessoa.Controls.Add(this.label5);
            this.gpbInformacaoPessoa.Controls.Add(this.txtCelular);
            this.gpbInformacaoPessoa.Controls.Add(this.btnCancelar);
            this.gpbInformacaoPessoa.Controls.Add(this.label1);
            this.gpbInformacaoPessoa.Controls.Add(this.btnExcluir);
            this.gpbInformacaoPessoa.Controls.Add(this.txtTelefone);
            this.gpbInformacaoPessoa.Controls.Add(this.btnAlterar);
            this.gpbInformacaoPessoa.Controls.Add(this.label2);
            this.gpbInformacaoPessoa.Controls.Add(this.btnSalvar);
            this.gpbInformacaoPessoa.Controls.Add(this.cbxUf);
            this.gpbInformacaoPessoa.Controls.Add(this.label3);
            this.gpbInformacaoPessoa.Controls.Add(this.txtCidade);
            this.gpbInformacaoPessoa.Controls.Add(this.label4);
            this.gpbInformacaoPessoa.Controls.Add(this.txtBairro);
            this.gpbInformacaoPessoa.Controls.Add(this.label6);
            this.gpbInformacaoPessoa.Controls.Add(this.txtRua);
            this.gpbInformacaoPessoa.Controls.Add(this.label7);
            this.gpbInformacaoPessoa.Controls.Add(this.txtSobrenome);
            this.gpbInformacaoPessoa.Controls.Add(this.label8);
            this.gpbInformacaoPessoa.Controls.Add(this.txtNome);
            this.gpbInformacaoPessoa.Location = new System.Drawing.Point(12, 12);
            this.gpbInformacaoPessoa.Name = "gpbInformacaoPessoa";
            this.gpbInformacaoPessoa.Size = new System.Drawing.Size(450, 189);
            this.gpbInformacaoPessoa.TabIndex = 16;
            this.gpbInformacaoPessoa.TabStop = false;
            this.gpbInformacaoPessoa.Text = "Informações";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(363, 149);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(174, 149);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 19;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(93, 149);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 18;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(9, 149);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dgvPessoas
            // 
            this.dgvPessoas.AllowUserToAddRows = false;
            this.dgvPessoas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvPessoas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPessoas.AutoGenerateColumns = false;
            this.dgvPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPessoaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.sobreNomeDataGridViewTextBoxColumn,
            this.ruaDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.ufDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn});
            this.dgvPessoas.DataSource = this.pessoasBindingSource;
            this.dgvPessoas.Location = new System.Drawing.Point(12, 207);
            this.dgvPessoas.Name = "dgvPessoas";
            this.dgvPessoas.ReadOnly = true;
            this.dgvPessoas.Size = new System.Drawing.Size(722, 150);
            this.dgvPessoas.TabIndex = 21;
            // 
            // idPessoaDataGridViewTextBoxColumn
            // 
            this.idPessoaDataGridViewTextBoxColumn.DataPropertyName = "IdPessoa";
            this.idPessoaDataGridViewTextBoxColumn.HeaderText = "IdPessoa";
            this.idPessoaDataGridViewTextBoxColumn.Name = "idPessoaDataGridViewTextBoxColumn";
            this.idPessoaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPessoaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 85;
            // 
            // sobreNomeDataGridViewTextBoxColumn
            // 
            this.sobreNomeDataGridViewTextBoxColumn.DataPropertyName = "SobreNome";
            this.sobreNomeDataGridViewTextBoxColumn.HeaderText = "SobreNome";
            this.sobreNomeDataGridViewTextBoxColumn.Name = "sobreNomeDataGridViewTextBoxColumn";
            this.sobreNomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sobreNomeDataGridViewTextBoxColumn.Width = 85;
            // 
            // ruaDataGridViewTextBoxColumn
            // 
            this.ruaDataGridViewTextBoxColumn.DataPropertyName = "Rua";
            this.ruaDataGridViewTextBoxColumn.HeaderText = "Rua";
            this.ruaDataGridViewTextBoxColumn.Name = "ruaDataGridViewTextBoxColumn";
            this.ruaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ruaDataGridViewTextBoxColumn.Width = 85;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            this.bairroDataGridViewTextBoxColumn.ReadOnly = true;
            this.bairroDataGridViewTextBoxColumn.Width = 85;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cidadeDataGridViewTextBoxColumn.Width = 84;
            // 
            // ufDataGridViewTextBoxColumn
            // 
            this.ufDataGridViewTextBoxColumn.DataPropertyName = "Uf";
            this.ufDataGridViewTextBoxColumn.HeaderText = "Uf";
            this.ufDataGridViewTextBoxColumn.Name = "ufDataGridViewTextBoxColumn";
            this.ufDataGridViewTextBoxColumn.ReadOnly = true;
            this.ufDataGridViewTextBoxColumn.Width = 85;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Width = 85;
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "Celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            this.celularDataGridViewTextBoxColumn.ReadOnly = true;
            this.celularDataGridViewTextBoxColumn.Width = 85;
            // 
            // pessoasBindingSource
            // 
            this.pessoasBindingSource.DataMember = "Pessoas";
            this.pessoasBindingSource.DataSource = this.baseDeDadosDataSet;
            // 
            // baseDeDadosDataSet
            // 
            this.baseDeDadosDataSet.DataSetName = "baseDeDadosDataSet";
            this.baseDeDadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gpbPesquisa
            // 
            this.gpbPesquisa.Controls.Add(this.linkLabel1);
            this.gpbPesquisa.Controls.Add(this.txtSobrenomePesquisa);
            this.gpbPesquisa.Controls.Add(this.pcbSearch);
            this.gpbPesquisa.Controls.Add(this.label10);
            this.gpbPesquisa.Controls.Add(this.txtNomePesquisa);
            this.gpbPesquisa.Controls.Add(this.label9);
            this.gpbPesquisa.Location = new System.Drawing.Point(469, 12);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(265, 92);
            this.gpbPesquisa.TabIndex = 22;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Pesquisa de Pessoas";
            // 
            // txtSobrenomePesquisa
            // 
            this.txtSobrenomePesquisa.Location = new System.Drawing.Point(92, 42);
            this.txtSobrenomePesquisa.Name = "txtSobrenomePesquisa";
            this.txtSobrenomePesquisa.Size = new System.Drawing.Size(115, 20);
            this.txtSobrenomePesquisa.TabIndex = 16;
            this.txtSobrenomePesquisa.TextChanged += new System.EventHandler(this.txtNomePesquisa_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Sobrenome:";
            // 
            // txtNomePesquisa
            // 
            this.txtNomePesquisa.Location = new System.Drawing.Point(92, 16);
            this.txtNomePesquisa.Name = "txtNomePesquisa";
            this.txtNomePesquisa.Size = new System.Drawing.Size(115, 20);
            this.txtNomePesquisa.TabIndex = 16;
            this.txtNomePesquisa.TextChanged += new System.EventHandler(this.txtNomePesquisa_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nome:";
            // 
            // pessoasTableAdapter
            // 
            this.pessoasTableAdapter.ClearBeforeFill = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel1.Location = new System.Drawing.Point(49, 67);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(185, 18);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.github.com/RobertOll";
            // 
            // pcbImage1
            // 
            this.pcbImage1.Image = global::CrudBasicoLinqToSql.Properties.Resources.Email_icon;
            this.pcbImage1.Location = new System.Drawing.Point(561, 110);
            this.pcbImage1.Name = "pcbImage1";
            this.pcbImage1.Size = new System.Drawing.Size(89, 91);
            this.pcbImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImage1.TabIndex = 23;
            this.pcbImage1.TabStop = false;
            // 
            // pcbSearch
            // 
            this.pcbSearch.Image = global::CrudBasicoLinqToSql.Properties.Resources.Search_icon;
            this.pcbSearch.Location = new System.Drawing.Point(211, 14);
            this.pcbSearch.Name = "pcbSearch";
            this.pcbSearch.Size = new System.Drawing.Size(52, 49);
            this.pcbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbSearch.TabIndex = 23;
            this.pcbSearch.TabStop = false;
            // 
            // frmCadastroDePessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 366);
            this.Controls.Add(this.pcbImage1);
            this.Controls.Add(this.gpbPesquisa);
            this.Controls.Add(this.dgvPessoas);
            this.Controls.Add(this.gpbInformacaoPessoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCadastroDePessoas";
            this.Text = "Cadastro de Pessoas";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.gpbInformacaoPessoa.ResumeLayout(false);
            this.gpbInformacaoPessoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDeDadosDataSet)).EndInit();
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.ComboBox cbxUf;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.GroupBox gpbInformacaoPessoa;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvPessoas;
        private baseDeDadosDataSet baseDeDadosDataSet;
        private System.Windows.Forms.BindingSource pessoasBindingSource;
        private baseDeDadosDataSetTableAdapters.PessoasTableAdapter pessoasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobreNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ufDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private System.Windows.Forms.TextBox txtSobrenomePesquisa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNomePesquisa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pcbSearch;
        private System.Windows.Forms.PictureBox pcbImage1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

