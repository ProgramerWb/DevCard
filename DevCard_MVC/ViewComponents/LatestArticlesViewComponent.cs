using System.Collections.Generic;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC
{
    public class LatestArticlesViewComponent : ViewComponent

    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(1,"آموزش Asp.net Core MVC", "کاملترین پکیج آموزشی ASp.net Core MVC", "blog-post-thumb-card-1.jpg"),
                new Article(2,"آموزش Git & GitHub", "کاملترین پکیج آموزشی Git & GitHub", "blog-post-thumb-card-2.jpg"),
                new Article(3,"آموزش Online Architecture", "کاملترین پکیج آموزشی Online Architecture", "blog-post-thumb-card-3.jpg"),
                new Article(4,"آموزش طراحی سایت", "کاملترین پکیج آموزشی طراحی سایت", "blog-post-thumb-card-4.jpg")
            };
            return View("_LatestArticles", articles);
        }
    }
}
