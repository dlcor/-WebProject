using LastWeb.ModelsFrontend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LastWeb.Controllers
{
    public class HomeController : Controller
    {
        /************************Login*******************************/
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginData loginData)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }


        /************************Registration*******************************/
        [HttpPost]
        public ActionResult Registration(RegistrationData loginData)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Login",loginData);
            }
        }


        /************************Main Page*******************************/
        public ActionResult Index()
        {
            ShopProducts shopProducts = null;

            return View(shopProducts);
        }


        /************************Open My Cart*******************************/
        public ActionResult Cart()
        {
            CartData cartData = null;

            return View(cartData);
        }

        /************************Open Set Checkout data*******************************/
        public ActionResult Checkout()
        {
            return View();
        }

        /************************Check Validation*******************************/
        [HttpPost]
        public ActionResult CheckOut(CheckOutData checkOutData)
        {
            if (ModelState.IsValid)
            {
                //если успешно передаем покупку
                //call bd, delete data from cart,add to delivery bd
                return RedirectToAction("ThanksPage", "Home");
            }
            else
            {
                return View(checkOutData);
            }
        }

        /************************Specified Product Openning*******************************/
        public ActionResult Detail(int? indexProduct)
        {
            if(indexProduct.HasValue)
            {
                ProductData productData = null;
                return View(productData);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        /************************Open Shop*******************************/
        public ActionResult Shop()
        {
            ShopProducts shopProducts = null;

            return View(shopProducts);
        }

        /************************Contact US*******************************/
        public ActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(ContactData contactData)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("ThanksPageForFeedback", "Home");
            }
            else
            {
                return View(contactData);
            }
        }



        /************************AddToCart*******************************/
        public ActionResult AddProductToCart(int? productId)
        {
            if (productId.HasValue)
            {
                int indexUser = 0;
                //Добавляем user по id наш продукт с id
                return RedirectToAction("Index", "Home");

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}