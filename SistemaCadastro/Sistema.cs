using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SistemaCadastro
{
    public partial class Sistema : Form
    {
        char AlteraNome, AlteraPreco;
        int idAlterar;
        int estado = 0;

        public Sistema()
        {
            InitializeComponent();

        }

        void layoutVenda()
        {
            lblNomeEspecie.Text = "Quantidade:";
            lblPreco.Text = "Preço Total:";
            txtPreco.Text = "Calculado automaticamente";
            label1.Visible = true;
            cbEspecie.Visible = true;
            label5.Text = "Venda:";
            lblAlteraEspecie.Visible = true;
            cbAlteraVenda.Visible = true;
            lblPrecoAlt.Text = "Preço Total:";
            lblNomeAlt.Text = "Quantidade:";
            txtAlteraPreco.Text = "Calculado automaticamente";
            listagridEspecie();
        }

        void layoutEspecie()
        {
            lblNomeEspecie.Text = "Nome:";
            lblPreco.Text = "Preço:";
            txtPreco.Text = "";
            label1.Visible = false;
            cbEspecie.Visible = false;
            label5.Text = "Espécie:";
            lblAlteraEspecie.Visible = false;
            cbAlteraVenda.Visible = false;
            lblPrecoAlt.Text = "Preço:";
            lblNomeAlt.Text = "Nome:";
            txtAlteraPreco.Text = "";
            listagridEspecie();
        }

        void limpaCampos()
        {
            txtnome.Clear();
            txtPreco.Clear();
            txtnome.Focus();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            marcador.Height = btnCadastra.Height;
            marcador.Top = btnCadastra.Top;
            estado = 0;
            layoutEspecie();
        }


        private void btnBusca_Click(object sender, EventArgs e)
        {
            marcador.Height = btnBusca.Height;
            marcador.Top = btnBusca.Top;
            estado = 1;
            layoutVenda();

        }


        private void Sistema_Load(object sender, EventArgs e)
        {
            listaCBEspecie();
            listagridEspecie();
        }
        void listagridEspecie()
        {
            if (estado == 0)
            {
                ConectaBD con = new ConectaBD();
                dgEspecie.DataSource = con.listaEspecie();
                dgEspecie.Columns["id"].Visible = false;
            }
            else
            {
                ConectaBD con = new ConectaBD();
                dgEspecie.DataSource = con.listaVenda();
                if(estado == 0)
                {
                    dgEspecie.Columns["id"].Visible = false;
                }
                else
                {
                    dgEspecie.Columns["id"].Visible = true;
                }
                
            }
            
        }
        void listaEspecie()
        {
            ConectaBD con = new ConectaBD();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {   
            if(estado == 0)
            {
                (dgEspecie.DataSource as DataTable).DefaultView.RowFilter = string.Format("nome like '{0}%'", txtEspecieBusca.Text);
            }
            else
            {
                (dgEspecie.DataSource as DataTable).DefaultView.RowFilter = string.Format("especie_vendida like '{0}%'", txtEspecieBusca.Text);
            }
            
        }

        private void btnRemoveBanda_Click(object sender, EventArgs e)
        {
            if (estado == 0)
            {
                int linha = dgEspecie.CurrentRow.Index;
                int id = Convert.ToInt32(dgEspecie.Rows[linha].Cells["id"].Value.ToString());
                DialogResult resp = MessageBox.Show("Tem certeza dessa exclusão?", "Remove Peixe", MessageBoxButtons.OKCancel);
                if (resp == DialogResult.OK)
                {
                    ConectaBD con = new ConectaBD();
                    bool retorno = con.deletaEspecie(id);
                    if (retorno == true)
                    {
                        MessageBox.Show("Especie excluida com sucesso");
                        listagridEspecie();
                    }
                    else
                        MessageBox.Show(con.mensagem);
                }
                else
                    MessageBox.Show("Exclusão cancelada");

            }
            else
            {
                int linha = dgEspecie.CurrentRow.Index;
                int id = Convert.ToInt32(dgEspecie.Rows[linha].Cells["id"].Value.ToString());
                DialogResult resp = MessageBox.Show("Tem certeza dessa exclusão?", "Remove Venda", MessageBoxButtons.OKCancel);
                if (resp == DialogResult.OK)
                {
                    ConectaBD con = new ConectaBD();
                    bool retorno = con.deletaVenda(id);
                    if (retorno == true)
                    {
                        MessageBox.Show("Venda excluida com sucesso");
                        listagridEspecie();
                    }
                    else
                        MessageBox.Show(con.mensagem);
                }
                else
                    MessageBox.Show("Exclusão cancelada");

            }

        }
  

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(estado == 0)
            {
                int linha = dgEspecie.CurrentRow.Index;
                idAlterar = Convert.ToInt32(dgEspecie.Rows[linha].Cells["id"].Value.ToString());
                txtAlteraNome.Text = dgEspecie.Rows[linha].Cells["quantidade"].Value.ToString();
                txtAlteraPreco.Text = dgEspecie.Rows[linha].Cells["preco_total"].Value.ToString();
                tabControl1.SelectedTab = tabAlterar;
            }
            else
            {
                int linha = dgEspecie.CurrentRow.Index;
                idAlterar = Convert.ToInt32(dgEspecie.Rows[linha].Cells["id"].Value.ToString());
                txtAlteraNome.Text = dgEspecie.Rows[linha].Cells["quantidade"].Value.ToString();
                txtAlteraPreco.Text = dgEspecie.Rows[linha].Cells["preco_total"].Value.ToString();
                cbAlteraVenda.Text = dgEspecie.Rows[linha].Cells["especie_vendida"].Value.ToString();
                tabControl1.SelectedTab = tabAlterar;
            }
            
        }

        private void btnConfirmaAlteracao_Click(object sender, EventArgs e)
        {
            ConectaBD con = new ConectaBD();
            Especie novaEspecie = new Especie();
            novaEspecie.Nome = txtAlteraNome.Text ;
            novaEspecie.Preco = Convert.ToDouble(txtAlteraPreco.Text);
            bool retorno = con.alteraEspecie(novaEspecie,idAlterar);
            if (retorno == false)
                MessageBox.Show(con.mensagem);
            else
                MessageBox.Show("Alteração realizada com sucesso");
                listagridEspecie();
                tabControl1.SelectedTab = tabBuscar;

        }

        private void bntAddGenero_Click(object sender, EventArgs e)
        {

        }

        private void BtnConfirmaCadastro_Click(object sender, EventArgs e)
        {
            if (estado == 0)
            {
                ConectaBD con = new ConectaBD();
                Especie novaEspecie = new Especie();
                novaEspecie.Nome = txtnome.Text;
                novaEspecie.Preco = Convert.ToDouble(txtPreco.Text);
                Console.WriteLine(novaEspecie.Preco);
                bool retorno = con.insereEspecie(novaEspecie);
                if (retorno == false)
                    MessageBox.Show(con.mensagem);

                limpaCampos();
                listagridEspecie();
            }
            else
            {
                ConectaBD con = new ConectaBD();
                Venda venda = new Venda();
                venda.Quantidade = Convert.ToInt32(txtnome.Text);
                venda.Peixe = Convert.ToInt32(cbEspecie.SelectedValue.ToString());
                venda.PrecoTotal = con.precoEspecie(venda.Peixe) * venda.Quantidade;
                bool retorno = con.insereVenda(venda);
                if (retorno == false)
                    MessageBox.Show(con.mensagem);

                limpaCampos();
                listagridEspecie();
            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void listaCBEspecie()
        {
            ConectaBD con = new ConectaBD();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaEspecie();
            cbEspecie.DataSource = tabelaDados;
            cbEspecie.DisplayMember = "nome";
            cbEspecie.ValueMember = "id";
    
            cbAlteraVenda.DataSource = tabelaDados;
            cbAlteraVenda.DisplayMember = "nome";
            cbAlteraVenda.ValueMember = "id";

        }
    }
}
