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
            this.BackgroundImage = Properties.Resources.pagina_menu_opcoes;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
