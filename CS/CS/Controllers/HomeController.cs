using System;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using CS.Models;

namespace CS.Controllers {
    public partial class HomeController : Controller {
        public ActionResult Index() {
            return View("Index", new BuiltInValidationData());
        }
        [HttpPost]
        public ActionResult Index(FormCollection form) {
            bool isValid = true;
            BuiltInValidationData validationData = new BuiltInValidationData {
                Name = EditorExtension.GetValue<string>("Name", BuiltInValidationHelper.NameValidationSettings, BuiltInValidationHelper.OnNameValidation, ref isValid),
                Age = EditorExtension.GetValue<int?>("Age", BuiltInValidationHelper.AgeValidationSettings, BuiltInValidationHelper.OnAgeValidation, ref isValid),
                Email = EditorExtension.GetValue<string>("Email", BuiltInValidationHelper.EmailValidationSettings, null, ref isValid),
                ArrivalDate = EditorExtension.GetValue<DateTime>("ArrivalDate", BuiltInValidationHelper.ArrivalDateValidationSettings, null, ref isValid)
            };
            if(isValid) {
                return View("ValidationSuccessPartial");
            }
            return View();
        }
    }
}
