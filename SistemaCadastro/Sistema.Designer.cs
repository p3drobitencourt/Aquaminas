namespace SistemaCadastro
{
    partial class Sistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema));
            this.panel1 = new System.Windows.Forms.Panel();
            this.marcador = new System.Windows.Forms.Panel();
            this.btnBusca = new System.Windows.Forms.Button();
            this.btnCadastra = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCadastrar = new System.Windows.Forms.TabPage();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblNomeEspecie = new System.Windows.Forms.Label();
            this.tabBuscar = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEspecieBusca = new System.Windows.Forms.TextBox();
            this.dgEspecie = new System.Windows.Forms.DataGridView();
            this.tabAlterar = new System.Windows.Forms.TabPage();
            this.txtAlteraPreco = new System.Windows.Forms.TextBox();
            this.txtAlteraNome = new System.Windows.Forms.TextBox();
            this.lblPrecoAlt = new System.Windows.Forms.Label();
            this.lblNomeAlt = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEspecie = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnConfirmaCadastro = new System.Windows.Forms.Button();
            this.btnAlterarEspecie = new System.Windows.Forms.Button();
            this.btnRemoveEspecie = new System.Windows.Forms.Button();
            this.btnConfirmaAlteracaoEspecie = new System.Windows.Forms.Button();
            this.lblAlteraEspecie = new System.Windows.Forms.Label();
            this.cbAlteraVenda = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCadastrar.SuspendLayout();
            this.tabBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEspecie)).BeginInit();
            this.tabAlterar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.marcador);
            this.panel1.Controls.Add(this.btnBusca);
            this.panel1.Controls.Add(this.btnCadastra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 435);
            this.panel1.TabIndex = 0;
            // 
            // marcador
            // 
            this.marcador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(176)))), ((int)(((byte)(226)))));
            this.marcador.Location = new System.Drawing.Point(1, 85);
            this.marcador.Name = "marcador";
            this.marcador.Size = new System.Drawing.Size(10, 36);
            this.marcador.TabIndex = 8;
            // 
            // btnBusca
            // 
            this.btnBusca.FlatAppearance.BorderSize = 0;
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnBusca.ForeColor = System.Drawing.Color.White;
            this.btnBusca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusca.Location = new System.Drawing.Point(16, 128);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(131, 49);
            this.btnBusca.TabIndex = 5;
            this.btnBusca.Text = "&Venda";
            this.btnBusca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // btnCadastra
            // 
            this.btnCadastra.FlatAppearance.BorderSize = 0;
            this.btnCadastra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnCadastra.ForeColor = System.Drawing.Color.White;
            this.btnCadastra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastra.Location = new System.Drawing.Point(16, 81);
            this.btnCadastra.Name = "btnCadastra";
            this.btnCadastra.Size = new System.Drawing.Size(131, 49);
            this.btnCadastra.TabIndex = 3;
            this.btnCadastra.Text = "&Espécie";
            this.btnCadastra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastra.UseVisualStyleBackColor = true;
            this.btnCadastra.Click += new System.EventHandler(this.btnCadastra_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(176)))), ((int)(((byte)(226)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(155, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 23);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(45, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(125, 131);
            this.panel3.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCadastrar);
            this.tabControl1.Controls.Add(this.tabBuscar);
            this.tabControl1.Controls.Add(this.tabAlterar);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tabControl1.Location = new System.Drawing.Point(155, 174);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(672, 261);
            this.tabControl1.TabIndex = 9;
            // 
            // tabCadastrar
            // 
            this.tabCadastrar.BackColor = System.Drawing.Color.White;
            this.tabCadastrar.Controls.Add(this.cbEspecie);
            this.tabCadastrar.Controls.Add(this.label1);
            this.tabCadastrar.Controls.Add(this.BtnConfirmaCadastro);
            this.tabCadastrar.Controls.Add(this.txtPreco);
            this.tabCadastrar.Controls.Add(this.txtnome);
            this.tabCadastrar.Controls.Add(this.lblPreco);
            this.tabCadastrar.Controls.Add(this.lblNomeEspecie);
            this.tabCadastrar.Location = new System.Drawing.Point(4, 26);
            this.tabCadastrar.Name = "tabCadastrar";
            this.tabCadastrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastrar.Size = new System.Drawing.Size(664, 231);
            this.tabCadastrar.TabIndex = 0;
            this.tabCadastrar.Text = "Cadastrar";
            // 
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtPreco.Location = new System.Drawing.Point(163, 91);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(480, 27);
            this.txtPreco.TabIndex = 11;
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtnome.Location = new System.Drawing.Point(163, 44);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(480, 29);
            this.txtnome.TabIndex = 9;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblPreco.ForeColor = System.Drawing.Color.DimGray;
            this.lblPreco.Location = new System.Drawing.Point(12, 91);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(58, 21);
            this.lblPreco.TabIndex = 8;
            this.lblPreco.Text = "Preço:";
            // 
            // lblNomeEspecie
            // 
            this.lblNomeEspecie.AutoSize = true;
            this.lblNomeEspecie.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblNomeEspecie.ForeColor = System.Drawing.Color.DimGray;
            this.lblNomeEspecie.Location = new System.Drawing.Point(12, 44);
            this.lblNomeEspecie.Name = "lblNomeEspecie";
            this.lblNomeEspecie.Size = new System.Drawing.Size(61, 21);
            this.lblNomeEspecie.TabIndex = 6;
            this.lblNomeEspecie.Text = "Nome:";
            // 
            // tabBuscar
            // 
            this.tabBuscar.BackColor = System.Drawing.Color.White;
            this.tabBuscar.Controls.Add(this.btnAlterarEspecie);
            this.tabBuscar.Controls.Add(this.btnRemoveEspecie);
            this.tabBuscar.Controls.Add(this.label5);
            this.tabBuscar.Controls.Add(this.txtEspecieBusca);
            this.tabBuscar.Controls.Add(this.dgEspecie);
            this.tabBuscar.Location = new System.Drawing.Point(4, 26);
            this.tabBuscar.Name = "tabBuscar";
            this.tabBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tabBuscar.Size = new System.Drawing.Size(664, 231);
            this.tabBuscar.TabIndex = 1;
            this.tabBuscar.Text = "Buscar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Especie:";
            // 
            // txtEspecieBusca
            // 
            this.txtEspecieBusca.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtEspecieBusca.Location = new System.Drawing.Point(82, 10);
            this.txtEspecieBusca.Margin = new System.Windows.Forms.Padding(2);
            this.txtEspecieBusca.Name = "txtEspecieBusca";
            this.txtEspecieBusca.Size = new System.Drawing.Size(261, 27);
            this.txtEspecieBusca.TabIndex = 1;
            this.txtEspecieBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // dgEspecie
            // 
            this.dgEspecie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEspecie.BackgroundColor = System.Drawing.Color.White;
            this.dgEspecie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEspecie.Location = new System.Drawing.Point(42, 55);
            this.dgEspecie.Margin = new System.Windows.Forms.Padding(2);
            this.dgEspecie.Name = "dgEspecie";
            this.dgEspecie.ReadOnly = true;
            this.dgEspecie.RowHeadersWidth = 51;
            this.dgEspecie.RowTemplate.Height = 29;
            this.dgEspecie.Size = new System.Drawing.Size(598, 189);
            this.dgEspecie.TabIndex = 0;
            // 
            // tabAlterar
            // 
            this.tabAlterar.Controls.Add(this.cbAlteraVenda);
            this.tabAlterar.Controls.Add(this.lblAlteraEspecie);
            this.tabAlterar.Controls.Add(this.txtAlteraPreco);
            this.tabAlterar.Controls.Add(this.txtAlteraNome);
            this.tabAlterar.Controls.Add(this.lblPrecoAlt);
            this.tabAlterar.Controls.Add(this.lblNomeAlt);
            this.tabAlterar.Controls.Add(this.btnConfirmaAlteracaoEspecie);
            this.tabAlterar.Location = new System.Drawing.Point(4, 26);
            this.tabAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.tabAlterar.Name = "tabAlterar";
            this.tabAlterar.Padding = new System.Windows.Forms.Padding(2);
            this.tabAlterar.Size = new System.Drawing.Size(664, 231);
            this.tabAlterar.TabIndex = 2;
            this.tabAlterar.Text = "Alterar";
            this.tabAlterar.UseVisualStyleBackColor = true;
            // 
            // txtAlteraPreco
            // 
            this.txtAlteraPreco.Enabled = false;
            this.txtAlteraPreco.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtAlteraPreco.Location = new System.Drawing.Point(128, 82);
            this.txtAlteraPreco.Name = "txtAlteraPreco";
            this.txtAlteraPreco.Size = new System.Drawing.Size(480, 27);
            this.txtAlteraPreco.TabIndex = 19;
            // 
            // txtAlteraNome
            // 
            this.txtAlteraNome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAlteraNome.Location = new System.Drawing.Point(128, 32);
            this.txtAlteraNome.Name = "txtAlteraNome";
            this.txtAlteraNome.Size = new System.Drawing.Size(480, 29);
            this.txtAlteraNome.TabIndex = 17;
            // 
            // lblPrecoAlt
            // 
            this.lblPrecoAlt.AutoSize = true;
            this.lblPrecoAlt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblPrecoAlt.ForeColor = System.Drawing.Color.DimGray;
            this.lblPrecoAlt.Location = new System.Drawing.Point(8, 82);
            this.lblPrecoAlt.Name = "lblPrecoAlt";
            this.lblPrecoAlt.Size = new System.Drawing.Size(58, 21);
            this.lblPrecoAlt.TabIndex = 16;
            this.lblPrecoAlt.Text = "Preço:";
            // 
            // lblNomeAlt
            // 
            this.lblNomeAlt.AutoSize = true;
            this.lblNomeAlt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblNomeAlt.ForeColor = System.Drawing.Color.DimGray;
            this.lblNomeAlt.Location = new System.Drawing.Point(8, 35);
            this.lblNomeAlt.Name = "lblNomeAlt";
            this.lblNomeAlt.Size = new System.Drawing.Size(61, 21);
            this.lblNomeAlt.TabIndex = 14;
            this.lblNomeAlt.Text = "Nome:";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.ForeColor = System.Drawing.Color.Red;
            this.lblMensagem.Location = new System.Drawing.Point(544, 26);
            this.lblMensagem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 13);
            this.lblMensagem.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(800, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "X";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Espécie:";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbEspecie
            // 
            this.cbEspecie.FormattingEnabled = true;
            this.cbEspecie.Location = new System.Drawing.Point(163, 137);
            this.cbEspecie.Name = "cbEspecie";
            this.cbEspecie.Size = new System.Drawing.Size(480, 25);
            this.cbEspecie.TabIndex = 15;
            this.cbEspecie.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaCadastro.Properties.Resources.psicultura_aqua_minas_transparente2;
            this.pictureBox1.Location = new System.Drawing.Point(200, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(592, 138);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // BtnConfirmaCadastro
            // 
            this.BtnConfirmaCadastro.FlatAppearance.BorderSize = 0;
            this.BtnConfirmaCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmaCadastro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.BtnConfirmaCadastro.ForeColor = System.Drawing.Color.DimGray;
            this.BtnConfirmaCadastro.Image = global::SistemaCadastro.Properties.Resources.adicionar;
            this.BtnConfirmaCadastro.Location = new System.Drawing.Point(285, 173);
            this.BtnConfirmaCadastro.Name = "BtnConfirmaCadastro";
            this.BtnConfirmaCadastro.Size = new System.Drawing.Size(131, 49);
            this.BtnConfirmaCadastro.TabIndex = 13;
            this.BtnConfirmaCadastro.Text = "&Cadastrar";
            this.BtnConfirmaCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmaCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfirmaCadastro.UseVisualStyleBackColor = true;
            this.BtnConfirmaCadastro.Click += new System.EventHandler(this.BtnConfirmaCadastro_Click);
            // 
            // btnAlterarEspecie
            // 
            this.btnAlterarEspecie.FlatAppearance.BorderSize = 0;
            this.btnAlterarEspecie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarEspecie.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAlterarEspecie.ForeColor = System.Drawing.Color.DimGray;
            this.btnAlterarEspecie.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarEspecie.Image")));
            this.btnAlterarEspecie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarEspecie.Location = new System.Drawing.Point(482, 5);
            this.btnAlterarEspecie.Name = "btnAlterarEspecie";
            this.btnAlterarEspecie.Size = new System.Drawing.Size(112, 46);
            this.btnAlterarEspecie.TabIndex = 15;
            this.btnAlterarEspecie.Text = "Alterar";
            this.btnAlterarEspecie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarEspecie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterarEspecie.UseVisualStyleBackColor = true;
            this.btnAlterarEspecie.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnRemoveEspecie
            // 
            this.btnRemoveEspecie.FlatAppearance.BorderSize = 0;
            this.btnRemoveEspecie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveEspecie.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemoveEspecie.ForeColor = System.Drawing.Color.DimGray;
            this.btnRemoveEspecie.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveEspecie.Image")));
            this.btnRemoveEspecie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveEspecie.Location = new System.Drawing.Point(363, 5);
            this.btnRemoveEspecie.Name = "btnRemoveEspecie";
            this.btnRemoveEspecie.Size = new System.Drawing.Size(122, 46);
            this.btnRemoveEspecie.TabIndex = 14;
            this.btnRemoveEspecie.Text = "Remover";
            this.btnRemoveEspecie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveEspecie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveEspecie.UseVisualStyleBackColor = true;
            this.btnRemoveEspecie.Click += new System.EventHandler(this.btnRemoveBanda_Click);
            // 
            // btnConfirmaAlteracaoEspecie
            // 
            this.btnConfirmaAlteracaoEspecie.FlatAppearance.BorderSize = 0;
            this.btnConfirmaAlteracaoEspecie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmaAlteracaoEspecie.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirmaAlteracaoEspecie.ForeColor = System.Drawing.Color.DimGray;
            this.btnConfirmaAlteracaoEspecie.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmaAlteracaoEspecie.Image")));
            this.btnConfirmaAlteracaoEspecie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmaAlteracaoEspecie.Location = new System.Drawing.Point(292, 176);
            this.btnConfirmaAlteracaoEspecie.Name = "btnConfirmaAlteracaoEspecie";
            this.btnConfirmaAlteracaoEspecie.Size = new System.Drawing.Size(131, 49);
            this.btnConfirmaAlteracaoEspecie.TabIndex = 22;
            this.btnConfirmaAlteracaoEspecie.Text = "Confirmar Alteração";
            this.btnConfirmaAlteracaoEspecie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmaAlteracaoEspecie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmaAlteracaoEspecie.UseVisualStyleBackColor = true;
            this.btnConfirmaAlteracaoEspecie.Click += new System.EventHandler(this.btnConfirmaAlteracao_Click);
            // 
            // lblAlteraEspecie
            // 
            this.lblAlteraEspecie.AutoSize = true;
            this.lblAlteraEspecie.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblAlteraEspecie.ForeColor = System.Drawing.Color.DimGray;
            this.lblAlteraEspecie.Location = new System.Drawing.Point(8, 129);
            this.lblAlteraEspecie.Name = "lblAlteraEspecie";
            this.lblAlteraEspecie.Size = new System.Drawing.Size(73, 21);
            this.lblAlteraEspecie.TabIndex = 23;
            this.lblAlteraEspecie.Text = "Espécie:";
            this.lblAlteraEspecie.Visible = false;
            // 
            // cbAlteraVenda
            // 
            this.cbAlteraVenda.FormattingEnabled = true;
            this.cbAlteraVenda.Location = new System.Drawing.Point(128, 130);
            this.cbAlteraVenda.Name = "cbAlteraVenda";
            this.cbAlteraVenda.Size = new System.Drawing.Size(480, 25);
            this.cbAlteraVenda.TabIndex = 24;
            this.cbAlteraVenda.Visible = false;
            // 
            // Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 435);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Sistema_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabCadastrar.ResumeLayout(false);
            this.tabCadastrar.PerformLayout();
            this.tabBuscar.ResumeLayout(false);
            this.tabBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEspecie)).EndInit();
            this.tabAlterar.ResumeLayout(false);
            this.tabAlterar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCadastra;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCadastrar;
        private System.Windows.Forms.TabPage tabBuscar;
        private System.Windows.Forms.Button BtnConfirmaCadastro;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblNomeEspecie;
        private System.Windows.Forms.Panel marcador;
        private System.Windows.Forms.DataGridView dgEspecie;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEspecieBusca;
        private System.Windows.Forms.Button btnRemoveEspecie;
        private System.Windows.Forms.Button btnAlterarEspecie;
        private System.Windows.Forms.TabPage tabAlterar;
        private System.Windows.Forms.Button btnConfirmaAlteracaoEspecie;
        private System.Windows.Forms.TextBox txtAlteraPreco;
        private System.Windows.Forms.TextBox txtAlteraNome;
        private System.Windows.Forms.Label lblPrecoAlt;
        private System.Windows.Forms.Label lblNomeAlt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEspecie;
        private System.Windows.Forms.ComboBox cbAlteraVenda;
        private System.Windows.Forms.Label lblAlteraEspecie;
    }
}