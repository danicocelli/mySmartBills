namespace Web.GestorFinanceiro.App.Models
{
    public class Conta
    {
        public int ContaId { get; set; }

        public String? NomeConta { get; set; }

        public Banco? BancoId { get; set; }

        public Decimal? Saldo { get; set; }

        public TipoConta TipoConta { get; }

    }
}
