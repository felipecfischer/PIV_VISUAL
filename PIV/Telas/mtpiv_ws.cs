using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIV
{
    public partial class mtpiv_ws : Form
    {
        public mtpiv_ws()
        {
            InitializeComponent();
            carregaCombos();
        }

        private void carregaCombos()
        {
            List<String> comboBr = new List<string>();
            List<String> comboCopa = new List<string>();

            comboBr.Add("<--Selecione-->");
            comboBr.Add("A");
            comboBr.Add("B");
            comboBr.Add("C");
            comboBr.Add("D");
            comboCopa.Add("<--Selecione-->");
            comboCopa.Add("Copa do Brasil");
            comboCopa.Add("Copa do Nordeste");

            cbBr.DataSource = comboBr;
            cbCopa.DataSource = comboCopa;
        }

        private void txtPage_TextChanged(object sender, EventArgs e)
        {
            if (txtPage.Text != "")
            {
                txtTag.Enabled = false;
                txtPageTag.Enabled = false;
                cbBr.Enabled = false;
                cbCopa.Enabled = false;
            }
            else
            {
                txtTag.Enabled = true;
                txtPageTag.Enabled = true;
                cbBr.Enabled = true;
                cbCopa.Enabled = true;
            }
        }

        private void txtTag_TextChanged(object sender, EventArgs e)
        {
            if (txtTag.Text != "")
            {
                txtPage.Enabled = false;
                cbBr.Enabled = false;
                cbCopa.Enabled = false;
            }
            else
            {
                txtPage.Enabled = true;
                cbBr.Enabled = true;
                cbCopa.Enabled = true;
            }
        }
        
        private void txtPageTag_TextChanged(object sender, EventArgs e)
        {
            if (txtPageTag.Text != "")
            {
                txtPage.Enabled = false;
                cbBr.Enabled = false;
                cbCopa.Enabled = false;
            }
            else
            {
                txtPage.Enabled = true;
                cbBr.Enabled = true;
                cbCopa.Enabled = true;
            }
        }

        private void cbBr_TextChanged(object sender, EventArgs e)
        {
            if ( (String)cbBr.SelectedItem != "<--Selecione-->" )
            {
                txtPage.Enabled = false;
                txtTag.Enabled = false;
                txtPageTag.Enabled = false;
                cbCopa.Enabled = false;
            }
            else
            {
                txtPage.Enabled = true;
                txtTag.Enabled = true;
                txtPageTag.Enabled = true;
                cbCopa.Enabled = true;
            }
        }

        private void cbCopa_TextChanged(object sender, EventArgs e)
        {
            if ( (String)cbCopa.SelectedItem != "<--Selecione-->" )
            {
                txtPage.Enabled = false;
                txtTag.Enabled = false;
                txtPageTag.Enabled = false;
                cbBr.Enabled = false;
            }
            else
            {
                txtPage.Enabled = true;
                txtTag.Enabled = true;
                txtPageTag.Enabled = true;
                cbBr.Enabled = true;
            }
        }
        
        private void btReload_Click(object sender, EventArgs e)
        {
            bool ok = true;
            var ws = new PIV_WS.webscraping_WS();
            ws.Timeout = -1;

            if ( !( txtPage.Enabled &&
                    txtTag.Enabled  &&
                    txtPageTag.Enabled &&
                    cbBr.Enabled    &&
                    cbCopa.Enabled ) )
            {
                if (txtPage.Enabled)
                {
                    if (Convert.ToInt32(txtPage.Text) > 0)
                    {
                        label_inf.Text = "Carregando...";
                        ok = ws.feed(Convert.ToInt32(txtPage.Text.Trim()));
                    }
                }
                else if (txtTag.Enabled)
                {
                    if (txtTag.Text != "")
                    {
                        if (Convert.ToInt32(txtPageTag.Text) > 0)
                        {
                            label_inf.Text = "Carregando...";
                            ok = ws.tag(RemoverAcentos(txtTag.Text.TrimEnd()).Replace(" ","-"), Convert.ToInt32(txtPageTag.Text));
                        }
                    }
                }
                else if (cbBr.Enabled)
                {
                    if (cbBr.SelectedItem.ToString() != "<--Selecione-->")
                    {
                        label_inf.Text = "Carregando...";
                        ok = ws.tabelabr(cbBr.SelectedItem.ToString(), 0);
                    }
                }
                else if (cbCopa.Enabled)
                {
                    if (cbCopa.SelectedItem.ToString() != "<--Selecione-->")
                    {
                        label_inf.Text = "Carregando...";
                        ok = ws.copa_select(cbCopa.SelectedItem.ToString());
                    }
                }

                if (ok)
                {
                    MessageBox.Show("Importação feita com sucesso!");
                }
                else
                {

                    MessageBox.Show("Houve alguma falha na importação, favor verificar com o Administrador.");
                }
                label_inf.Text = "";
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtPage.Clear();
            txtTag.Clear();
            txtPageTag.Clear();
            cbBr.SelectedItem = "<--Selecione-->";
            cbCopa.SelectedItem = "<--Selecione-->";
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private string RemoverAcentos(string text)
        {
            StringBuilder sbReturn = new StringBuilder();
            var arrayText = text.Normalize(NormalizationForm.FormD).ToCharArray();
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
