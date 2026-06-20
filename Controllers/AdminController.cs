using Microsoft.AspNetCore.Mvc;

namespace dotnet_store.Controllers;

public class Admincontroller : Controller
{
    public ActionResult Index()
    {
        return View();
    }
}