using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
	}
}