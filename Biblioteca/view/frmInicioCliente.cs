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
    public partial class frmInicioCliente : Form
    {
        public frmInicioCliente()
        {
            InitializeComponent();
        }

        private void Encerrar(object sender, FormClosedEventArgs e)
        {
            frmLogin telaAnterior = new frmLogin();
            telaAnterior.Show();
        }
    }
}
