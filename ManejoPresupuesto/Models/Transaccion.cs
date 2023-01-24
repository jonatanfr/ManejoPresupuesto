using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Models
{
    public class Transaccion
    {
        public int Id { get; set; }
        
        public int UsuarioId { get; set; }
        [Display(Name = "Fecha Transacción")]
        [DataType(DataType.DateTime)]
        public DateTime FechaTransaccion { get; set; } = DateTime.Parse(DateTime.Now.ToString("dd-MM-yyyy hh:MM tt"));

        public decimal Monto { get; set; }
        [Range(0, maximum: int.MaxValue, ErrorMessage ="Debe seleccionar una categoria")]
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }
        [StringLength(maximumLength: int.MaxValue, ErrorMessage ="La nota no puede pasar de {1} caracteres")]
        public string Nota { get; set; }
        [Range(0, maximum: int.MaxValue, ErrorMessage = "Debe seleccionar una cuenta")]
        [Display(Name = "Cuenta")]
        public int CuentaId { get; set; }

        [Display(Name = "Tipo Operación")]
        public TipoOperacion TipoOperacionId { get; set; } = TipoOperacion.Ingreso;
    }
}
