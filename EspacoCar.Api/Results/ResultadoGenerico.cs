namespace EspacoCar.Api.Results
{
    public class ResultadoGenerico
    {
        public ResultadoGenerico(bool status, string mensagem, object dados)
        {
            Sucesso = status;
            Mensagem = mensagem;
            Dados = dados;
        }

        public bool Sucesso { get; private set; }
        public string Mensagem { get; private set; }
        public object Dados { get; private set; }
    }
}