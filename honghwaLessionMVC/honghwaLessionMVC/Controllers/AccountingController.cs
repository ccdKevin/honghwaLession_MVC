using honghwaLessionMVC.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace honghwaLessionMVC.Controllers
{
    public class AccountingController : Controller
    {
        
        public ActionResult ShowData()
        {
            var dataList = new List<ShowDataModel>();
            Random rd = new Random();
            string[] selectValue = { "支出", "收入" };

            for (int x = 0; x < 1000; x++) {
                int selectValueIndex = rd.Next(0, selectValue.Length);
                DateTime rdDate = DateTime.UtcNow.AddDays(rd.Next(100));
                dataList.Add(new ShowDataModel()
                {
                    ItemNo = x + 1,
                    Category = selectValue[selectValueIndex],
                    Date = rdDate,
                    Money = rd.Next(50000),
                    Remark = ""
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