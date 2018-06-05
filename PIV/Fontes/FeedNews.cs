using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIV.Fontes
{
    public class FeedNews
    {
        public ObjectId _id { get; set; }
        public String categoria { get; set; }
        public String titulo { get; set; }
        public String texto { get; set; }
        public String[] img { get; set; }
        public String data { get; set; }
        public String[] detalhes { get; set; }
    }
}
