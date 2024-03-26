using System.Windows.Forms;

namespace JogoGourmet.Apresentacao
{
    public partial class frmTelaPerguntaResposta : Form
    {
        public bool RetornoBotaoClicado;
        public string RespostaPergunta;

        public frmTelaPerguntaResposta(string perguntaResposta, string tituloJanela)
        {
            InitializeComponent();
            lblPerguntaResposta.Text = perguntaResposta;
            this.Text = tituloJanela;
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            RespostaPergunta = txtPerguntaResposta.Text;
            RetornoBotaoClicado = true;
            this.Close();
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            RetornoBotaoClicado = false;
            this.Close();
        }
    }
}
