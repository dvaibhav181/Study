using Microsoft.AspNetCore.Mvc;
using DemoCoreMVC.Models;
public class ProductController : Controller
{
    public IActionResult Products()
    {
        Products productitem = new Products(1,"IPhone");
        
        ViewBag.Product = productitem;  
        
        return View();
    }
}