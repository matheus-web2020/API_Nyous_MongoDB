using Nyous.API.NoSQL.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nyous.API.NoSQL.Interfaces.Repositories
{
    public interface IEventoRepository
    {
        List<Evento> Listar();

        Evento BuscarPorId(string id);

        void Adicionar(Evento evento);

        void Atualizar(string id, Evento evento);

        void Remover(string id);
    }
}
