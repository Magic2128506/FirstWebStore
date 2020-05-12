using System;
using System.Linq;
using FirstWebStore.Infrastructure.Interfaces;
using FirstWebStore.Infrastructure.Mapping;
using FirstWebStore.Models;
using FirstWebStore.ViewModels;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using WebStory.Domain.Entities;

namespace FirstWebStore.Infrastructure.Services.InCookies
{
    public class CookiesCartService : ICartService
    {
        private readonly string _CartName;
        private readonly IProductData _ProductData;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        private Cart Cart
        {
            get
            {
                var context = _HttpContextAccessor.HttpContext; // Извлекаем cookies
                var cookies = context.Response.Cookies;
                var cartCookies = context.Request.Cookies[_CartName];

                if (cartCookies is null)
                {
                    var cart = new Cart();
                    cookies.Append(_CartName, JsonConvert.SerializeObject(cart));
                    return cart;
                }

                ReplaceCookie(cookies, cartCookies);
                return JsonConvert.DeserializeObject<Cart>(cartCookies);
            }
            set => ReplaceCookie(_HttpContextAccessor.HttpContext.Response.Cookies, JsonConvert.SerializeObject(value));
        }

        private void ReplaceCookie(IResponseCookies cookies, string cookie)
        {
            cookies.Delete(_CartName);
            cookies.Append(_CartName,
                cookie,
                new CookieOptions
                {
                    Expires = DateTime.Now.AddDays(15)
                });
        }

        public CookiesCartService(IProductData productData, IHttpContextAccessor httpContextAccessor)
        {
            _ProductData = productData;
            _HttpContextAccessor = httpContextAccessor;

            var user = httpContextAccessor.HttpContext.User;
            var userName = user.Identity.IsAuthenticated ? user.Identity.Name : null;
            _CartName = $"cart[{userName}]";
        }

        public void AddToCart(int id)
        {
            var cart = Cart;
            var item = cart.Items.FirstOrDefault(i => i.ProductId == id);

            if (item is null)
                cart.Items.Add(new CartItem
                {
                    ProductId = id,
                    Quantity = 1
                });
            else
                item.Quantity++;

            Cart = cart;
        }

        public void DecrementFromCart(int id)
        {
            var cart = Cart;
            var item = cart.Items.FirstOrDefault(i => i.ProductId == id);

            if (item is null)
                return;

            if (item.Quantity > 0)
                item.Quantity--;

            if (item.Quantity <= 0)
                cart.Items.Remove(item);

            Cart = cart;
        }

        public void RemoveAll()
        {
            var cart = Cart;
            cart.Items.Clear();
            Cart = cart;
        }

        public void RemoveFromCart(int id)
        {
            var cart = Cart;
            var item = cart.Items.FirstOrDefault(i => i.ProductId == id);

            if (item is null)
                return;

            cart.Items.Remove(item);

            Cart = cart;
        }

        public CartViewModel TransformFromCart()
        {
            var products = _ProductData.GetProducts(new ProductFilter
            {
                Ids = Cart.Items.Select(i => i.ProductId).ToList()
            });

            var productViewModel = products.ToView();

            return new CartViewModel
            {
                Items = Cart.Items
                    .ToDictionary(
                    i => productViewModel.First(p => p.ID == i.ProductId),
                    i => i.Quantity
                    )
            };
        }
    }
}
