using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaLiga
{
    internal class Liga
    {
        public Liga() { }

        public int Id { get; set; }
        public string NomeDaLiga { get; set; }
        public string PaisDaLiga { get; set; }
        public DateTime AnoFundacaoDaLiga { get; set; }
    }
}
