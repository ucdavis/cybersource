using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cybersource.Helpers;

namespace Cybersource.Controllers
{
    public class OrderController : Controller
    {
        /// <summary>
        /// Get the customer info for a new order
        /// </summary>
        /// <returns></returns>
        public ActionResult CustomerInfo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Payment()
        {
            var dictionary = new Dictionary<string, string>();

            foreach (var param in Request.Form.AllKeys)
            {
                dictionary.Add(param, Request.Form[param] ?? string.Empty);
            }

            ViewBag.Signature = Security.sign(dictionary);

            return View();
        }
	}
}