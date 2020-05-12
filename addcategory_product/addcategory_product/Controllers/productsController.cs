using addcategory_product.Models;
using addcategory_product.viewmodels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace addcategory_product.Controllers
{
    public class productsController : Controller
    {
        category_productsEntities db = new category_productsEntities();
        // GET: products
        public ActionResult Index()
        {
            return View(db.products.ToList());
        }

        [HttpGet]
        public ActionResult addproduct()
        {

            List <tbl_category> List = db.tbl_category.ToList();
            ViewBag.list = new SelectList(List , "cat_id", "cat_name");

            return View();
        }

        [HttpPost]
        public ActionResult addproduct(productviewmodel obj , HttpPostedFileBase imgfile)
        {
            try
            {
                List<tbl_category> List = db.tbl_category.ToList();
                ViewBag.list = new SelectList(List, "cat_id", "cat_name");

                string s = uploadimgfile(imgfile);
                if (s.Equals("-1"))
                {
                    Response.Write("<script>alert('image upload failed...') <script>");
                }
                else
                {
                    product p = new product();
                    p.pro_name = obj.pro_name;
                    p.c_date = obj.c_date;
                    p.Mod_date = obj.Mod_date;
                    p.pro_description = obj.pro_description;
                    p.pro_image = s;
                    p.quanitity = obj.quanitity;
                    p.price = obj.price;
                    p.fk_tbl_category = obj.fk_tbl_category;
                    db.products.Add(p);
                    db.SaveChanges();
                    return RedirectToAction("Index");


                }

            }
            catch (Exception)
            {

                //throw;
            }
            return View();
        }


        public string uploadimgfile(HttpPostedFileBase file)
        {
            Random r = new Random();
            string path = "-1";
            int random = r.Next();
            if (file != null && file.ContentLength > 0)
            {
                string extension = Path.GetExtension(file.FileName);
                if (extension.ToLower().Equals(".jpg") || extension.ToLower().Equals(".jpeg") || extension.ToLower().Equals(".png"))
                {
                    try
                    {
                        path = Path.Combine(Server.MapPath("~/Content/images/"), random + Path.GetFileName(file.FileName));
                        file.SaveAs(path);
                        path = "~/Content/images/" + random + Path.GetFileName(file.FileName);

                    }
                    catch (Exception ex)
                    {

                        path = "-1";
                    }
                }
                else
                {
                    Response.Write("<script>alert('only png or jpeg or jpg format allow');<script>");

                }


            }

            return path;
        }



        public ActionResult Details(int? id)
        {

            product st = db.products.Find(id);

            return View(st);

        }






    }
}