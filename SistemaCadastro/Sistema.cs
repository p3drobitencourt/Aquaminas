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
            //listaCBEspecie();
            listagridEspecie();
            Console.WriteLine("Inicio load");
        }
        void listagridEspecie()
        {
            ConectaBD con = new ConectaBD();
            dgEspecie.DataSource = con.listaEspecie();
            dgEspecie.Columns["id"].Visible = false;
        }
        void listaEspecie()
        {
            ConectaBD con = new ConectaBD();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            (dgEspecie.DataSource as DataTable).DefaultView.RowFilter = string.Format("nome like '{0}%'", txtEspecieBusca.Text);
        }

        private void btnRemoveBanda_Click(object sender, EventArgs e)
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
  

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int linha = dgEspecie.CurrentRow.Index;
            idAlterar = Convert.ToInt32(dgEspecie.Rows[linha].Cells["id"].Value.ToString());
            txtAlteraNome.Text = dgEspecie.Rows[linha].Cells["nome"].Value.ToString();
            txtAlteraPreco.Text = dgEspecie.Rows[linha].Cells["preco"].Value.ToString();
            tabControl1.SelectedTab = tabAlterar;
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
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void listaCBEspecie()
        {
            ConectaBD con = new ConectaBD();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaEspecie();
        }
    }
}
