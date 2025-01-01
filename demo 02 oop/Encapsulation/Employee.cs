using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02.Encapsulation
{
    internal struct Employee
    {
        #region Attributes
        private int Id;
        private string? name;
        private decimal salary;
        #endregion
        #region Getter&Setter
        //1-Apply encapsulation throught Getter & Setter[Old Approach]
        //Setter
        public void SetId(int id)
        {
            Id = id>1000 && id<10000?id:9999;//make date validation 
        }
        //Getter
        public int GetId() => Id;
        #endregion
        #region Properties
        ///2-Apply encapsulation through properties[New Approach][Recommended]
        public string? Name
        {
            get
            {
                return name;
            }
            set
            {
                //name = value?.Length<=10?value:value?.Substring(0,10);  
                name = validateName(value);
            }
            //.net 5 
            //init { }
        }
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = validateSalary(value);
            }
        }
        public decimal Dedection
        {
            get
            {
                return salary * .2m;
            }
        }
        //compiler will Generate Backing field private attribute
        ///int age backing field 
        private int Age { get; set; }
        #endregion
        #region Constructors
        public Employee(int Id,string? Name,decimal salary)
        {
            this.Id = Id;
            this.Name = validateName(Name);
            this.salary = validateSalary(salary);
        }
        #endregion
        #region Methods
        public override string ToString()=> $"Id:{Id}\nName:{Name}\nSalary:{salary:c}";
        private string? validateName(string? name)
        {
            return name is null ? null : name.Length <= 10 ? name : name?.Substring(0, 10);
        }
        private decimal validateSalary(decimal value)
        {
            return value >= 5000 ? value : 5000;
        }
        #endregion


    }
}
