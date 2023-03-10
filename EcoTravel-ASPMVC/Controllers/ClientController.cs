using EcoTravel_ASPMVC.Handlers;
using EcoTravel_ASPMVC.Models.ClientViewModel;
using EcoTravel_BLL.Entities;
using EcoTravel_Common.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoTravel_ASPMVC.Controllers
{
  

    public class ClientController : Controller
    {  
        private readonly IClientRepository<Client, int> _service;
        private readonly SessionManager _sessionManager;

        public ClientController(IClientRepository<Client, int> service, SessionManager sessionManager)
        {
            _service = service;
            _sessionManager = sessionManager;
    
        }

        // GET: ClientController
        public ActionResult Index()
        {

            IEnumerable<ClientListItem> model = _service.Get().Select(e => e.ToListItem());
            return View(model);
        }

        // GET: ClientController/Details/5
        public ActionResult Details(int id)
        {
            ClientDetails model = _service.Get(id).ToDetails();
            if (model is null)
            {
                TempData["Error"] = "Client inexistant...";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: ClientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClientCreateForm form)
        {
            if (!ModelState.IsValid)
            {
                form.password = null;
                form.repassword = null;
                return View(form);
            }
            else
            {
                int id = _service.Insert(form.ToBLL());
                return RedirectToAction("Details", "Client", new { id = id });
            }
        }



        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientController/Edit/5
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

        // GET: ClientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientController/Delete/5
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

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginForm form)
        {
            if (!ModelState.IsValid) return View();
            
            return RedirectToAction("Index");

        }

        
    }
}

