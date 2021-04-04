using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pro.Data;
using Pro.Models;
using Pro.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pro.Controllers
{
    [Route("certification")]
    public class CertificationController : Controller 
    {
        private readonly MvcCertificationContext _context;

        private readonly CertificationService _certificationService;

        public CertificationController(MvcCertificationContext context)
        {
            _context = context;

        }
        //public CertificationController(CertificationService certificationService)
        //{
        //    _certificationService = certificationService;
        //}
        [Route("index")]
        [Route("")]
        [Route("~/")]
        // GET: CertificationController
        public IActionResult Index()
        {
            //return View(_certificationService.FindAll());  
            CertificationServiceImpl certificationService = new CertificationServiceImpl(_context); 
            IEnumerable<Certification> obls = certificationService.FindAll();
            return View(obls);
        }



        // GET: CertificationController/Create
        [Route("create")]
        public IActionResult Create()
        {
            return View("create");
        }

        // POST: CertificationController/Create
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

        // GET: CertificationController/Edit/5
        [Route("edit")]
        public IActionResult Edit(int id)
        {
            return View("edit");
        }

        // POST: CertificationController/Edit/5
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

        // GET: CertificationController/Delete/5
        [Route("delete")]
        public IActionResult Delete(int id)
        {
            return View("delete");
        }

        // POST: CertificationController/Delete/5
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
