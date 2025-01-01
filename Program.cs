using System.ComponentModel;

namespace Assignment_02_OOP
{
    class assignment_02_OOP
    {
        // part 01
        #region 01
        ///Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

        //struct Person
        //{
        //    public string Name { get; set; }
        //    public int Age { get; set; }

        //    public Person(string name, int age)
        //    {
        //        Name = name;
        //        Age = age;
        //    }
        //}

        //static void Main()
        //{
        //    Person[] people = new Person[3];

        //    people[0] = new Person("ahmed", 25);
        //    people[1] = new Person("sarah", 30);
        //    people[2] = new Person("omar", 22);

        //    Console.WriteLine("Details of all persons:");
        //    foreach (Person p in people)
        //    {
        //        Console.WriteLine($"Name: {p.Name}, Age: {p.Age}");
        //    }


        #endregion

        #region 02

        /// Create a struct called "Point" to represent a 2D point with properties "X" and "Y". 
        /// Write a C# program that takes two points as input from the user and calculates the distance between them.

        //    struct Point
        //{
        //    public double X { get; set; }
        //    public double Y { get; set; }

        //    public Point(double x, double y)
        //    {
        //        X = x;
        //        Y = y;
        //    }
        //}

        //static double CalculateDistance(Point p1, Point p2)
        //{
        //    double dx = p2.X - p1.X;
        //    double dy = p2.Y - p1.Y;
        //    return Math.Sqrt(dx * dx + dy * dy);
        //}

        //static void Main()
        //{
        //    Console.WriteLine("Enter first point:");
        //    Console.Write("X1: ");
        //    double x1 = double.Parse(Console.ReadLine());
        //    Console.Write("Y1: ");
        //    double y1 = double.Parse(Console.ReadLine());
        //    Point point1 = new Point(x1, y1);

        //    Console.WriteLine("\nEnter second point:");
        //    Console.Write("X2: ");
        //    double x2 = double.Parse(Console.ReadLine());
        //    Console.Write("Y2: ");
        //    double y2 = double.Parse(Console.ReadLine());
        //    Point point2 = new Point(x2, y2);

        //    double distance = CalculateDistance(point1, point2);
        //    Console.WriteLine($"\nDistance between points: {distance}");
        #endregion



        #region 03
        /// Create a struct called "Person" with properties "Name" and "Age". 
        /// Write a C# program that takes details of 3 persons as input from the user and
        /// displays the name and age of the oldest person.


        //// Find the oldest person
        //Person oldest = people[0];
        //foreach (Person p in people)
        //{
        //    if (p.Age > oldest.Age)
        //    {
        //        oldest = p;
        //    }
        //}

        //Console.WriteLine($"\nThe oldest person is: {oldest.Name}, Age: {oldest.Age}");

        #endregion


        //part 02 

        #region part 02

        // Part 01: Design and implement a Class for the employees in a company.

        [Flags]
        enum SecurityLevel
        {
            Guest,        
            Developer,    
            Secretary,    
            DBA,         
            Secutity_officer
        }

        enum Gender
        {
            M,  // Male
            F   // Female
        }

        class HireDate
        {
            public int Day { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }


            public HireDate(int day, int month, int year)
            {

                if (day < 1 || day > 31 || month < 1 || month > 12)
                    throw new ArgumentException("Invalid day or month.");

                Day = day;
                Month = month;
                Year = year;

            }

            public override string ToString()
            {
                return $"{Day}/{Month}/{Year}";
            }


            class Employee
            {
                private int id;
                private string name;
                private decimal salary;

                public int ID
                {
                    get => id;
                    set => id = value > 0 ? value : throw new ArgumentException("Invalid ID");
                }

                public string Name { get; set; }


                public decimal Salary
                {
                    get => salary;
                    set => salary = value >= 0 ? value : throw new ArgumentException("Invalid salary");
                }

                public Gender Gender { get; set; }
                public SecurityLevel SecurityLevel { get; set; }
                public HireDate HireDate { get; set; }



                public Employee(int id, string name, decimal salary, Gender gender,
                               SecurityLevel securityLevel, HireDate hireDate)
                {
                    ID = id;
                    Name = name;
                    Salary = salary;
                    Gender = gender;
                    SecurityLevel = securityLevel;
                    HireDate = hireDate;
                }

                public override string ToString() =>
                    $"ID: {ID}, Name: {Name}, Salary: {Salary}, " +
                    $"Gender: {Gender}, Security: {SecurityLevel}, " +
                    $"Hired: {HireDate}";




                // part3 -Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)

                class Program
                {
                    static void Main()
                    {
                        try
                        {
                            // Create employee array
                            Employee[] employees = new Employee[3];

                            // Create DBA employee
                            employees[0] = new Employee(
                                1,
                                "omar",
                                60000,
                                Gender.M,
                                SecurityLevel.DBA,
                                new HireDate(15, 3, 2023)
                            );

                            // Create Guest employee
                            employees[1] = new Employee(
                                2,
                                "aya",
                                45000,
                                Gender.F,
                                SecurityLevel.Guest,
                                new HireDate(1, 1, 2024)
                            );

                            // Create Security Officer with all permissions
                            employees[2] = new Employee(
                                3,
                                "ahmed",
                                55000,
                                Gender.M,
                                SecurityLevel.Guest | SecurityLevel.Developer |
                                SecurityLevel.Secretary | SecurityLevel.DBA,
                                new HireDate(10, 6, 2023)
                            );




                            // part 04

                            // Sort by hire date
                            Array.Sort(employees);  // Boxing/Unboxing occurs here

                            Console.WriteLine("\nSorted by Hire Date:");
                            PrintEmployees(employees);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                    }

                    static void PrintEmployees(Employee[] employees)
                    {
                        foreach (Employee emp in employees)
                            Console.WriteLine(emp);
                    }
                }

                #endregion







            }
            }
        }
    }
    