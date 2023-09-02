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
    public partial class TelaDeOpcoes : Form
    {
        public TelaDeOpcoes()
        {
            InitializeComponent();
            DefinindoPadroesDaTela();
        }

        public void DefinindoPadroesDaTela()
        {
            this.Text = "Menú - Opções";
            this.BackgroundImage = Properties.Resources.pagina_menu_opcoes;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnAoAdicionarTime(object sender, EventArgs e)
        {
            var telaMenuTime = new TelaMenuTime();
            telaMenuTime.ShowDialog();
        }

        private void btnAdicionarJogador(object sender, EventArgs e)
        {
            var telaMenuJogador = new FormularioJogador();
            telaMenuJogador.ShowDialog();
        }
    }
}
