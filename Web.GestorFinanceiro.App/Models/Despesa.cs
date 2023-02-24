using System.ComponentModel.DataAnnotations.Schema;

namespace Web.GestorFinanceiro.App.Models
{
    public class Despesa
    {
        [Column("ID_DESPESA")]
        public int DespesaId { get; set; }

        [Column("NOME_DESPESA")]
        public String? NomeDespesa { get; set; }

        [Column("RECORRENTE")]
        public bool Recorrente { get; set; }

        [Column("TIPO_DESPESA")]
        public TipoDespesa TipoDespesa { get; set; }

        [Column("DATA_DESPESA")]
        public DateTime? DespesaData { get; set;}

        [Column("VALOR_DESPESA")]
        public Decimal? ValorDespesa { get; set; }

        [Column("DESCRICAO_DESPESA")]
        public String? DescricaoDespesa { get; set; }

        [Column("DATA_ALTERACAO")]
        public DateTime? DataCadastroAlteracao { get; set; }

        [Column("OPERACAO")]
        public TipoOperacao Operacao { get; set; }

        //public Cartao? CartaoId { get; set; }

        //public Conta? ContaId { get; set; }

        [Column("SITUACAO")]
        public int Situacao { get; set; }
    }
}
