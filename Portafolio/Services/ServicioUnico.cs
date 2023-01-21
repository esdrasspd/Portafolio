namespace Portafolio.Services
{
    public class ServicioUnico
    {
        public ServicioUnico()
        {
            ObtenerGuid = Guid.NewGuid(); //esta clase en su constructor instancia un nuevo guid
        }

        public Guid ObtenerGuid { get; private set; }
    }

    public class ServicioDelimitado
    {
        public ServicioDelimitado()
        {
            ObtenerGuid = Guid.NewGuid(); //esta clase en su constructor instancia un nuevo guid
        }

        public Guid ObtenerGuid { get; private set; }
    }

    public class ServicioTransitorio
    {
        public ServicioTransitorio()
        {
            ObtenerGuid = Guid.NewGuid(); //esta clase en su constructor instancia un nuevo guid
        }

        public Guid ObtenerGuid { get; private set; }
    }
}
