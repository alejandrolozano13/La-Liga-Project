using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Time
    {
        public int Id { get; set; }
        public string NomeDoTime { get; set; }
        public DateTime AnoDeFundacaoDoTime { get; set; }
        public string ImagemTime { get; set; }
    }
}
