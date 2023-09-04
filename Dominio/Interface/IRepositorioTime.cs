
using Dominio.Entidades;

namespace Dominio.Interface
{
    public interface IRepositorioTime
    {
        public List<Time> ObterTodos();
        public void CriarTime(Time time);
        public void RemoverTime(int id);
        public Time ObterPorId(int id);
        public void AtualizarTime(Time time);
    }
}
