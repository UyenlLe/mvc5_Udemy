using System.Linq;
using System.Web.Mvc;
using UdemyProject.Models;

namespace UdemyProject.Controllers
{
    public class CustomerController : Controller
    {
        private MyDBContext _context;

        public CustomerController()
        {
            _context = new MyDBContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customer
        public ActionResult Index()
        {

            var customers = _context.Customers.ToList();

            return View(customers);
        }

        public ActionResult Details(int? Id)
        {
            var cus = _context.Customers.SingleOrDefault(cusId => cusId.Id == Id);

            if(cus == null)
            {
                return HttpNotFound();
            }

            return View(cus);
        }
    }
}