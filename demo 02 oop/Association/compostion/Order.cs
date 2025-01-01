using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02.Association.Composition
{
    internal class Order
    {
        #region property
        public int Id { get; set; }
        public required string UserEmail { get; set; }
        public decimal Subtotal { get; set; }
        public required List<OrderItem> Items { get; set; }

        #endregion
        #region Constructor
        public Order(string userEmail, List<OrderItem> items)
        {
            UserEmail = userEmail;
            Items = items;
        }
        #endregion
    }
}
