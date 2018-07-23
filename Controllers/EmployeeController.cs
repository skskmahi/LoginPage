using Login_Page.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login_Page.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Employee()
        {
            
            EmployeeEntities ee=new EmployeeEntities();
            List<SelectListItem> ss = new List<SelectListItem>();
            foreach(Department  dd in ee.Departments)
                {
                SelectListItem sssl = new SelectListItem();
                sssl.Text = dd.DeptName;
                sssl.Value = Convert.ToString(dd.DeptId);
                sssl.Selected = dd.DeptId == 1 ? true : false;
                ss.Add(sssl);
            };



            ViewBag.City = ss;

            return View();
        }
        public ActionResult GetEmployee(string id)
        {
            EmployeeContext ee = new EmployeeContext();



            return View("Contact", ee.employees.Single(m=>m.EID==id));
        }
        

    }
}