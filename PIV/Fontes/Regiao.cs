using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIV.Fontes
{
    class Regiao
    {
        public ObjectId _id { get; set; }
        public string regiao { get; set; }
        public string sigla { get; set; }
        public string estado { get; set; }
    }
}
