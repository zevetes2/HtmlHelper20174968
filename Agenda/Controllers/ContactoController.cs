using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agenda.Models;

namespace Agenda.Controllers
{
    public class ContactoController : Controller
    {
        // GET: Conctaco
        public ActionResult Index(ContactoViewModel model)
        {
            return View(model);
        }
        public ActionResult CrearContacto(ContactoViewModel model)
        {
            
            if (ModelState.IsValid)
            {
                    
                return View(model);
            }
            else
            {
                return View("CrearContacto");
            }
           
        }
        
    }
}
