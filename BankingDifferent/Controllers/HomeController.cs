using BankingDifferent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankingDifferent.Controllers
{
    public class HomeController : Controller
    {
        private BankDifferentEntities _context = new BankDifferentEntities();

        [Authorize]
        public ActionResult Index()
        {
            string username = User.Identity.Name;
            ViewData["destinationAccountId"] = from a in _context.Accounts.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = a.AccountOwner + " (" + a.Balance.ToString("c") + ")",
                                                   Value = a.IDAccount.ToString()
                                               };
            Account account = _context.Accounts.First(a => a.AccountOwner == username);

            return View(account);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Transfer(int destinationAccountId, int amount)
        {
            string username = User.Identity.Name;
            Account source = _context.Accounts.First(a => a.AccountOwner == username);
            Account destination = _context.Accounts.FirstOrDefault(a => a.IDAccount == destinationAccountId);

            source.Balance -= amount;
            destination.Balance += amount;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}