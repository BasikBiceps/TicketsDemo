using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading.Tasks;
using TicketsDemo.Data.Entities;
using TicketsDemo.Data.Repositories;

namespace TicketsDemo.MongoDB.Repositories
{
    public class TrainRepository : ITrainRepository
    {
        IContextFactory _fct;

        public TrainRepository(IContextFactory fct) {
            _fct = fct;
        }

        public void CreateTrain(Train train)
        {
            IContext tc = _fct.CreateContext();
            tc.Trains.InsertOne(train);
        }

        public void DeleteTrain(Train train)
        {
            IContext tc = _fct.CreateContext();
            tc = _fct.CreateContext();
            tc.Trains.DeleteOne(new BsonDocument("_id", train.Id));
        }

        public List<Train> GetAllTrains()
        {
            IContext tc = _fct.CreateContext();
            tc = _fct.CreateContext();
            return tc.Trains.Find(new BsonDocument()).ToList();
        }

        public Train GetTrainDetails(int trainId)
        {
            IContext tc = _fct.CreateContext();
            tc = _fct.CreateContext();
            return tc.Trains.Find(new BsonDocument("_id", trainId)).FirstOrDefault();
        }

        public void UpdateTrain(Train train)
        {
            IContext tc = _fct.CreateContext();
            tc.Trains.ReplaceOneAsync(new BsonDocument("_id", train.Id), train);
        }
    }
}
