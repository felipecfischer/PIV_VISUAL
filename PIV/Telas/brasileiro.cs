using MongoDB.Driver;
using PIV.Fontes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIV.Telas
{
    public partial class brasileiro : Form
    {
        public brasileiro()
        {
            InitializeComponent();
            carregaCombos();
        }
        private void carregaCombos()
        {
            List<Brasileiro> comboBr = new List<Brasileiro>();
            Brasileiro aux = new Brasileiro();
            aux._id = "<-Selecione->";
            aux.nome = "<-Selecione->";
            comboBr.Add(aux);

            aux = new Brasileiro();
            aux._id = "A";
            aux.nome = "Série A";
            comboBr.Add(aux);

            aux = new Brasileiro();
            aux._id = "B";
            aux.nome = "Série B";
            comboBr.Add(aux);

            aux = new Brasileiro();
            aux._id = "C";
            aux.nome = "Série C";
            comboBr.Add(aux);

            aux = new Brasileiro();
            aux._id = "D";
            aux.nome = "Série D";
            comboBr.Add(aux);
            
            cbSerie.DataSource = comboBr;
            cbSerie.DisplayMember = "nome";
            cbSerie.ValueMember = "_id";
        }

        private void cbSerie_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbSerie.SelectedValue.ToString() != "<-Selecione->")
            {
                List<Time> times = new List<Time>();
                Time obj = new Time();
                String coll = "gazetaesportiva_brasileiro_serie_" + cbSerie.SelectedValue.ToString().ToLower() + "_2018";

                IMongoCollection<Time> coll_times = conn.db.GetCollection<Time>(coll);
                var t = coll_times.AsQueryable<Time>()
                        .Select(c => c)
                        .Distinct()
                        .OrderBy(c => c.posicao);
                foreach (var time in t)
                {
                    obj = new Time();
                    obj._id = time._id;
                    obj.serie = time.serie;
                    obj.posicao = time.posicao;
                    obj.time = time.time;
                    obj.pontos = time.pontos;
                    obj.jogos = time.jogos;
                    obj.vitorias = time.vitorias;
                    obj.empates = time.empates;
                    obj.derrotas = time.derrotas;
                    obj.gols_pro = time.gols_pro;
                    obj.gols_contra = time.gols_contra;
                    obj.saldo_gols = time.saldo_gols;
                    obj.aproveitamento = time.aproveitamento;
                    times.Add(obj);
                }

                dvTabela.DataSource = times;
                dvTabela.Columns["_id"].Visible = false;
                dvTabela.Columns["serie"].Visible = false;
                dvTabela.Columns["uf"].Visible = false;
                if ( !dvTabela.Visible )
                    dvTabela.Visible = true;
            }
            else
            {
                dvTabela.DataSource = null;
                dvTabela.Visible = false;
            }
        }
    }
}
