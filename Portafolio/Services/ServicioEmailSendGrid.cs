using Portafolio.Models;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Portafolio.Services
{
    public interface IServicioEmail
    {
        Task Enviar(ContactoViewModel contacto);
    }
    public class ServicioEmailSendGrid: IServicioEmail
    {
        private readonly IConfiguration configuration;
        public ServicioEmailSendGrid(IConfiguration configuration) //se necesita la configuracion pq la llave se coloca en un proveedor de configuracion
        {
            this.configuration = configuration;
        }

        public async Task Enviar(ContactoViewModel contacto)
        {
            var apiKey = configuration.GetValue<string>("SENDGRID_API_KEY"); //configurando la apikey
            var email = configuration.GetValue<string>("SENDGRID_FROM"); //configurando el email
            var nombre = configuration.GetValue<string>("SENDGRID_NOMBRE"); //configurando el nombre
            
            var cliente = new SendGridClient(apiKey);

            var from = new EmailAddress(email, nombre); //de quien viene el email
            var subject = $"El cliente {contacto.Email} quiere contactarte"; //mensaje que llega a nuestro email
            var to = new EmailAddress(email, nombre); //para quien va (nosotros mismos)
            var mensajeTextoPlano = contacto.Mensaje; //mensaje que envia el cliente
            var contenidoHtml = @$"De: {contacto.Nombre} -
Email: {contacto.Email}
Mensaje: {contacto.Mensaje}"; //string de varias lineas
            var singleEmail = MailHelper.CreateSingleEmail(from, to, subject, mensajeTextoPlano, contenidoHtml); //configurando el email
            var respuesta = await cliente.SendEmailAsync(singleEmail); //enviando el email
        }


    }
}
