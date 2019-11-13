using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using System.Net.Mail;
using WebApplication2.Protected;
using System.Security;

namespace WebApplication2.Pages {
    public class ContactModel : PageModel {


        public string testString = "Hello World";

        [BindProperty]
        public ContactFormModel Contact { get; set; }

        public void OnGet() {

        }

        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            MailAddress fromAddress = new MailAddress(Password.fromEmail, Password.fromName);
            MailAddress toAddress = new MailAddress(Password.toEmail, Password.toName);

            SmtpClient smtp = new SmtpClient {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, Password.password)
            };

            using MailMessage msg = new MailMessage(fromAddress, toAddress) {
                Subject = "hello, you have a new message",
                Body = $"Message is from: {Contact.Name} of email: {Contact.Email} and it says the following {Contact.Message}"
            };

            await smtp.SendMailAsync(msg);
            msg.Dispose();
            smtp.Dispose();

            return RedirectToPage("Index");
        }

        public async Task SendEmailAsync(MailAddress sendFrom, MailAddress sendTo, string subject, string body) {

        }
    }

    public class SendMail {

    }


    public class ContactFormModel {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }
    }
}