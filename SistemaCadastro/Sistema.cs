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

        public Sistema()
        {
            InitializeComponent();

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
            tabControl1.SelectedTab = tabControl1.TabPages[0];
        }


        private void btnBusca_Click(object sender, EventArgs e)
        {
            marcador.Height = btnBusca.Height;
            marcador.Top = btnBusca.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }


        private void Sistema_Load(object sender, EventArgs e)
        {
            listaCBEspecie();
            listagridEspecie();
        }
        void listagridEspecie()
        {
            ConectaBD con = new ConectaBD();
            dgEspecie.DataSource = con.listaEspecie();
            dgEspecie.Columns["idEspecie"].Visible = false;
        }
        void listaEspecie()
        {
            ConectaBD con = new ConectaBD();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            (dgEspecie.DataSource as DataTable).DefaultView.RowFilter = string.Format("nome especie '{0}%'", txtEspecieBusca);
        }

        private void btnRemoveBanda_Click(object sender, EventArgs e)
        {
            int linha = dgEspecie.CurrentRow.Index;
            int id = Convert.ToInt32(dgEspecie.Rows[linha].Cells["idEspecie"].Value.ToString());
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
  

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int linha = dgEspecie.CurrentRow.Index;
            AlteraNome.Text = Convert.ToInt32(dgEspecie.Rows[linha].Cells["nome"].Value.ToString());
            AlteraPreco.Text = Convert.ToInt32(dgEspecie.Rows[linha].Cells["preco"].Value.ToString());
        }

        private void btnConfirmaAlteracao_Click(object sender, EventArgs e)
        {
            ConectaBD con = new ConectaBD();
            Especie novaEspecie = new Especie();
            novaEspecie.Nome = txtAlteraNome.Text ;
            novaEspecie.Preco = Convert.ToDouble(txtAlteraPreco.Text);
            bool retorno = con.insereEspecie(novaEspecie);
            if (retorno == false)
                MessageBox.Show(con.mensagem);
            else
                MessageBox.Show("Alteração realizada com sucesso");
            listagridEspecie();

        }

        private void bntAddGenero_Click(object sender, EventArgs e)
        {

        }

        private void BtnConfirmaCadastro_Click(object sender, EventArgs e)
        {
            ConectaBD con = new ConectaBD();
            Especie novaEspecie = new Especie();
            novaEspecie.Nome = txtnome.Text;
            novaEspecie.Preco = Convert.ToDouble(txtPreco.Text);
            bool retorno = con.alteraEspecie(novaEspecie, AlteraNome );
            if (retorno == false)
                MessageBox.Show(con.mensagem);

            limpaCampos();
            listagridEspecie();

        }
        public void listaCBEspecie()
        {
            ConectaBD con = new ConectaBD();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaEspecie();
        }
    }
}
