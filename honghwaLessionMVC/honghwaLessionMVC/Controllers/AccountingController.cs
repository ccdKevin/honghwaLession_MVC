using honghwaLessionMVC.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using honghwaLessionMVC.Models;

namespace honghwaLessionMVC.Controllers
{
    public class AccountingController : Controller
    {
        private SkillTreeHomeworkEntities db = new SkillTreeHomeworkEntities();

        public ActionResult ShowData()
        {
            var dataList = new List<ShowDataViewModel>();
            var result = (from x in db.AccountBook select x).ToList();
            for (int x = 0; x < result.Count; x++)
            {
                dataList.Add(new ShowDataViewModel
                {
                    ItemNo = x + 1,
                    Category = Convert.ToString(result[x].Categoryyy) == "0" ? "收入" : "支出",
                    Money = result[x].Amounttt,
                    Date = result[x].Dateee
                });
            }
            return View(dataList);
        }

        public ActionResult KeyinView()
        {
            return View();
        }
    }
}