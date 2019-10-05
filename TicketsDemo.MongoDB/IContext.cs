using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using TicketsDemo.Data.Entities;



namespace TicketsDemo.MongoDB
{
   public interface IContext
    {
        IMongoCollection<Train> Trains { get; }
    }
}
