using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Soft.Models
{
    [Table("Clientes")]
    public class Clientes
    {
        [Column("Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Digite o nome!")]
        public string Nome { get; set; }

        [Column("Fantasia")]
        [Display(Name = "Nome Fantasia")]
        [Required(ErrorMessage = "Digite o nome fantasia!")]
        public string Fantasia { get; set; }

        [Column("Documento")]
        [Display(Name = "Documento")]
        [Required(ErrorMessage = "Digite o documento!")]
        public string Documento { get; set; }

        [Column("Endereco")]
        [Display(Name = "Endereco")]
        [Required(ErrorMessage = "Digite o endereco!")]
        public string Endereco { get; set; }

    }
}
