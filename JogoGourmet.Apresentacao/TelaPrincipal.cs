using JogoGourmet.Dominio.Entidades;
using JogoGourmet.Dominio.Interfaces;
using JogoGourmet.Dominio.Services;
using JogoGourmet.Utils;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace JogoGourmet.Apresentacao
{
    public partial class frmTelaPrincipal : Form
    {
        public List<Prato> ListaPratos;
        private readonly IPratoService _pratoService;

        public frmTelaPrincipal()
        {
            InitializeComponent();
            lblMensagemPrincipal.Text = TextosAuxiliares.RetornaMensagemPrincipal();            
            _pratoService = new PratoService();
            CarregaListaPratos();
        }

        private void CarregaListaPratos()
        {
            ListaPratos = _pratoService.RetornaListaPratos();
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            var pratoLasanha = ListaPratos.FirstOrDefault(w => w.Id == 2).Nome;
            var retornoTipoPratoEscolhido = false;
            var indicePratoEscolhido = 0;

            for (int i = 1; i < ListaPratos.Count; i++)
            {
                if (!retornoTipoPratoEscolhido)
                {
                    var formPergunta = new frmTelaPergunta(TextosAuxiliares.RetornaPerguntaTipoPrato(ListaPratos[i].Tipo), "Confirm");
                    formPergunta.ShowDialog();
                    indicePratoEscolhido = i;
                    retornoTipoPratoEscolhido = formPergunta.RetornoBotaoClicado;
                }
            }           

            if (retornoTipoPratoEscolhido)
            {
                var formPergunta = new frmTelaPergunta(TextosAuxiliares.RetornaPerguntaPrato(ListaPratos[indicePratoEscolhido].Nome), "Confirm");
                formPergunta.ShowDialog();
                retornoTipoPratoEscolhido = formPergunta.RetornoBotaoClicado;

                if (retornoTipoPratoEscolhido)
                {
                    var formRespostaAcerto = new frmTelaRespostaAcerto(TextosAuxiliares.RetornaRespostaAcerto());
                    formRespostaAcerto.ShowDialog();
                }
                else
                {
                    AdicionaPrato(ListaPratos[indicePratoEscolhido].Nome);
                }                
            }
            else
            {
                var boloChocolate = ListaPratos.FirstOrDefault(w => w.Id == 1).Nome;
                var formPergunta = new frmTelaPergunta(TextosAuxiliares.RetornaPerguntaBoloChocolote(boloChocolate), "Confirm");
                formPergunta.ShowDialog();
                retornoTipoPratoEscolhido = formPergunta.RetornoBotaoClicado;

                if (retornoTipoPratoEscolhido)
                {
                    var formRespostaAcerto = new frmTelaRespostaAcerto(TextosAuxiliares.RetornaRespostaAcerto());
                    formRespostaAcerto.ShowDialog();
                }
                else
                {
                    AdicionaPrato(boloChocolate);
                }
            }
        }

        private void AdicionaPrato(string pratoJaInformado)
        {
            var formPerguntaResposta = new frmTelaPerguntaResposta(TextosAuxiliares.RetornaPerguntaQualPratoPensou(), "Desisto");
            formPerguntaResposta.ShowDialog();
            var respostaPergunta = formPerguntaResposta.RespostaPergunta;
            var retornoFormPerguntaResposta = formPerguntaResposta.RetornoBotaoClicado;

            if (retornoFormPerguntaResposta)
            {
                var prato = new Prato
                {
                    Nome = respostaPergunta,
                };

                if (retornoFormPerguntaResposta)
                {
                    formPerguntaResposta = new frmTelaPerguntaResposta(TextosAuxiliares.RetornaMensagemPratoComTipoComPratoAnterior(respostaPergunta, pratoJaInformado), "Complete");
                    formPerguntaResposta.ShowDialog();
                    respostaPergunta = formPerguntaResposta.RespostaPergunta;
                    retornoFormPerguntaResposta = formPerguntaResposta.RetornoBotaoClicado;

                    if (retornoFormPerguntaResposta)
                    {
                        prato.Tipo = respostaPergunta;
                    }

                    _pratoService.AdicionaPrato(ListaPratos,prato);
                }
            }
        }
    }
}
