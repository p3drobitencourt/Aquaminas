﻿using System;
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
         
        }




        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void btnRemoveBanda_Click(object sender, EventArgs e)
        {
           
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

        private void BtnConfirmaCadastro_Click(object sender, EventArgs e)
        {
            ConectaBD con = new ConectaBD();
            Especie novaEspecie = new Especie();
            novaEspecie.Id = Convert.ToInt32(txtid.Text);
            novaEspecie.Nome = txtnome.Text;
            novaEspecie.Preco = Convert.ToInt32(txtpreco.Text);
            bool retorno = con.insereEspecie(novaEspecie);
            if (retorno == false)
                MessageBox.Show(con.mensagem);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
