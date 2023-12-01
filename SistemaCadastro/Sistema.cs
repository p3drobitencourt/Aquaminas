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
using SistemaCadastroEspecie;

namespace SistemaCadastro
{
    public partial class Sistema : Form
    {
        int tela = 0;

        public Sistema()
        {
            InitializeComponent();
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            lblCadastrar1.Text = "Nome da espécie:";
            lblpreco.Text = "Preço:";
            
            marcador.Height = btnCadastra.Height;
            marcador.Top = btnCadastra.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[0];
        }
        

        private void btnBusca_Click(object sender, EventArgs e)
        {
            lblCadastrar1.Text = "Quantidade vendida:";
            lblpreco.Text = "Preço total:";
            marcador.Height = btnBusca.Height;
            marcador.Top = btnBusca.Top;
        }


        private void Sistema_Load(object sender, EventArgs e)
        {
            listaCBEspecie();
            listagridEspecie();
        }

        void listagridEspecie()
        {
            ConectaBD con =new ConectaBD();
            dgEspecie.DataSource = con.listaEspecie();
        }
        public void listaCBEspecie()
        {
            ConectaBD con = new ConectaBD();
            DataTable tabelaDados = new DataTable();
            tabelaDados = con.listaEspecie();
            cbPeixe.DataSource = tabelaDados;
            cbPeixe.DisplayMember = "Especie";
            cbPeixe.ValueMember = "idEspecie";
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            (dgEspecie.DataSource as DataTable).DefaultView.RowFilter = string.Format("nome especie '{0}%'", txtEspecieBuscar.Text);
        }

        private void btnRemoveEspecie_Click(object sender, EventArgs e)
        {
            int linha = dgEspecie.CurrentRow.Index;
            int id = Convert.ToInt32(dgEspecie.Rows[linha].Cells["idEspecie"].Value.ToString());
            DialogResult resp = MessageBox.Show("Tem certeza dessa exclusão", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                ConectaBD con = new ConectaBD();
                bool retorno = con.deleteEspecie(id);
                if (retorno == true)
                {
                    MessageBox.Show("Especie excluida com sucesso");
                    listagridEspecie();
                }
                else
                {
                    MessageBox.Show(con.mensagem);
                }
            else
                MessageBox.Show("Exclusão cancelada");
                
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
        }

         private void btnConfirmaAlteracao_Click(object sender, EventArgs e)
        {
           


        }

        private void bntAddGenero_Click(object sender, EventArgs e)
        {
          
        }
        void limpaCampos()
        {
            txtnome.Clear();
            cbPeixe.Text = "";
            txtpreco.Clear();
            txtnome.Focus();
        }
        private void BtnConfirmaCadastro_Click(object sender, EventArgs e)
        {
            ConectaBD con = new ConectaBD();
            Especie novaEspecie = new Especie();
            novaEspecie.Id = Convert.ToInt32(lblpeixe.Text);
            novaEspecie.Nome = txtnome.Text;
            novaEspecie.Preco = Convert.ToInt32(lblpreco.Text);
            bool retorno = con.insereEspecie(novaEspecie);
            if (retorno == false)
                MessageBox.Show(con.mensagem);

            limpaCampos();
            listagridEspecie();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtid_Click(object sender, EventArgs e)
        {

        }

        private void tabCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void txtintegrantes_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCadastrar1_Click(object sender, EventArgs e)
        {
            
        }

    }
}
