using System;
using System.Configuration;

namespace TicketsDemo.MongoDB
{
    public class SettingsProvider : ISettingsProvider
    {
        public string ConnectionString { get; set; } = ConfigurationManager.ConnectionStrings["MongoDb"].ConnectionString;
    }
}
