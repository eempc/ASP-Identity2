using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using System.Net.Mail;

namespace WebApplication2.Pages {
    public class ContactModel : PageModel {
        MailAddress fromAddress = new MailAddress("evctestemail@gmail.com", "No Reply");
        
        public string testString = "Hello World!";

        [BindProperty]
        public ContactFormModel Contact { get; set; }

        public void OnGet() {

        }

        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            MailAddress toAddress = new MailAddress(Contact.Email, Contact.Name);    

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