using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Soft.Models
{
    [Table("Produtos")]
    public class Produtos
    {
        [Column("Id")]
        [Display(Name = "Id")]
        public int Id { get;  set; }

        [Column("Descricao")]
        [Display(Name = "Descricao")]
        [Required(ErrorMessage = "Informe a descrição!")]
        public string Descricao { get; set; }

        [Column("Codigo")]
        [Display(Name = "Codigo")]
        [Required(ErrorMessage = "Digite o codigo!")]
        public string Codigo { get; set; }

        [Column("Venda")]
        [Display(Name = "Venda")]
        [Required(ErrorMessage = "Digite o preco de venda!")]
        public double Venda { get; set; }
        [Column("PesoBruto")]
        [Display(Name = "PesoBruto")]
        [Required(ErrorMessage = "Digite o peso bruto !")]
        public double PesoBruto { get; set; }

        [Column("PesoLiquido")]
        [Display(Name = "PesoLiquido")]
        [Required(ErrorMessage = "Digite o peso liquido!")]
        public double PesoLiquido { get; set; }

    }
}
