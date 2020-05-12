using System.Collections.Generic;
using System.Linq;

namespace FirstWebStore.Models
{
    public class Cart
    {
        public List<CartItem> Items { get; set; } = new List<CartItem>();

        public int ItemsCount => Items?.Sum(i => i.Quantity) ?? 0;
    }
}
