using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Checklist.Models;

namespace MyShop.Controllers;

public class ItemController : Controller
{
    public IActionResult Table()
    {
        var items = new List<Item>();
        var item1 = new Item
        {
            ItemId = 1,
            Title = "Vaske gulvet",
            Description = "Vask gulvet før klokken 21:00",
            Completed = false
        };
        var item2 = new Item
        {
            ItemId = 2,
            Title = "Re opp senga",
            Description = "Jeg må re opp sengen før jeg spiser middag",
            Completed = false
        };

        items.Add(item1);
        items.Add(item2);

        ViewBag.CurrentViewName = "List of Shop Items";
        return View(items);
    }
}