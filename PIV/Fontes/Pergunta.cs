using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIV
{
    class Pergunta
    {
        public ObjectId _id { get; set; }
        public int pg { get; set; }
        public string pergunta { get; set; }
    }
}
