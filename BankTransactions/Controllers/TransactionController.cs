using Microsoft.AspNetCore.Mvc;

namespace BankTransactions.Controllers
{
    public class TransactionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
