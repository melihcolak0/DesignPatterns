using DesignPattern.TemplateMethod.TemplateMethod;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.TemplateMethod.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult BasicPlan()
        {
            NetflixPlans plan = new BasicPlan();
            plan.CreatePlan();

            ViewBag.v1 = plan.PlanName;
            ViewBag.v2 = plan.PersonCountValue;
            ViewBag.v3 = plan.PlanPrice;
            ViewBag.v4 = plan.PlanContent;
            ViewBag.v5 = plan.PlanResolution;

            return View();
        }

        public IActionResult StandardPlan()
        {
            NetflixPlans plan = new StandardPlan();
            plan.CreatePlan();

            ViewBag.v1 = plan.PlanName;
            ViewBag.v2 = plan.PersonCountValue;
            ViewBag.v3 = plan.PlanPrice;
            ViewBag.v4 = plan.PlanContent;
            ViewBag.v5 = plan.PlanResolution;

            return View();
        }

        public IActionResult UltraPlan()
        {
            NetflixPlans plan = new UltraPlan();
            plan.CreatePlan();

            ViewBag.v1 = plan.PlanName;
            ViewBag.v2 = plan.PersonCountValue;
            ViewBag.v3 = plan.PlanPrice;
            ViewBag.v4 = plan.PlanContent;
            ViewBag.v5 = plan.PlanResolution;

            return View();
        }
    }
}
