using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataModel;
using System.Data.Entity;

namespace BackOffice.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
        Context db = null;
        public EmployeeController()
        {
            db = new Context();
        }

        public ActionResult Index()
        {
            var emp = db.employees.ToList();
            return View(emp);
        }

        public ActionResult Add()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Add(Employee emp)
        {
            db.employees.Add(emp);
            if (db.SaveChanges() == 1)
                return RedirectToAction("Index");
            else
                return View();
        }

        public ActionResult Modify(int id)
        {
            var employee = db.employees.Find(id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Modify(Employee emp)
        {
            db.Entry(emp).State = EntityState.Modified;
            if (db.SaveChanges() == 1)
                return RedirectToAction("Index");
            else
                return View();
        }

        public ActionResult Delete(int id)
        {
            var emp = db.employees.Find(id);
            return View(emp);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            var emp = db.employees.Find(id);
            db.Entry(emp).State = EntityState.Deleted;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
