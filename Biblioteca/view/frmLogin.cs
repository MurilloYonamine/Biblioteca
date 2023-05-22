using Biblioteca.Controller;
using Biblioteca.model;
using Biblioteca.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.btnLogin.FlatStyle = FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;

            lnkCadastro.LinkBehavior = LinkBehavior.NeverUnderline;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Email = txtEmail.Text;
            usuario.Senha = txtSenha.Text;

            LoginController Clogin = new LoginController();

            if (Clogin.Salvar(usuario, out string mensagem) == true)
            {
                MessageBox.Show("Seja bem vindo " + mensagem + "!", "Bem vindo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmInicioCliente tela = new frmInicioCliente();
                tela.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Encerrar(object sender, FormClosedEventArgs e)
        {
            //Fechar o formulário login
            System.Environment.Exit(0);
        }

        private void lnkCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCadastro tela = new frmCadastro();
            tela.Show();
            this.Hide();
        }
    }
}
