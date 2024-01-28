using BladeBlazorASP.Data;
using BladeBlazorASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace BladeBlazorASP.Controllers
{
    public class EmailSubscribersController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public EmailSubscribersController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            
        }
        public IActionResult Index()
        {   
            var emailSubscribersList=_applicationDbContext.EmailSubscribers.ToList();
            return View(emailSubscribersList);
        }
       
    }
}

