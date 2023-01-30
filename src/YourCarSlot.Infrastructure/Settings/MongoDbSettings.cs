using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YourCarSlot.Infrastructure.Settings
{
    public class MongoDbSettings
    {
        public string DatabaseConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}