using System.ComponentModel.DataAnnotations;

namespace Soft.Models
{
   
    public class LoginPagina
    {
        [Required(ErrorMessage = "Informe o usuario!")]
        public int Usuario { get; protected set; }

        [Required(ErrorMessage = "Informe a senha!")]
        public string Password { get; set; }

       

    }
}
