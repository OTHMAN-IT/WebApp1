using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using WebApp1.Models;

namespace WebApp1.Controllers
{
    public class SendMailerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create()
        {
            if (ModelState.IsValid)
            {
                MailMessage mail = new MailMessage();
                mail.To.Add("elbiyaaliothmane95@gmail.com");
                mail.From = new MailAddress("elbiy95@gmail.com");
                mail.Subject = "Test";
                mail.Body = "Helloo";
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("elbiy95@gmail.com", "OTHMANE20.");   
                smtp.EnableSsl = true;
                smtp.Send(mail);
                return View("Index");
            }
            else
            {
                return View();
            }
        }
    }
}
