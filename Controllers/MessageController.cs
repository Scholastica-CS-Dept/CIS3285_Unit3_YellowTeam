using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

//Changes for Sprint 2 -- User Story -- Jake Jablonsky

//Changes Sprint 2 --As a system administrator, I want to serve hundreds of users concurrently -- Jake Jablonsky

namespace CIS3285_Unit3Sample_2024.Controllers
{
    public class MessageController : Controller
    {
        // GET: MessageController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MessageController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MessageController/Create
        //
        public ActionResult Create()
        {
            return View();
        }

        // POST: MessageController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]

        //Changes Sprint 2 -- Instead of crashing, return with the view for the user. -- Jake Jablonsky
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

        // GET: MessageController/Edit/5

        //Changes Sprint 2 --Adds a way to edit the id by the user. -- Jake Jablonsky
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MessageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]

        //Changes Sprint 2 -- Edit the id and form collection without crashing -- Jake Jablonsky
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

        // GET: MessageController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MessageController/Delete/5
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
