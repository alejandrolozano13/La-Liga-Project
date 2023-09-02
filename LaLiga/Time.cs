using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaLiga
{
    internal class Time
    {
        public Time() { }
        public int Id { get; set; }
        public string NomeDoTime { get; set; }
        public int LigaQuePertence { get; set; }
        public DateTime AnoDeFundacaoDoTime { get; set; }
    }
}
