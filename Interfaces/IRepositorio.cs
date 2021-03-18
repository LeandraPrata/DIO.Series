using System.Collections.Generic;
namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Listar();
        T RetornaPorId();
        void Insere(T EntidadeBase);
        void Excluir(int Id);
        void Atualiza(int id, T entidade );
        int ProximaId();
    }
}