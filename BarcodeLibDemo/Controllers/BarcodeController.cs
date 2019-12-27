using gotoconfig.BarcodeLibDemo.Models;
using System.Web.Mvc;

namespace gotoconfig.BarcodeLibDemo.Controllers
{
    public class BarcodeController : Controller
    {
        public ActionResult Index()
        {
            BarcodeModel model = new BarcodeModel();
            model.GetListBarcodeInfo();
            return View(model);
        }        
    }
}
