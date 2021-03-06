
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CahBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandomController : Controller
    {
        // GET: RandomController
        [Route("get")]
        [HttpGet]
        public string Index()
        {
            var rawr = "Rawr";
            return rawr;
        }

        // GET: RandomController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RandomController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RandomController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RandomController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RandomController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RandomController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RandomController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
