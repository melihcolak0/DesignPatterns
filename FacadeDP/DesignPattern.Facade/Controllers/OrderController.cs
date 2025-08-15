using DesignPattern.Facade.DAL;
using DesignPattern.Facade.FacadePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Facade.Controllers
{
    public class OrderController : Controller
    {
        Context context = new Context();       

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult StartOrderDetail()
        {
            return View();
        }

        [HttpPost]
        public IActionResult StartOrderDetail(int customerId, int productId, int orderId, int productCount, decimal productPrice)
        {
            OrderFacade orderFacade = new OrderFacade();

            orderFacade.CompleteOrderDetail(customerId, productId, orderId, productCount, productPrice);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult StartOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult StartOrder(int customerId)
        {
            OrderFacade orderFacade = new OrderFacade();
            orderFacade.CompleteOrder(customerId);
            return RedirectToAction("Index");
        }
    }
}
