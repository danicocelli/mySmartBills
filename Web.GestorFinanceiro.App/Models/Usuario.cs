using System.ComponentModel.DataAnnotations.Schema;

namespace Web.GestorFinanceiro.App.Models
{
    public class Usuario
    {
        [Column("ID_USUARIO")]
        public int UsuarioId { get; set; }

        [Column("USERNAME")]
        public String Username { get; set; }

        [Column("PASSWORD")]
        public String Password { get; set; }

        [Column("NOME")]
        public String Nome { get; set; }

        [Column("APELIDO")]
        public String Apelido { get; set; }

        [Column("EMAIL")]
        public String Email { get; set; }

        [Column("TELEFONE")]
        public String? Telefone { get; set; }
    }
}
