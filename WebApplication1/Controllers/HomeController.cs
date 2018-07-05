using System.Web.Mvc;
using WindowsFormsApp1.TwoArguments;
using SelectListItem = System.Web.WebPages.Html.SelectListItem;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem()
                {
                    Value = "Multiply", Text ="Multiply"
                },
                new SelectListItem()
                {
                    Value = "Add", Text ="Plus"
                },
                new SelectListItem()
                {
                    Value = "Substract", Text ="Minus"
                },
                new SelectListItem()
                {
                    Value = "Divide", Text ="Divide"
                }
            };
            return View();
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

        [HttpPost]
        public ActionResult Index(double firstNumber, double secondNumber, string operation)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentFactory.createCalculate(operation);
            double result = calculator.Calculate(firstNumber, secondNumber);
            ViewBag.Result = result;
            ViewBag.Operation = new SelectListItem[]
            {
                new SelectListItem()
                {
                    Value = "Multiply", Text ="Multiply"
                },
                new SelectListItem()
                {
                    Value = "Add", Text ="Plus"
                },
                new SelectListItem()
                {
                    Value = "Substract", Text ="Minus"
                },
                new SelectListItem()
                {
                    Value = "Divide", Text ="Divide"
                }
            };
            return View();
        }
    }
}