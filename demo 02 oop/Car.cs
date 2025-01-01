using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    internal class Car
    {
  
		#region Attribute
		private int id;
		private string? model;
		private double speed;
        #endregion
        #region constructor 
        //If You Defined a Constructor ,Compiler Will No longer Generate Empty parameterless Constructor
        //  if no user defined constructor ,Complier will always generate Empty parameterless Constructor 
        //public Car()
        //{

        //}
        public Car(int id, string? model, double speed)
        {
            this.id = id;
            this.model = model;
            this.speed = speed;
            Console.WriteLine("constructor1");
        }
        public Car(int id, string? model):this(id,model,180)/*constructor chaining*/
        {
            //this.id = id;
            //this.model = model;
            //speed = 180;
            Console.WriteLine("constructor2");
        }
        public Car(int id):this(id, "Hyndai Verna 2010")
        {
            //this.id = id;
            //model = "Hyndai Verna 2010";
            //speed = 180;
            Console.WriteLine("constructor3");
        } 
        #endregion
        #region properties


        public int Id
		{
			get { return id; }
			set { id = value; }
		}
        public string? Model
        {
            get { return model; }
            set { model = value; }
        }
        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Id:{id}\nModel{model}\nSpeed: {speed}";
        } 
        #endregion

    }
}
