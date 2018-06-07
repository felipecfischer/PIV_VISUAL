using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIV.Fontes;
using MongoDB.Driver;
using System.Globalization;

namespace PIV.Telas
{
    public partial class feednews : Form
    {
        List<FeedNews> news;
        int ponteiro = 0;
        int ponteiro_img = 0;

        public feednews()
        {
            InitializeComponent();
        }

        private void btBusca_Click(object sender, EventArgs e)
        {
            FeedNews obj;
            List<FeedNews> coll_result = new List<FeedNews>();

            String coll;
            ponteiro_img = 0;
            news = new List<FeedNews>();

            IMongoCollection<FeedNews> coll_news;
            if (txtBuscar.Text.ToLower() != "noticias")
            {
                coll = "gazetaesportiva_search_tag";
                coll_news = conn.db.GetCollection<FeedNews>(coll);
                coll_result = coll_news.AsQueryable<FeedNews>()
                                            .Where(c => c.tag == RemoverAcentos(txtBuscar.Text.Trim().ToLower()))
                                            .OrderBy(c => c._id)
                                            .ToList();
            }
            else
            { 
                coll = "gazetaesportiva_noticias";
                coll_news = conn.db.GetCollection<FeedNews>(coll);
                coll_result = coll_news.AsQueryable<FeedNews>()
                                .OrderBy(c => c._id)
                                .ToList();
            }

            if (coll_result.Count > 0)
            {
                foreach (var f in coll_result)
                {
                    obj = new FeedNews();
                    obj._id = f._id;
                    obj.categoria = f.categoria;
                    obj.titulo = f.titulo;
                    obj.texto = f.texto;
                    obj.img = f.img;
                    obj.data = f.data;

                    news.Add(obj);
                }
                display_news();
            }
            else
            {
                txtDetalhes.Text = "Nenhum resultado encontrado!";
                lbTitulo.Text = "Nenhum resultado encontrado!";
            }
        }

        private void ts_first_Click(object sender, EventArgs e)
        {
            if (news.Count > 0)
            {
                ponteiro = 0;
                display_news();
            }
        }
        private void ts_last_Click(object sender, EventArgs e)
        {
            if (news.Count > 0)
            { 
                ponteiro = news.Count-1;
                display_news();
            }
        }

        private void display_news(){
            lbTitulo.Text = news[ponteiro].categoria + "\n" + news[ponteiro].titulo;
            txtDetalhes.Text = news[ponteiro].texto + "\n\n" + news[ponteiro].data;

            picImagem.Image = null;

            if (news[ponteiro].img != null)
            {
                picImagem.Visible = true;
            }
            else
            {
                picImagem.Visible = false;
            }
        }

        private void display_img()
        {
            if (  news[ponteiro].img != null )
            {
                if ( news[ponteiro].img.Count() > 0 )
                {
                    if (ponteiro_img < news[ponteiro].img.Count())
                    {
                        picImagem.Load(news[ponteiro].img[ponteiro_img]);
                    }
                }
                else
                {
                    picImagem.Image = null;
                }      
            }
            else
            {
                picImagem.Image = null;
            }
        }

        private void ts_next_Click(object sender, EventArgs e)
        {
            if (ponteiro < news.Count-1)
            {
                ponteiro++;
                display_news();
                ts_next.Enabled = true;
            }
        }
        private void ts_previous_Click(object sender, EventArgs e)
        {
            if (ponteiro > 0)
            {
                ponteiro--;
                display_news();
                ts_previous.Enabled = true;
            }
        }    

        private void picImagem_Click(object sender, EventArgs e)
        {
            display_img();
        }

        public static string RemoverAcentos(string texto)
        {

            StringBuilder sbReturn = new StringBuilder();
            var arrayText = texto.Normalize(NormalizationForm.FormD).ToCharArray();
            foreach (char letter in arrayText)
            {
                if (System.Globalization.CharUnicodeInfo.GetUnicodeCategory(letter)
                    != System.Globalization.UnicodeCategory.NonSpacingMark)
                    sbReturn.Append(letter);
            }
            return sbReturn.ToString();
        }
    }
}
