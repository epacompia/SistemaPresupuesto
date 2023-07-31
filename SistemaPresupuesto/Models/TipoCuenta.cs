using System.ComponentModel.DataAnnotations;

namespace SistemaPresupuesto.Models
{
    public class TipoCuenta
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="El campo {0} es requerido")]
        //[StringLength(maximumLength:50, MinimumLength =3, ErrorMessage ="la longitud varia entre {2} y {1} caracteres")]
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }
        public int Orden { get; set; }


        ///*pruebas de otras validaciones*/
        //[Required(ErrorMessage = "El campo {0} es requerido")]
        //[EmailAddress(ErrorMessage ="El campo {0} debe ser un correo electronico valido")]
        //public string Email { get; set; }

        //[Range(minimum:18,maximum:130,ErrorMessage ="el valor debe estar dentro de {1} y {2}")]
        //public int Edad { get; set; }

        //public string  Url { get; set; }

        //[CreditCard(ErrorMessage ="la tarjeta debe ser valida")]
        //[Display(Name ="Tarjeta de credito")]
        //public string TarjetaDeCredito { get; set; }
    }
}
