namespace JogoGourmet.Utils
{
    public static class TextosAuxiliares
    {
        public static string RetornaMensagemPrincipal()
        {
            return "Pense em um prato que goste";
        }

        public static string RetornaPerguntaTipoPrato(string tipo)
        {
            return $"O prato que você pensou é {tipo}?";
        }

        public static string RetornaPerguntaPrato(string lasanha)
        {
            return $"O Prato que você pensou é {lasanha}?";
        }

        public static string RetornaRespostaAcerto()
        {
            return "Acertei de novo!";
        }

        public static string RetornaPerguntaQualPratoPensou()
        {
            return "Qual o prato você pensou?";
        }

        public static string RetornaMensagemPratoComTipoComPratoAnterior(string prato, string pratoAnterior)
        {
            return $"{prato} é ____, mas {pratoAnterior} não.";
        }

        public static string RetornaPerguntaBoloChocolote(string boloChocolate)
        {
            return $"O prato que você pensou é {boloChocolate}?";
        }
    }
}
