using LearningHub.Core.DTO;
using LearningHub.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;

namespace LearningHub.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IRegisterService _registerService;
        public RegisterController(IRegisterService registerService)
        {
            _registerService = registerService;
        }
        [HttpPost]
        [Route("Register")]
        public IActionResult Auth([FromBody] UserRegister user) // Ensure you are binding the user from the request body
        {
            var registeredUsers = _registerService.Auth(user);

            if (registeredUsers == null)
            {
                return BadRequest("Registration failed. Please check the provided information or try again.");
            }
            var e = user.u_email;
            var n = user.u_name;
            SendConfirmationEmail(e, n);


            return Ok("Registration successful. A confirmation email has been sent.");
        }

        private bool SendConfirmationEmail(string toEmail, string userName)
        {
            try
            {
                // Set up the SMTP client
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("mh.qud2551996@gmail.com", "bwssdnivemyrbirk"), // Update these
                    EnableSsl = true,
                };

                // Create the email message
                var mailMessage = new MailMessage
                {
                    From = new MailAddress("mh.qud2551996@gmail.com", "Learning Zone"), // Update this
                    Subject = "Registration Confirmation",
                    Body = $"Hello {userName},\n\nThank you for registering!\n\n your email well be check from admin and will be return email if you are accepted or not \n\n Regards,Learning Zone Admin",
                    IsBodyHtml = true,
                };

                mailMessage.To.Add(toEmail);

                // Send the email
                smtpClient.Send(mailMessage);
                return true;
            }
            catch (Exception ex)
            {
                // Log the exception if necessary
                Console.WriteLine($"Error sending email: {ex.Message}");
                return false; // Handle errors as needed
            }
        }

    }
}
