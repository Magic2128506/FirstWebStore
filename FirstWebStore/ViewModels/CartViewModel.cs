using System.Collections.Generic;
using System.Linq;

namespace FirstWebStore.ViewModels
{
    public class CartViewModel
    {
        public Dictionary<ProductViewModel, int> Items { get; set; } = new Dictionary<ProductViewModel, int>();

        public int ItemsCount => Items?.Sum(i => i.Value) ?? 0;
    }
}
