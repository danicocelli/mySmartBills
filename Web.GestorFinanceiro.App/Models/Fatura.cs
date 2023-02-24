namespace Web.GestorFinanceiro.App.Models
{
    public class Fatura
    {
        public int FaturaId { get; set; }

        public Cartao CartaoId { get; set; }

        public DateTimeOffset? DataEncFatura { get; set; }

        public DateTimeOffset? DataFaturaPgto { get; set; }
    }
}
