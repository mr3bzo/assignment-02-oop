using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02.Association.Composition
{
    internal class OrderItem
    {
        #region properties
        public int Id { get; set; }
        public /*required */Product product { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        #endregion
        // the same requried 
        #region Constructors
        public OrderItem(Product product)
        {
            this.product = product;
        } 
        #endregion
    }
}
