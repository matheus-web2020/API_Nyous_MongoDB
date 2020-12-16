using MongoDB.Driver;
using Nyous.API.NoSQL.Context;
using Nyous.API.NoSQL.Domains;
using Nyous.API.NoSQL.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nyous.API.NoSQL.Repositories
{
    public class EventoRepository : IEventoRepository
    {
        private readonly IMongoCollection<Evento> _eventos;

        public EventoRepository(INyousDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            
            var database = client.GetDatabase(settings.DatabaseName);

            _eventos = database.GetCollection<Evento>(settings.EventosCollectionName);

        }
        public void Adicionar(Evento evento)
        {
            try
            {
                _eventos.InsertOne(evento);
            }
            catch (Exception ex)
            {

                throw new Exception (ex.Message);
            }
        }

        public void Atualizar(string id, Evento evento)
        {
            throw new NotImplementedException();
        }

        public Evento BuscarPorId(string id)
        {
            throw new NotImplementedException();
        }

        public List<Evento> Listar()
        {
            throw new NotImplementedException();
        }

        public void Remover(string id)
        {
            throw new NotImplementedException();
        }
    }
}
