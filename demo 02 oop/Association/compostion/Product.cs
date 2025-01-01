using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02.Association.Composition
{
    internal class Product
    {
        #region properties
        public int Id { get; set; }
        public required string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsOfStock { get; set; }
        #endregion
    }
}
