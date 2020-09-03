using System;
using System.Net.Mail;
using System.Web.Mvc;

namespace CreISys.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (TempData["Message"] != null)
            {
                ViewBag.Message = TempData["Message"];
            }
            return View();
        }
        public ActionResult ErrorPage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EnviarMail(string name, string email, string message, string phone)
        {
            string emailOrigen = "";
            string emailDestino = "";
            string pass = "";
            string asunto = "Mensaje de la pagina de CreISys";
            string mensaje = "Nombre: " + name + ", Correo: " + email + ", Telefono: " + phone + ". Mensaje: " + message;


            MailMessage oMailMessage = new MailMessage(emailOrigen, emailDestino, asunto, mensaje);

            oMailMessage.IsBodyHtml = true;

            SmtpClient oSmtpClient = new SmtpClient("smtp.gmail.com");
            oSmtpClient.EnableSsl = true;
            oSmtpClient.UseDefaultCredentials = false;
            oSmtpClient.Port = 587;
            oSmtpClient.Credentials = new System.Net.NetworkCredential(emailOrigen, pass);

            oSmtpClient.Send(oMailMessage);

            oSmtpClient.Dispose();

            @TempData["Message"] = "Su mensaje fue enviado correctamente. Nos comunicaremos a la brevedad.";

            return Redirect(Url.Content("~/Home"));
        }
    }
}