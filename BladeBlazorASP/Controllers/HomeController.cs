using BladeBlazorASP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;

namespace BladeBlazorASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SendEmail( SendEmail email,IFormFile AttachedFile)
        {
            var myAppConfig = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var Username=myAppConfig.GetValue<string>("EmailConfigurationSettings:Username");
            var Password=myAppConfig.GetValue<string>("EmailConfigurationSettings:Password");
            var Host=myAppConfig.GetValue<string>("EmailConfigurationSettings:Host");
            var Port=myAppConfig.GetValue<int>("EmailConfigurationSettings:Port");
            var FromEmail= myAppConfig.GetValue<string>("EmailConfigurationSettings:FromEmail");

            MailMessage message= new MailMessage();
            message.From=new MailAddress(FromEmail);
            message.To.Add(email.ToEmail.ToString());
            message.Subject=email.Subject;
            message.IsBodyHtml = true;
            message.Body = email.EmailMessageBody;
            message.Attachments.Add(new Attachment(AttachedFile.OpenReadStream(), AttachedFile.FileName));

            SmtpClient mailClient = new SmtpClient(Host);
             mailClient.Credentials=new System.Net.NetworkCredential(Username,Password);
            try
            {
                 mailClient.UseDefaultCredentials = true;
                 mailClient.Host = Host;
                 mailClient.Port=Port;
               //  mailClient.EnableSsl =true;
                 mailClient.Send(message);

            }
            catch (Exception ex)   
            {

                throw;
            }
            finally
            {
                mailClient.Dispose();
            }



            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
