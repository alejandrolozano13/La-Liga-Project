using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaLiga
{
    public partial class TelaMenuTime : Form
    {
        public TelaMenuTime()
        {
            InitializeComponent();
            DefinindoPadroesDaTela();
        }

        public void DefinindoPadroesDaTela()
        {
            this.Text = "Menú - Time La Liga";
        }

        private void btnAoCadastrarTime(object sender, EventArgs e)
        {
            var formularioInfoTime = new FormularioInfoTime();
            formularioInfoTime.ShowDialog();
        }

        private void btnAoVoltar(object sender, EventArgs e)
        {
            
            var telaMenuOpcoes = new TelaDeOpcoes();
            telaMenuOpcoes.ShowDialog();
            this.Close();
        }
    }
}
