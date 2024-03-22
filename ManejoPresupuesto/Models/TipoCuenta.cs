using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Models
{
    public class TipoCuenta
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 20, MinimumLength = 10, ErrorMessage = "La longitud del campo {0} debe estar entre {2} y {1}")]
        [Display(Name = "Nombre del Tipo Cuenta")]
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }
        public int Orden { get; set; }

        /*Pruebas de otras validaciones por defecto*/
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [EmailAddress(ErrorMessage = "El Campo debe ser un correo electronico válido")]
        public string Email { get; set; }
        [Range(minimum:18,maximum:130, ErrorMessage = "El valor debe estar entre {1} y {2}")]
        public int Edad { get; set; }
        [Url(ErrorMessage = "El campo debe ser una URL válida")]
        public string URL { get; set; }
        [CreditCard(ErrorMessage = "La tarjeta de crédito no es válida")]
        [Display(Name = "Tarjeta de Credito")]
        public string TarjetaDeCredito { get; set; }
    }
}
