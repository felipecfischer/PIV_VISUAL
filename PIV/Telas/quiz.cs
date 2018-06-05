using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using PIV.Fontes;

namespace PIV
{
    public partial class quiz : Form
    {
        int posicao, pontos;
        bool k_ok = false;
        String reposta;

        public quiz()
        {
            InitializeComponent();
            listaTimes();
            posicao = 0;
            listaPerguntas(posicao);
        }

        private void listaPerguntas(int aux_posicao)
        {
            String text = "";
            IMongoCollection<Pergunta> coll_quiz = conn.db.GetCollection<Pergunta>("quiz");
            List<Pergunta> perguntas = coll_quiz.Find("{}").ToList();
            for (int i = 0; i < perguntas.Capacity; i++)
            {
                if ( i == aux_posicao )
                {
                    lbPergunta.Text = perguntas[aux_posicao].pergunta;
                }
            }
            if (aux_posicao >= perguntas.Capacity)
            {
                if (pontos > 4)
                {
                    text = "Parabéns, você foi muito bom e obrigado pela sua participção, você acertou: " + pontos + " / 10.";
                }
                else
                {
                    text = "Você não foi bom, mas obrigado pela sua participção, você acertou: " + pontos + " / 10.";
                }
                Telas.telaExplosao frmResposta =
                                new Telas.telaExplosao(text);
                frmResposta.ShowDialog();
                this.Close();
            }
        }

        private bool buscaRespostas(int aux_posicao)
        {
            bool ok = false;
            k_ok = true;
            try
            {
                Time obj = new Time();
                String aux_resposta = "N";
                String aux_resposta_1 = "N";
                IMongoCollection<Time> coll_serie;
                //IMongoCollection<Time> coll_serie_b = conn.db.GetCollection<Time>("gazetaesportiva_brasileiro_serie_b");
                if (aux_posicao == 5)
                    coll_serie = conn.db.GetCollection<Time>("gazetaesportiva_brasileiro_serie_b");
                else
                    coll_serie = conn.db.GetCollection<Time>("gazetaesportiva_brasileiro_serie_a");

                switch (aux_posicao)
                {
                    case 0:
                        /*Em qual ano seu time realizou a maior pontuação no compeonato?*/
                        var p1 = coll_serie.AsQueryable<Time>()
                                    .Where(c => c.time == cbTime.Text)
                                    .OrderByDescending(c => c.pontos)
                                    .First();
                        reposta = p1.serie.Trim();
                        if (Convert.ToInt32(p1.serie.Trim())
                            == Convert.ToInt32(txtResposta.Text.Trim()))
                        {
                            ok = true;
                        }
                        break;
                    case 1:
                        /*Qual o menor número de derrotas do seu time e em qual ano o campeonato foi disputado ? (Separe por vírgula =D)*/
                        var p2 = coll_serie.AsQueryable<Time>()
                                    .Where(c => c.time == cbTime.Text)
                                    .OrderBy(c => c.derrotas)
                                    .First();
                        String[] aux = txtResposta.Text.Split(',');
                        reposta = p2.derrotas + "," + p2.serie.Trim();
                        if (p2.derrotas == Convert.ToInt32(aux[0].Trim()) &&
                            Convert.ToInt32(p2.serie.Trim()) == Convert.ToInt32(aux[1].Trim()))
                        {
                            ok = true;
                        }
                        break;
                    case 2:
                        /*Em qual ano seu time teve a maior quantidade de gols feitos?*/
                        var p3 = coll_serie.AsQueryable<Time>()
                                .Where(c => c.time == cbTime.Text)
                                .OrderByDescending(c => c.gols_pro)
                                .First();
                        reposta = p3.serie.Trim();
                        if (Convert.ToInt32(p3.serie.Trim())
                            == Convert.ToInt32(txtResposta.Text.Trim()))
                        {
                            ok = true;
                        }
                        break;
                    case 3:
                        /* Seu time já foi campeão nos campeonatos disputados por pontos corridos? Quantas vezes? */
                        var p4 = coll_serie.AsQueryable<Time>()
                                .Where(c => c.time == cbTime.Text && c.posicao == 1)
                                .Count();
                        reposta = ""+ p4;
                        if (p4 == Convert.ToInt32(txtResposta.Text.Trim()))
                        {
                            ok = true;
                        }
                        break;
                    case 4:
                        reposta = "Não existe ano = 0";
                        /*Em qual ano o Curintia foi campeão sem ajuda do Juiz ?*/
                        if (Convert.ToInt32(txtResposta.Text.Trim()) < 1)
                        {
                            ok = true;
                        }
                        break;
                    case 5:
                        /* Seu time já foi rebaixado? */
                        var p6 = coll_serie.AsQueryable<Time>()
                                .Where(c => c.time == cbTime.Text)
                                .Count();
                        reposta = "NÃO";
                        if (p6 > 0)
                        {
                            reposta = "SIM";
                            aux_resposta = "S";
                            aux_resposta_1 = "Y";
                        }
                        if (txtResposta.Text.ToUpper().Contains(aux_resposta) ||
                                txtResposta.Text.ToUpper().Contains(aux_resposta_1))
                        {
                            ok = true;
                        }
                        break;
                    case 6:
                        /* Estado com mais representantes nos compeonatos? */
                        var p7 = coll_serie
                                .Aggregate()
                                .Group(c => c.uf, g => new
                                {
                                    uf = g.Select(u => u.uf),
                                    count = g.Select(x => x.uf).Count()
                                })
                                .ToList()
                                .OrderByDescending(g => g.count)
                                .First();
                        reposta = p7.uf.First();
                        if (p7.uf.First() == txtResposta.Text.Trim().ToUpper())
                        {
                            ok = true;
                        }
                        break;
                    case 7:
                        /* Região com mais campeões do campeonato? (centro-oeste) = 1, (sul) = 2, (sudeste) = 3, (norte) = 4, (nordeste) = 5 */
                        var p8 = coll_serie
                                .Aggregate()
                                .Group(c => c.posicao == 1, g => new { max = g.Select(x => x.uf).Max() })
                                .ToList()
                                .OrderBy(g => g.max)
                                .First();
                        IMongoCollection<Regiao> coll_regiao = conn.db.GetCollection<Regiao>("regiao_estado");
                        var p8_1 = coll_regiao.AsQueryable<Regiao>()
                                .Where(c => c.sigla == p8.max);
                        switch (Convert.ToInt32(txtResposta.Text.Trim()))
                        {
                            case 1:
                                if (p8_1.First().regiao == "centro-oeste")
                                    ok = true;
                                break;
                            case 2:
                                if (p8_1.First().regiao == "sul")
                                    ok = true;
                                break;
                            case 3:
                                if (p8_1.First().regiao == "sudeste")
                                    ok = true;
                                break;
                            case 4:
                                if (p8_1.First().regiao == "norte")
                                    ok = true;
                                break;
                            case 5:
                                if (p8_1.First().regiao == "nordeste")
                                    ok = true;
                                break;
                        }
                        reposta = p8_1.First().regiao;
                        break;
                    case 8:
                        /* Palmeiras tem Mundial? */
                        reposta = "Nunca, jamais serão";
                        if (txtResposta.Text.ToUpper().Contains(aux_resposta) ||
                                txtResposta.Text.ToUpper().Contains(aux_resposta_1))
                        {
                            ok = true;
                        }
                        break;
                    case 9:
                        reposta = "Não existe ano = 0";
                        /* Em qual ano São Paulo não foi na parada gay? */
                        if (Convert.ToInt32(txtResposta.Text.Trim()) < 1)
                        {
                            ok = true;
                        }
                        break;
                }
            }
            catch (Exception e)
            {
                Telas.telaExplosao frmResposta =
                    new Telas.telaExplosao("Houve algum problema, verifique se digitou corretamente.");
                frmResposta.ShowDialog();
                k_ok = false;
            }
            return ok;
        }

        private void listaTimes()
        {
            List<Time> times = new List<Time>();
            Time obj = new Time();
            obj.time = "<--Seu time esta aqui-->";
            times.Add(obj);

            IMongoCollection<Time> coll_times = conn.db.GetCollection<Time>("gazetaesportiva_brasileiro_serie_a");
            var t = coll_times.AsQueryable<Time>()
                    .Select(c => c.time)
                    .Distinct()
                    .OrderBy(c => c);
            foreach (var time in t)
            {
                obj = new Time();
                obj.time = time;
                times.Add(obj);
            }
            cbTime.DataSource = times;
            cbTime.DisplayMember = "time";
            cbTime.ValueMember = "time";
        }
    
        private void btConfirma_Click(object sender, EventArgs e)
        {
            String txt_resposta = "resposta";

            if ( cbTime.Text != "<--Seu time esta aqui-->")
            {
                if (txtResposta.Text == "")
                {
                    Telas.telaExplosao frmResposta =
                        new Telas.telaExplosao("Heeeyy parece que esta tentando nos trapacear né campeão ???\nP.S: (Informe sua resposta!!!)");
                    frmResposta.ShowDialog();
                }
                else
                {
                    
                    bool valid = buscaRespostas(posicao);
                    if (k_ok)
                    {
                        if (valid)
                        {
                            txt_resposta = mensagens("C");
                            pontos++;
                        }
                        else
                        {
                            if (posicao == 4)
                            {
                                txt_resposta = "KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK\n\n" +
                                                "VOCÊ DEVE ESTAR BRINCANDO COM A MINHA CARA, SÓ PODE SER!!!\nResposta correta - " + reposta;
                            }
                            else if (posicao == 8)
                            {
                                txt_resposta = "KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK\n\n" +
                                                "PALMEIRAS???? SONHAR É BOM CARA!!!\nResposta correta - " + reposta; ;
                            }
                            else if (posicao == 9)
                            {
                                txt_resposta = "KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK\n\n" +
                                                "NOOOOOSSSSAAAAA, PARECE QUE A FLOR QUER SAIR FORA!!!\nResposta correta - " + reposta; ;
                            }
                            else
                            {
                                txt_resposta = mensagens("E") + "\nResposta correta - " + reposta;
                            }
                        }
                        txtResposta.Text = "";
                        Telas.telaExplosao frmResposta =
                            new Telas.telaExplosao(txt_resposta);
                        frmResposta.ShowDialog();
                        posicao++;
                        listaPerguntas(posicao);
                    }
                }
            }
            else
            {
                Telas.telaExplosao frmTime = 
                    new Telas.telaExplosao("Caraaa, escolhe o time!!! rsrsrs");
                frmTime.ShowDialog();

            }
        }
        private String mensagens(String op)
        {
            Random r = new Random();
            int num = r.Next(0, 10);
            String msg = "";

            if ( op == "C" )
            {
                switch (num)
                {
                    case 0: msg = "Ta benzão em pae!!!"; break;
                    case 1: msg = "Olha só, finge que manja!!!"; break;
                    case 2: msg = "Huuum, parece que entende!!!"; break;
                    case 3: msg = "Duas palavras para você, Para Bens!!! kkk"; break;
                    case 4: msg = "Esse ai ta caçando no google!!!"; break;
                    case 5: msg = "Geeenteeee to impressionado!!!"; break;
                    case 6: msg = "Parece bom(a) o(a) menino(a)"; break;
                    case 7: msg = "Diz que entende"; break;
                    case 8: msg = "Você é zica!!!"; break;
                    case 9: msg = "Certa, resposta!!!"; break;
                    case 10: msg = "Show, você esta indo bem!!!"; break;
                }
            }
            else
            {
                switch (num)
                {
                    case 0: msg = "Nossa, se liga que ruinzão!!!"; break;
                    case 1: msg = "Ave Maria, só por Deus!!!"; break;
                    case 2: msg = "Errou, cara!!!"; break;
                    case 3: msg = "Na proxima você acerta!!!"; break;
                    case 4: msg = "Vixiii!!!"; break;
                    case 5: msg = "Isso foi meio constrangedor!!!"; break;
                    case 6: msg = "kkkkkkkkk, melhor parar que ta feio!!!"; break;
                    case 7: msg = "Acertouuuu, SQN!!!"; break;
                    case 8: msg = "Menos 1 desse jeito!!!"; break;
                    case 9: msg = "Que Deus ajude na próxima"; break;
                    case 10: msg = "Crê em Deus pai, você é ruim em!!!"; break;
                }
            }
            return msg;
        }
        private void btConfig_Click(object sender, EventArgs e)
        {
            exec formExec = new exec();
            formExec.Show();
        }

        private void bt_feednews_Click(object sender, EventArgs e)
        {
            Telas.feednews frmFeed =
                new Telas.feednews();
            frmFeed.ShowDialog();
        }

        private void btBrasileiro_Click(object sender, EventArgs e)
        {
            Telas.brasileiro frmTime =
               new Telas.brasileiro();
            frmTime.ShowDialog();
        }

        private void txtResposta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btConfirma_Click(sender, e);
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
