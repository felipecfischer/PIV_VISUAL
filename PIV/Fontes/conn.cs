using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIV
{
    public class conn
    {
        public static MongoClient connection = new MongoClient("mongodb://localhost:27017");
        public static IMongoDatabase db = connection.GetDatabase("piv");
    }
}
