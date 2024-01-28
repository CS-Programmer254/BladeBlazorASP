using BladeBlazorASP.Data;
using BladeBlazorASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace BladeBlazorASP.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ProjectsController(ApplicationDbContext applicationDbContext, IWebHostEnvironment webHostEnvironment)
        {
            _applicationDbContext = applicationDbContext;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddNewProject()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddNewProject(Project project, IFormFile? file)
        {
           

                string wwwRootPath = _webHostEnvironment.WebRootPath;

                if(file is not null)
                {
                    string fileName=Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string projectPath=Path.Combine(wwwRootPath,@"images\projects");
                    using (var fileStream = new FileStream(Path.Combine(projectPath,fileName),FileMode.Create))
                    {
                        file.CopyTo(fileStream);

                    }
                    project.ProjectImg = @"\images\projects\" + fileName;

                }
               
                _applicationDbContext.Projects.Add(project);
                _applicationDbContext.SaveChanges();
                TempData["success"] = "Project created successfully";


            
            return RedirectToAction("Index");

        }

        [HttpPost]
        public IActionResult Index(EmailSubscribers emailSubscriber)
        {

            _applicationDbContext.EmailSubscribers.Add(emailSubscriber);
            _applicationDbContext.SaveChanges();
            TempData["success"] = "Your Have Successfully Subscribed to Our News Letters";
            return View();
        }
    }
}
