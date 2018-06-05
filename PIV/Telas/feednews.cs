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
            String tag = "gazetaesportiva_" + txtBuscar.Text.Trim().ToLower();
            ponteiro_img = 0;
            news = new List<FeedNews>();

            if (txtBuscar.Text.ToLower() != "noticias")
                tag = "gazetaesportiva_search_" + RemoverAcentos(txtBuscar.Text.ToLower()).Replace(" ","-");

            IMongoCollection<FeedNews> coll_news = conn.db.GetCollection<FeedNews>(tag);

            var p3 = coll_news.AsQueryable<FeedNews>()
                                    .OrderBy(c => c._id)
                                    .ToList();
            if (p3.Count == 0)
            {
                txtDetalhes.Text = "Nenhum resultado encontrado!";
                lbTitulo.Text    = "Nenhum resultado encontrado!";
            }
            else
            {
                foreach (var f in p3)
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
        }

        private void ts_first_Click(object sender, EventArgs e)
        {
            ponteiro = 0;
            display_news();          
        }
        private void ts_last_Click(object sender, EventArgs e)
        {
            ponteiro = news.Count-1;
            display_news();
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

            string s = texto.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            for (int k = 0; k < s.Length; k++)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(s[k]);
                if (uc != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(s[k]);
                }
            }
            return sb.ToString();
        }
    }
}
