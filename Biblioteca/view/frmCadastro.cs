using Biblioteca.Controller;
using Biblioteca.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.view
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
            this.btnLogin.FlatStyle = FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteController ccliente = new ClienteController();

            cliente.Email = txtEmail.Text;
            cliente.Senha = txtSenha.Text;
            cliente.Nome = txtNome.Text;
            cliente.Nome_social = txtNomeSocial.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Nascimento = dtpNascimento.Value;

            if (rdoMasculino.Checked)
            {
                cliente.Genero = "Masculino";
            }
            else if (rdoFeminino.Checked)
            {
                cliente.Genero = "Feminino";
            }
            else if (rdoNaoBinario.Checked)
            {
                cliente.Genero = txtNaoBinario.Text;
            }

            cliente.Tipo = "Cliente";
            ccliente.Salvar(cliente);
            MessageBox.Show("Seja bem vindo " + cliente.Nome + "!", "Bem vindo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        private void Encerrar(object sender, FormClosedEventArgs e)
        {
            frmLogin telaAnterior = new frmLogin();
            telaAnterior.Show();
        }

        private void rdoNaoBinario_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoNaoBinario.Checked)
            {
                txtNaoBinario.Visible = true;
            }
            else
            {
                txtNaoBinario.Visible = false;
                txtNaoBinario.Text = "";
            }
        }
    }
}
