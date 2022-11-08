﻿using Microsoft.AspNetCore.Mvc;
using Oana_Oprea_lab2.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Oana_Oprea_lab2.Data;
using Oana_Oprea_lab2.Models.LibraryViewModels;


namespace Oana_Oprea_lab2.Controllers
{
    public class HomeController : Controller
    {
        private readonly LibraryContext _context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(LibraryContext context) 
        { 
            _context = context; 
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<ActionResult> Statistics()
        {
            IQueryable<OrderGroup> data =
            from order in _context.Orders
            group order by order.OrderDate into dateGroup
            select new OrderGroup()
            {
                OrderDate = dateGroup.Key,
                BookCount = dateGroup.Count()
            };
            return View(await data.AsNoTracking().ToListAsync());
        }
    }
}