using OOP02.Encapsulation;
using OOP02.inheritance;

namespace OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Struct
            ///stander for structure 
            ///value type 
            ///struct always use to  make data type 
            ///class can by data type or just container[static class] all method like math class
            ///size small like bool , int ,char 
            ///data access faster than class because i was stack
            ///Declare object with type point 
            /// CLR will Allocate 8 bytes in stack
            ///new with struct just choose constructor to initialize the attribute



            //Point p01;
            //p01.x = 5;
            //p01.y = 3;
            //Console.WriteLine(p01.x);
            //Console.WriteLine(p01.y);
            //p01=new Point(0,0)
            //Console.WriteLine(P01.ToString());  
            //Console.WriteLine(P01);
            #endregion
            #region Encapsulation
            ////if i want not change after this make init .net5 
            //Employee employee = new Employee(1000, "Ahmed Nasr", 10_000)
            //{
            //    Name = "Ahmed Sayed"
            //};
            ////employee.Id = 5000;//Set id through the field itself
            ////Console.WriteLine(employee.Id);//Get id throungh the field itself 
            //employee.SetId(2002);
            //Console.WriteLine(employee.GetId());
            ////employee.Name = "Nada Ahmed";
            //Console.WriteLine(employee.Name);
            #endregion
            #region Indexer
            //string Name = "Ahmed";
            //char[] Name = { 'A', 'h', 'm', 'e', 'd' }
            //PhoneBook note = new PhoneBook(10);
            //note.AddPerson(0, "Ahmed", 1111);
            //note.AddPerson(1, "Nada", 2222);
            //note.AddPerson(2, "Noura", 3333);
            //note.AddPerson(3, "Nour", 4444);
            ////note.SetNumber("Ahmed", 5555);
            ////Console.WriteLine(note.GetNumber("Ahmed"));
            //note["Ahmed"] = 7777;
            //Console.WriteLine(note["Ahmed"]);
            //for (int i = 0; i < note.Size; i++)
            //{
            //    Console.WriteLine(note[i]);
            //}
            #endregion
            #region Class 
            //Class console /math 
            // Car C1;
            //Declare for references of type car
            //this Reference 'C1' Can refer to an object of type "Car" and an object inherit from car
            //CLR Will Allocate 4 UnInitializes Bytes in Stack for the reference of c1
            //CLR Will Allocate 0 in Heap

            //C1 = new Car(1, "BMW2020", 180);
            // new 
            //1.Allocate Required Number of Bytes for allocate object in Heap=16
            //2.initialize the allocate Bytes for each and every attribute
            //3.Call User defined constructor if exist
            //4.return the address of allocated object in heap to the reference 'c1'
            //the same because address object
            //Console.WriteLine(C1);
            //Console.WriteLine(C1.ToString());
            //Car C2 = new Car(1, "BMW2020");


            #endregion
            #region inheritance [is a relationship]
           //single [pure oop]
           //if multipule can in inherite two  methods has same name
           //association Has a [aggraction,compositition]   

           //Parent parent = new Parent(1,2);
           //parent.X = 11;
           //parent.Y = 22;
           //Console.WriteLine(parent);
           //Console.WriteLine($"product= {parent.Product()}");
            //Child child = new Child(0, 0, 0);
            //child.X = 11;
            //child.Y = 22;
            //child.Z = 33;
            //Console.WriteLine(child.ToString());
            //Console.WriteLine($"product= {child.Product()}");
            #endregion


        }
    }
}
