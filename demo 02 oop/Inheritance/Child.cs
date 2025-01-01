using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02.inheritance
{
    internal class Child:Parent
    {
        #region Attribute
        public int Z { get; set; }
        #endregion
        #region Constructor
        public Child(int X, int Y, int Z) : base(X, Y)
        {
            this.Z = Z;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{base.ToString()}\nZ:{Z}";
        }
        //first way
        //public override long Product()
        //{
        //    return base.Product()*Z;
        //}
        //second way 
        public new long Product()
        {
            return base.Product() * Z;
        }
        #endregion
    }
}
