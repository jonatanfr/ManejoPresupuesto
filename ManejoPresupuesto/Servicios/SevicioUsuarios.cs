namespace ManejoPresupuesto.Servicios
{
    public interface IServicioUsuarios
    {
        int ObtenerUsuarioId();
    }
    public class SevicioUsuarios: IServicioUsuarios
    {
        public int ObtenerUsuarioId()
        {
            return 1;
        }
    }
}
