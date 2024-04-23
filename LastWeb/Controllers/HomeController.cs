using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LastWeb.Domain.Enums;
using LastWeb.Domain.ModelsFrontend;

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
        public ActionResult Registration(RegistrationData registrationData)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(registrationData);
            }
        }


        /************************Main Page*******************************DONE*/
        public ActionResult Index()
        {
            ShopProducts shopProducts = null;

            return View(shopProducts);
        }


        /************************Open My Cart*******************************Done*/
        public ActionResult Cart()
        {
            CartData cartData = null;

            return View(cartData);
        }

        /************************Open Set Checkout data******************************DONE*/
        public ActionResult Checkout()
        {
            return View();
        }

        /************************Check Validation******************************DONE*/
        [HttpPost]
        public ActionResult CheckOut(CheckOutData checkOutData)
        {
            if (ModelState.IsValid)
            {
                //если успешно передаем покупку
                //call bd, delete data from cart,add to delivery bd
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(checkOutData);
            }
        }


        /************************Specified Product Openning******************************DONE*/
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

        /************************Open Shop******************************DONE*/
        public ActionResult Shop()
        {
            ShopProducts shopProducts = null;

            return View(shopProducts);
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