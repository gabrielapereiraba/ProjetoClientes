using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProjetoClientes.Models
{
    [Table("ProjetoClientes")]
    public class Clientes
    {
        [Column("Id")]
        [Display(Name ="Id")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string? Nome { get; set; }

        [Column("CPF")]
        [Display(Name = "CPF")]
        public string? CPF { get; set; }

        [Column("Tipo")]
        [Display(Name = "Tipo de cliente")]
        public string? TipoDeCliente { get; set; }

        [Column("Sexo")]
        [Display(Name = "Sexo")]
        public string? Sexo { get; set; }

        [Column("Status")]
        [Display(Name = "Status do Cliente")]
        public string? StatusDoCliente { get; set; }

        }
}
