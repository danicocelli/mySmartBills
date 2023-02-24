namespace Web.GestorFinanceiro.App.Models
{
    public class Cartao
    {
        public int CartaoId { get; set; }

        public String? NomeCartao { get; set; }

        public TipoCartao TipoCartao { get;}

        public Conta? ContaId { get; set; }

        public Decimal? Limite { get; set; }

        public Decimal? LimiteConsumido { get; set; }

    }
}
 