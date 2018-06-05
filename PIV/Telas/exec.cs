using PIV.Telas;
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
    public partial class exec : Form
    {
        public exec()
        {
            InitializeComponent();
        }

        private void btExec_Click(object sender, EventArgs e)
        {
            if ( btExec.Text != "" ) {

                switch (txtExec.Text)
                {
                    case "mtpiv_ws":
                        mtpiv_ws form1 = new mtpiv_ws();
                        form1.Show();
                        break;
                    case "brasileiro":
                        brasileiro form2 = new brasileiro();
                        form2.Show();
                        break;
                    case "feednews":
                        feednews form3 = new feednews();
                        form3.Show();
                        break;
                    case "quiz":
                        quiz form4 = new quiz();
                        form4.Show();
                        break;
                }
            }
        }

        private void txtExec_KeyPress(object sender, KeyPressEventArgs e)
        {
            btExec_Click(sender, e);
        }
    }
}
