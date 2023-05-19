using Portafolio.Models;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Portafolio.Services
{
    public interface IEmailSendGridService
    {
        Task Enviar(ContactoViewModel contacto);
    }

    public class EmailSendGridService : IEmailSendGridService
    {
        private readonly IConfiguration _configuration;
        public EmailSendGridService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task Enviar(ContactoViewModel contacto)
        {
            var apiKey = _configuration.GetValue<string>("SENDGRID_API_KEY");
            var email = _configuration.GetValue<string>("SENDGRID_FROM");
            var nombre = _configuration.GetValue<string>("SENDGRID_NOMBRE");

            var cliente = new SendGridClient(apiKey);
            var from = new EmailAddress(email);
            var subject = $"El cliente {contacto.Email} quiere contactarte.";
            var to = new EmailAddress(email, nombre);

            var mensajeTextoPlano = contacto.Mensaje;
            var contenidoHTML = $@"De: {contacto.Nombre}
                                Email: {contacto.Email}
                                Mensaje: {contacto.Mensaje}";
            var singleEmail = MailHelper.CreateSingleEmail(from, to, subject, mensajeTextoPlano, contenidoHTML);

            var respuesta = await cliente.SendEmailAsync(singleEmail);
        }
    }
}
