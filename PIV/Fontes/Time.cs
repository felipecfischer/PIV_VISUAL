using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIV.Fontes
{
    class Time
    {
        public ObjectId _id { get; set; }
        public string serie { get; set; }
        public int posicao { get; set; }
        public string time { get; set; }
        public string uf { get; set; }
        public int pontos { get; set; }
        public int jogos { get; set; }
        public int vitorias { get; set; }
        public int empates { get; set; }
        public int derrotas { get; set; }
        public int gols_pro { get; set; }
        public int gols_contra { get; set; }
        public int saldo_gols { get; set; }
        public double aproveitamento { get; set; }
    }
}
