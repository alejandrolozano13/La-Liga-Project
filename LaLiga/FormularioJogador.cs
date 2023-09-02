using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LaLiga
{
    public partial class FormularioJogador : Form
    {
        public FormularioJogador()
        {
            InitializeComponent();
        }

        private void btnAoCancelar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAoSalvar(object sender, EventArgs e)
        {

        }

        private void btnAoCarregarImagem(object sender, EventArgs e)
        {
            var arquivoImagem = new OpenFileDialog();
            arquivoImagem.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if(arquivoImagem.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(arquivoImagem.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                string base64 = ConverterImagemParaBase64(arquivoImagem.FileName);
            }
        }

        public string ConverterImagemParaBase64(string caminhoDaImagem)
        {
            var memoryStream = new MemoryStream();
            var imagem = Image.FromFile(caminhoDaImagem);
            imagem.Save(memoryStream, ImageFormat.Jpeg);
            byte[] imagemBytes = memoryStream.ToArray();
            return Convert.ToBase64String(imagemBytes);
        }
    }
}
