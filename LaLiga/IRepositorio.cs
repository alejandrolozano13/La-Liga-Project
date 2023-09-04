using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaLiga
{
    public interface IRepositorio
    {
        List<Time> ObterTodos();
        void CriarNovoTime(Time time);
        void RemoverTime(int id);
        void AtualizarTime(Time time);
        Time ObterPorId(int id);
    }
}
