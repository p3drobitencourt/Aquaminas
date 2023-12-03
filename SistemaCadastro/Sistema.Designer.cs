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
            this.BtnConfirmaCadastro = new System.Windows.Forms.Button();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblNomeEspecie = new System.Windows.Forms.Label();
            this.tabBuscar = new System.Windows.Forms.TabPage();
            this.btnAlterarEspecie = new System.Windows.Forms.Button();
            this.btnRemoveEspecie = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEspecieBusca = new System.Windows.Forms.TextBox();
            this.dgEspecie = new System.Windows.Forms.DataGridView();
            this.tabAlterar = new System.Windows.Forms.TabPage();
            this.txtAlteraPreco = new System.Windows.Forms.TextBox();
            this.txtAlteraNome = new System.Windows.Forms.TextBox();
            this.lblPrecoAlt = new System.Windows.Forms.Label();
            this.lblNomeAlt = new System.Windows.Forms.Label();
            this.btnConfirmaAlteracaoEspecie = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 535);
            this.panel1.TabIndex = 0;
            // 
            // marcador
            // 
            this.marcador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(176)))), ((int)(((byte)(226)))));
            this.marcador.Location = new System.Drawing.Point(1, 105);
            this.marcador.Margin = new System.Windows.Forms.Padding(4);
            this.marcador.Name = "marcador";
            this.marcador.Size = new System.Drawing.Size(13, 44);
            this.marcador.TabIndex = 8;
            // 
            // btnBusca
            // 
            this.btnBusca.FlatAppearance.BorderSize = 0;
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnBusca.ForeColor = System.Drawing.Color.White;
            this.btnBusca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusca.Location = new System.Drawing.Point(22, 157);
            this.btnBusca.Margin = new System.Windows.Forms.Padding(4);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(175, 60);
            this.btnBusca.TabIndex = 5;
            this.btnBusca.Text = "&Buscar";
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
            this.btnCadastra.Location = new System.Drawing.Point(22, 100);
            this.btnCadastra.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastra.Name = "btnCadastra";
            this.btnCadastra.Size = new System.Drawing.Size(175, 60);
            this.btnCadastra.TabIndex = 3;
            this.btnCadastra.Text = "&Cadastrar";
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
            this.panel2.Location = new System.Drawing.Point(207, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(896, 28);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(60, 46);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 161);
            this.panel3.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCadastrar);
            this.tabControl1.Controls.Add(this.tabBuscar);
            this.tabControl1.Controls.Add(this.tabAlterar);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tabControl1.Location = new System.Drawing.Point(207, 193);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(896, 342);
            this.tabControl1.TabIndex = 9;
            // 
            // tabCadastrar
            // 
            this.tabCadastrar.BackColor = System.Drawing.Color.White;
            this.tabCadastrar.Controls.Add(this.BtnConfirmaCadastro);
            this.tabCadastrar.Controls.Add(this.txtPreco);
            this.tabCadastrar.Controls.Add(this.txtnome);
            this.tabCadastrar.Controls.Add(this.lblPreco);
            this.tabCadastrar.Controls.Add(this.lblNomeEspecie);
            this.tabCadastrar.Location = new System.Drawing.Point(4, 30);
            this.tabCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.tabCadastrar.Name = "tabCadastrar";
            this.tabCadastrar.Padding = new System.Windows.Forms.Padding(4);
            this.tabCadastrar.Size = new System.Drawing.Size(888, 308);
            this.tabCadastrar.TabIndex = 0;
            this.tabCadastrar.Text = "Cadastrar";
            // 
            // BtnConfirmaCadastro
            // 
            this.BtnConfirmaCadastro.FlatAppearance.BorderSize = 0;
            this.BtnConfirmaCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmaCadastro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.BtnConfirmaCadastro.ForeColor = System.Drawing.Color.DimGray;
            this.BtnConfirmaCadastro.Image = global::SistemaCadastro.Properties.Resources.adicionar;
            this.BtnConfirmaCadastro.Location = new System.Drawing.Point(380, 213);
            this.BtnConfirmaCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConfirmaCadastro.Name = "BtnConfirmaCadastro";
            this.BtnConfirmaCadastro.Size = new System.Drawing.Size(175, 60);
            this.BtnConfirmaCadastro.TabIndex = 13;
            this.BtnConfirmaCadastro.Text = "&Cadastrar";
            this.BtnConfirmaCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmaCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfirmaCadastro.UseVisualStyleBackColor = true;
            this.BtnConfirmaCadastro.Click += new System.EventHandler(this.BtnConfirmaCadastro_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtPreco.Location = new System.Drawing.Point(176, 112);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(639, 32);
            this.txtPreco.TabIndex = 11;
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtnome.Location = new System.Drawing.Point(176, 54);
            this.txtnome.Margin = new System.Windows.Forms.Padding(4);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(639, 34);
            this.txtnome.TabIndex = 9;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblPreco.ForeColor = System.Drawing.Color.DimGray;
            this.lblPreco.Location = new System.Drawing.Point(16, 112);
            this.lblPreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(67, 23);
            this.lblPreco.TabIndex = 8;
            this.lblPreco.Text = "Preço";
            // 
            // lblNomeEspecie
            // 
            this.lblNomeEspecie.AutoSize = true;
            this.lblNomeEspecie.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblNomeEspecie.ForeColor = System.Drawing.Color.DimGray;
            this.lblNomeEspecie.Location = new System.Drawing.Point(16, 54);
            this.lblNomeEspecie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeEspecie.Name = "lblNomeEspecie";
            this.lblNomeEspecie.Size = new System.Drawing.Size(75, 23);
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
            this.tabBuscar.Location = new System.Drawing.Point(4, 30);
            this.tabBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.tabBuscar.Name = "tabBuscar";
            this.tabBuscar.Padding = new System.Windows.Forms.Padding(4);
            this.tabBuscar.Size = new System.Drawing.Size(888, 308);
            this.tabBuscar.TabIndex = 1;
            this.tabBuscar.Text = "Buscar";
            // 
            // btnAlterarEspecie
            // 
            this.btnAlterarEspecie.FlatAppearance.BorderSize = 0;
            this.btnAlterarEspecie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarEspecie.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAlterarEspecie.ForeColor = System.Drawing.Color.DimGray;
            this.btnAlterarEspecie.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarEspecie.Image")));
            this.btnAlterarEspecie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarEspecie.Location = new System.Drawing.Point(643, 6);
            this.btnAlterarEspecie.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterarEspecie.Name = "btnAlterarEspecie";
            this.btnAlterarEspecie.Size = new System.Drawing.Size(149, 56);
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
            this.btnRemoveEspecie.Location = new System.Drawing.Point(484, 6);
            this.btnRemoveEspecie.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveEspecie.Name = "btnRemoveEspecie";
            this.btnRemoveEspecie.Size = new System.Drawing.Size(163, 56);
            this.btnRemoveEspecie.TabIndex = 14;
            this.btnRemoveEspecie.Text = "Remover";
            this.btnRemoveEspecie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveEspecie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveEspecie.UseVisualStyleBackColor = true;
            this.btnRemoveEspecie.Click += new System.EventHandler(this.btnRemoveBanda_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Especie:";
            // 
            // txtEspecieBusca
            // 
            this.txtEspecieBusca.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtEspecieBusca.Location = new System.Drawing.Point(109, 12);
            this.txtEspecieBusca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEspecieBusca.Name = "txtEspecieBusca";
            this.txtEspecieBusca.Size = new System.Drawing.Size(347, 32);
            this.txtEspecieBusca.TabIndex = 1;
            this.txtEspecieBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // dgEspecie
            // 
            this.dgEspecie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEspecie.BackgroundColor = System.Drawing.Color.White;
            this.dgEspecie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEspecie.Location = new System.Drawing.Point(56, 68);
            this.dgEspecie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgEspecie.Name = "dgEspecie";
            this.dgEspecie.ReadOnly = true;
            this.dgEspecie.RowHeadersWidth = 51;
            this.dgEspecie.RowTemplate.Height = 29;
            this.dgEspecie.Size = new System.Drawing.Size(797, 233);
            this.dgEspecie.TabIndex = 0;
            // 
            // tabAlterar
            // 
            this.tabAlterar.Controls.Add(this.txtAlteraPreco);
            this.tabAlterar.Controls.Add(this.txtAlteraNome);
            this.tabAlterar.Controls.Add(this.lblPrecoAlt);
            this.tabAlterar.Controls.Add(this.lblNomeAlt);
            this.tabAlterar.Controls.Add(this.btnConfirmaAlteracaoEspecie);
            this.tabAlterar.Location = new System.Drawing.Point(4, 30);
            this.tabAlterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAlterar.Name = "tabAlterar";
            this.tabAlterar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAlterar.Size = new System.Drawing.Size(888, 308);
            this.tabAlterar.TabIndex = 2;
            this.tabAlterar.Text = "Alterar";
            this.tabAlterar.UseVisualStyleBackColor = true;
            // 
            // txtAlteraPreco
            // 
            this.txtAlteraPreco.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtAlteraPreco.Location = new System.Drawing.Point(170, 128);
            this.txtAlteraPreco.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlteraPreco.Name = "txtAlteraPreco";
            this.txtAlteraPreco.Size = new System.Drawing.Size(639, 32);
            this.txtAlteraPreco.TabIndex = 19;
            // 
            // txtAlteraNome
            // 
            this.txtAlteraNome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAlteraNome.Location = new System.Drawing.Point(170, 67);
            this.txtAlteraNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlteraNome.Name = "txtAlteraNome";
            this.txtAlteraNome.Size = new System.Drawing.Size(639, 34);
            this.txtAlteraNome.TabIndex = 17;
            // 
            // lblPrecoAlt
            // 
            this.lblPrecoAlt.AutoSize = true;
            this.lblPrecoAlt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblPrecoAlt.ForeColor = System.Drawing.Color.DimGray;
            this.lblPrecoAlt.Location = new System.Drawing.Point(10, 128);
            this.lblPrecoAlt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecoAlt.Name = "lblPrecoAlt";
            this.lblPrecoAlt.Size = new System.Drawing.Size(72, 23);
            this.lblPrecoAlt.TabIndex = 16;
            this.lblPrecoAlt.Text = "Preço:";
            // 
            // lblNomeAlt
            // 
            this.lblNomeAlt.AutoSize = true;
            this.lblNomeAlt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblNomeAlt.ForeColor = System.Drawing.Color.DimGray;
            this.lblNomeAlt.Location = new System.Drawing.Point(10, 78);
            this.lblNomeAlt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeAlt.Name = "lblNomeAlt";
            this.lblNomeAlt.Size = new System.Drawing.Size(75, 23);
            this.lblNomeAlt.TabIndex = 14;
            this.lblNomeAlt.Text = "Nome:";
            // 
            // btnConfirmaAlteracaoEspecie
            // 
            this.btnConfirmaAlteracaoEspecie.FlatAppearance.BorderSize = 0;
            this.btnConfirmaAlteracaoEspecie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmaAlteracaoEspecie.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirmaAlteracaoEspecie.ForeColor = System.Drawing.Color.DimGray;
            this.btnConfirmaAlteracaoEspecie.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmaAlteracaoEspecie.Image")));
            this.btnConfirmaAlteracaoEspecie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmaAlteracaoEspecie.Location = new System.Drawing.Point(390, 216);
            this.btnConfirmaAlteracaoEspecie.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmaAlteracaoEspecie.Name = "btnConfirmaAlteracaoEspecie";
            this.btnConfirmaAlteracaoEspecie.Size = new System.Drawing.Size(175, 60);
            this.btnConfirmaAlteracaoEspecie.TabIndex = 22;
            this.btnConfirmaAlteracaoEspecie.Text = "Confirmar Alteração";
            this.btnConfirmaAlteracaoEspecie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmaAlteracaoEspecie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmaAlteracaoEspecie.UseVisualStyleBackColor = true;
            this.btnConfirmaAlteracaoEspecie.Click += new System.EventHandler(this.btnConfirmaAlteracao_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.ForeColor = System.Drawing.Color.Red;
            this.lblMensagem.Location = new System.Drawing.Point(726, 32);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 16);
            this.lblMensagem.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaCadastro.Properties.Resources.psicultura_aqua_minas_transparente2;
            this.pictureBox1.Location = new System.Drawing.Point(360, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(627, 140);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1066, 31);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "X";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1103, 535);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}