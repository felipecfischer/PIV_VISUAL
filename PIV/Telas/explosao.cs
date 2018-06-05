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
    public partial class telaExplosao : Form
    {
        public telaExplosao(String aux)
        {
            InitializeComponent();
            lbDisplay.Text = aux;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
