﻿using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Operations;

namespace DevCard_MVC.Controllers
{
    public class Test : Controller
    {
        //public IActionResult Index()
        //{
        //    return PartialView("Footer");
        //}

        //public PartialViewResult Index()
        //{
        //    return PartialView("Footer");
        //}

        //public ContentResult Index()
        //{
        //    return Content("<h1 style='color = red'>Hello World!</h1>", "text/html");
        //}

        //public EmptyResult Index()
        //{
        //    return new EmptyResult();
        //    //return null
        //}

        //public FileResult Index()
        //{
        //    //return File("~/test.txt", "text/html");
        //    var fileByte = System.IO.File.ReadAllBytes("wwwroot/test.txt");
        //    const string fileName = "testFile.txt";
        //    return File(fileByte, MediaTypeNames.Text.Plain, fileName);
        //}

        //public JsonResult Index()
        //{
        //    return Json(new
        //    {
        //        id = 12,
        //        name = "Farhad",
        //        job = "programmer",
        //        site = "neptonetech.ir"
        //    });
        //}

        //public JavascriptResult Index()
        //{
        //    return new JavascriptResult("alert('salam man')");
        //}

        //public RedirectResult Index()
        //{
        //    return Redirect("http://www.atriya.com");
        //}

        //public RedirectToActionResult Index()
        //{
        //    return RedirectToAction("Contact", "Home");
        //}

        //public IActionResult Index()
        //{
        //    //return new OkResult();
        //    //return new NotFoundResult();
        //    //return new BadRequestResult();
        //    //return new NoContentResult();
        //    return new StatusCodeResult(510);
        //}
    }

    //public class JavascriptResult : ContentResult
    //{
    //    public JavascriptResult(string data)
    //    {
    //        Content = data;
    //        ContentType = "application/javascript";
    //    }
    //}
}
