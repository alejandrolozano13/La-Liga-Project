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
    public partial class TelaMenuJogador : Form
    {
        public TelaMenuJogador()
        {
            InitializeComponent();
            DefinindoPadroesDaTela();
        }

        public void DefinindoPadroesDaTela()
        {
            this.Text = "Menú - Jogador";
            this.BackgroundImage = Properties.Resources.pagina_menu_opcoes;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
