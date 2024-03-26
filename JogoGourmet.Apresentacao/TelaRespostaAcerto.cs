using System.Windows.Forms;

namespace JogoGourmet.Apresentacao
{
    public partial class frmTelaRespostaAcerto : Form
    {
        public frmTelaRespostaAcerto(string textoAcerto)
        {
            InitializeComponent();
            lblAcerto.Text = textoAcerto;
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
