using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02.inheritance
{
    internal class Parent
    {
        #region properties
        public int X { get; set; }
        public int Y { get; set; }
        #endregion
        #region Constructor
        //public Parent()
        //{

        //}
        public Parent(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"X:{X}\nY:{Y}";
        }
        public long Product()
        {
            return X * Y;
        }

        #endregion
    }
}
