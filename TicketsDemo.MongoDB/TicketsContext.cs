using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using TicketsDemo.Data.Entities;
using TicketsDemo.Data.Repositories;

namespace TicketsDemo.MongoDB
{
    public class TicketsContext : IContext
    {
        public MongoClient Client { get; set; }
        public IMongoDatabase DB { get; set; }

        public IMongoCollection<Train> Trains
        {
            get { return DB.GetCollection<Train>("Train"); }
        }
        public TicketsContext(ISettingsProvider provider)
        {
            Client = new MongoClient(provider.ConnectionString);
            DB = Client.GetDatabase("Study");
        }
    }
}
