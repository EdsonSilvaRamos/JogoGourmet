using System;
using System.Windows.Forms;

namespace JogoGourmet.Apresentacao
{
    public partial class frmTelaPergunta : Form
    {
        public bool RetornoBotaoClicado;


        public frmTelaPergunta(string textoPergunta, string tituloJanela)
        {
            InitializeComponent();
            lblPerguntaPronta.Text = textoPergunta;
            this.Text = tituloJanela;
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            RetornoBotaoClicado = true;
            this.Close();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            RetornoBotaoClicado = false;
            this.Close();
        }
    }
}
