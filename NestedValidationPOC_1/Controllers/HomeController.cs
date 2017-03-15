using NestedValidationPOC_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NestedValidationPOC_1.Controllers
{
    public class HomeController : Controller
    {
        public List<SalesOrder> orderList = new List<SalesOrder>();
        // GET: Home
        public ActionResult Index() 
        {
            orderList.Add(new SalesOrder {
                OrderNumber = 1,
                CustomerName = "Vinoth",
                Date = DateTime.Now,
                Total = 100,
                Items = new List<SalesItem> {
                    new SalesItem
                    {
                        ItemId = 1,
                        ItemName = "CPU",
                        PricePerItem = 20,
                        Qty = 2,
                        TotalPrice = 20 * 2
                    }, new SalesItem
                    {
                        ItemId = 2,
                        ItemName = "Monitor",
                        PricePerItem = 25,
                        Qty = 1,
                        TotalPrice = 25 * 1
                    }, new SalesItem
                    {
                        ItemId = 3,
                        ItemName = "Mouse",
                        PricePerItem = 5,
                        Qty = 10,
                        TotalPrice = 5 * 10
                    }
                }.ToArray()
            });
            
            return View(orderList.First());
        }
        [HttpPost]
        public ActionResult SaveValues(SalesOrder model)
        {
            if (ModelState.IsValid)
            {
                orderList.Add(model);
            }
            return View("Index", model);
        }
    }
}