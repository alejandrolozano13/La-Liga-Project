using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaLiga
{
    internal class Jogador
    {
        public Jogador() { }
        public int Id { get; set; }
        public string NomeDoJogador { get; set; }
        public string PosicaoDoJogador { get; set; }
        public string NacionalidadeDoJogador { get; set; }
        public int NumeroCamisaDoJogador { get; set; }
        public int TimeOndeJoga { get; set; }
    }
}
