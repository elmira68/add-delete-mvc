using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace NEW_MVC
{
    public class HomeController : Controller
    {
        public readonly connect _connect;
        public HomeController(connect connect)
        {
            _connect = connect;
        }
        // public IActionResult product()
        // {
        //     return View();
        // }
        public IActionResult index()
        {
            return View();
        }

   public IActionResult Add(product pd)
        {
            pd.id = pd.id;
            pd.name = pd.name;
            pd.type = pd.type;
            pd.price = pd.price;

            _connect.products.Add(pd);
            _connect.SaveChanges();

            return RedirectToAction("Show_Product");


        }
        public IActionResult Show_Product()
        {
            var List = _connect.products.ToList();
            return View(List); 
        }

        public IActionResult Delete(int id)
        {
            var Select = _connect.products.Where(a => a.id == id).SingleOrDefault();
            _connect.products.Remove(Select);
            _connect.SaveChanges();

            return RedirectToAction("Show_Product");
        }


     
    }
}