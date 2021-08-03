using AkCadeMic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using AkCadeMic.Data;
using Microsoft.AspNetCore.Authorization;
using System.Net;
using System.Net.Mail;

namespace AkCadeMic.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Authorize]
        public IActionResult Discussion()
        {
            return View();
        }
        public IActionResult Policy()
        {
            return View();
        }
        public IActionResult Homepage()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(Contact record)
        {
            using (MailMessage mail = new MailMessage("akcademic@gmail.com", record.Email))
            {
                mail.Subject = record.Subject;

                string message = "Hello, " + record.SenderName + "<br/><br/>" +
                    "We have received your message. Here are the details: <br/> <br/>" +
                    "Contact Number: <strong>" + record.ContactNo + "<strong/><br/>" +
                    "Message:<br/><strong>" + record.Message + "</strong><br/><br/>" +
                    "Please wait for our response. Thank you! 🎓";
                mail.Body = message;
                mail.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient())
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new System.Net.NetworkCredential("akcademic@gmail.com", "sabenilde119");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                    ViewBag.Message = "Message sent.";
                }
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
