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
    public class TicketsContext
    {
        public MongoClient client { get; set; }
        public IMongoDatabase db { get; set; }

        public IMongoCollection<Train> Trains
        {
            get { return db.GetCollection<Train>("Train"); }
        }
        public TicketsContext()
        {
            client = new MongoClient("mongodb://localhost:27017");
            db = client.GetDatabase("Study");
        }
    }
}
