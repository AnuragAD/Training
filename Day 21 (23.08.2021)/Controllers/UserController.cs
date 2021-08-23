using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day_23MVC.Models;
namespace Day_23MVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User

        public ActionResult Index()
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.User_Tbl.ToList());
            }
            
        }

        [HttpGet]
        public ActionResult AddOrEdit(int Id=0)
        {
            User_Tbl userModel = new User_Tbl();

            return View(userModel);
        }

        //POST: User
        [HttpPost]    ///Insert
        public ActionResult AddOrEdit(User_Tbl userModel)
        {
            using (DbModels dbModel= new DbModels())
            {
                if (dbModel.User_Tbl.Any(x=> x.Name == userModel.Name))
                {
                    ViewBag.DuplicateMessage = "Entered Name Already exists";
                    return View("AddOrEdit", userModel);
                }
                dbModel.User_Tbl.Add(userModel);
                dbModel.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful";
            return View("AddOrEdit", new User_Tbl());
        }
        public ActionResult Edit(int id)
        {
            using(DbModels dbModel = new DbModels())
            {
                return View(dbModel.User_Tbl.Where(x => x.Id == id).FirstOrDefault());
            }
        }
        [HttpPost]
        public ActionResult Edit(int id, User_Tbl user)
        {
            using(DbModels dbModel = new DbModels())
            {
                dbModel.Entry(user).State = EntityState.Modified;
                dbModel.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.User_Tbl.Where(x => x.Id == id).FirstOrDefault());
            }
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection col)
        {
            using (DbModels dbModel = new DbModels())
            {
                User_Tbl table = dbModel.User_Tbl.Where(x=>x.Id == id).FirstOrDefault();
                dbModel.User_Tbl.Remove(table);
                dbModel.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}