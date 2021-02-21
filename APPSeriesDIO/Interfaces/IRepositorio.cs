using System.Collections.Generic;

// Projeto, integralmente, criado seguindo os passos do curso "Criando um APP simples de cadastro de séries em .NET - Eliézer Zarpelão (Github: elizarp)" - DIO
namespace APPSeriesDIO.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}