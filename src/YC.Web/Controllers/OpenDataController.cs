using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YC.Database;

namespace YC.Web.Controllers
{
    public class OpenDataController : Controller
    {
        public OpenDataDbContext DbContext
        {
            get
            {
                return this.db;
            }
        }
        private OpenDataDbContext db;
        public OpenDataController()
        {
            db = new OpenDataDbContext();
        }
        public IActionResult Index()
        {
            List<YC.Models.OpenData> models = db.OpenData.ToList();

            return View(models);
        }

        public IActionResult Detail(int id,string name)
        {

            var model = db.OpenData.Find(id);
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = db.OpenData.Find(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(YC.Models.OpenData model)
        {

            var upDateModel = db.OpenData.Find(model.id);
            upDateModel.主要欄位說明 = model.主要欄位說明;
            upDateModel.服務分類 = model.服務分類;
            upDateModel.資料集名稱 = model.資料集名稱;
            db.SaveChanges();
            var updated = db.OpenData.Find(model.id);
            return View(updated);
        }
    }
}