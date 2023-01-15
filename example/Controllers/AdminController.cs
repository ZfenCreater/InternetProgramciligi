using example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace example.Controllers
{
    public class AdminController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult yemekIndex()
        {
            return View(yemekdata.Items);
        }

        public PartialViewResult List(int id = 0)
        {
            return PartialView("List", yemekdata.Items);
        }

        public PartialViewResult InsertOrUpdate(int id = 0)
        {
            ViewBag.Yemekler = new SelectList(yemekcesitdata.Items, "id", "Ad");
            if (id != 0)
            {
                return PartialView("InsertOrUpdate", yemekdata.GetById(id));
            }
            else
            {
                return PartialView("InsertOrUpdate");
            }
        }

        [HttpPost]
        public JsonResult InsertOrUpdate(yemekler model)
        {

            if (model.id == 0)
                model.id = yemekdata.Insert(model);
            else
                yemekdata.Update(model);

            return Json(new { success = true, successMessage = "İşlem başarılı" });

        }

        public PartialViewResult Delete(int id = 0)
        {
            return PartialView("Delete", yemekdata.GetById(id));
        }

        [HttpPost, ActionName("Delete")]
        public JsonResult DeleteConfirm(int id = 0)
        {
            yemekdata.Remove(id);
            return Json(new { success = true, successMessage = "İşlem başarılı" });
        }




        //----------------------------------------------------------------------


        public ActionResult fotoIndex()
        {
            return View(fotodata.Items);
        }

        public PartialViewResult fotoList(int id = 0)
        {
            return PartialView("fotoList", fotodata.Items);
        }

        public PartialViewResult fotoInsertOrUpdate(int id = 0)
        {

            if (id != 0)
            {
                return PartialView("fotoInsertOrUpdate", fotodata.GetById(id));
            }
            else
            {
                return PartialView("fotoInsertOrUpdate");
            }
        }

        [HttpPost]
        public JsonResult fotoInsertOrUpdate(foto model)
        {

            if (model.id == 0)
                model.id = fotodata.Insert(model);
            else
                fotodata.Update(model);

            return Json(new { success = true, successMessage = "İşlem başarılı" });

        }

        public PartialViewResult fotoDelete(int id = 0)
        {
            return PartialView("fotoDelete", fotodata.GetById(id));
        }

        [HttpPost, ActionName("fotoDelete")]
        public JsonResult fotoDeleteConfirm(int id = 0)
        {
            fotodata.Remove(id);
            return Json(new { success = true, successMessage = "İşlem başarılı" });
        }

        //----------------------------------------------------------------------

        public ActionResult login()
        {

            return View();
        }

      



    }
}