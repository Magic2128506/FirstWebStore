using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstWebStore.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebStore.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        public IActionResult Details() => View(_cartService.TransformFromCart());

        public IActionResult AddToCart(int id)
        {
            _cartService.AddToCart(id);

            return RedirectToAction(nameof(Details));
        }

        public IActionResult DeсrementFromCart(int id)
        {
            _cartService.DecrementFromCart(id);

            return RedirectToAction(nameof(Details));
        }

        public IActionResult RemoveFromCart(int id)
        {
            _cartService.RemoveFromCart(id);

            return RedirectToAction(nameof(Details));
        }

        public IActionResult RemoveAll()
        {
            _cartService.RemoveAll();

            return RedirectToAction(nameof(Details));
        }
    }
}