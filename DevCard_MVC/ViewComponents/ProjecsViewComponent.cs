using System.Collections.Generic;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(1,"تاکسی", "درخواست آنلاین تاکسی","project-1.jpg","Neptune"),
                new Project(2,"زودفود", "درخواست آنلاین غذ","project-2.jpg","ZoodFood"),
                new Project(3,"مدارس", "سیستم مدیریت یکپارچه مدارس","project-3.jpg","MONOP"),
                new Project(4,"فضاپیما", "برنامه مدیریت فضا پیماهای ناسا","project-4.jpg","NASA"),
            };
            return View("_Projects", projects);
        }
    }

}
