using addcategory_product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using addcategory_product.viewmodels;
namespace addcategory_product.Controllers
{
    public class AddcategorryController : Controller
    {
        category_productsEntities db = new category_productsEntities();
        public ActionResult Index()
        {
            return View(db.tbl_category.ToList());
        }

        [HttpGet]

        //Create
        public ActionResult category()
        {
            return View();
        }

        [HttpPost]
        public ActionResult category(categoryviewmodel obj)
        {

            tbl_category t = new tbl_category();
            t.cat_name = obj.cat_name;
            db.tbl_category.Add(t);
            db.SaveChanges();
            return RedirectToAction("Index");



            return View();
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {


            if (id == null)
            {

                return RedirectToAction("Index");
            }

           
            tbl_category t = db.tbl_category.Where(x => x.cat_id == id).SingleOrDefault();


            if (t == null)
            {
                return HttpNotFound();

            }

            return View(t);
        }

        [HttpPost]
        public ActionResult Edit(tbl_category std)
        {
          
            db.Entry(std).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");


            return View();
        }

        public ActionResult Delete(int? id)
        {
            if (id != null)
            {

                tbl_category cs = db.tbl_category.Find(id);
                db.tbl_category.Remove(cs);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");


            }
            return View();

        }

        public ActionResult Details(int? id)
        {

            tbl_category st = db.tbl_category.Find(id);

            return View(st);

        }
    }
}