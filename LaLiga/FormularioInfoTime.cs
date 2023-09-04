using Dominio.Entidades;
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

namespace LaLiga
{
    public partial class FormularioInfoTime : Form
    {
        public FormularioInfoTime()
        {
            InitializeComponent();
            ConfiguracoesDaTela();
        }

        public void ConfiguracoesDaTela()
        {
            this.Text = "Informação Time";
            DesabilitandoPictureBox();
        }

        private string imagemBase64;

        private void btnAoAdicionarImagem(object sender, EventArgs e)
        {
            var time = new Time();
            OpenFileDialog abrirArquivo = new OpenFileDialog();
            abrirArquivo.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if(abrirArquivo.ShowDialog() == DialogResult.OK)
            {
                btnImagem.Image = new Bitmap(abrirArquivo.FileName);
                btnImagem.SizeMode = PictureBoxSizeMode.Zoom;
                imagemBase64 = ConverterImagemParaBase64(abrirArquivo.FileName);
            }
        }
        
        private string ConverterImagemParaBase64(string caminhoDaImagem)
        {
            var memoryStream = new MemoryStream();
            var imagem = Image.FromFile(caminhoDaImagem);
            imagem.Save(memoryStream, ImageFormat.Jpeg);
            byte[] imagemEmBytes = memoryStream.ToArray();
            return Convert.ToBase64String(imagemEmBytes);
        }

        public void DesabilitandoPictureBox()
        {
            btnImagem.Enabled = false;
        }

        private void btnAoCancelar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAoSalvar(object sender, EventArgs e)
        {
            var time = new Time();
            var repositorio = new RepositorioBanco();
            time.NomeDoTime = txtNome.Text;
            time.AnoDeFundacaoDoTime = dateTimePicker1.Value;
            time.ImagemTime = imagemBase64;
            repositorio.CriarNovoTime(time);
        }
    }
}
