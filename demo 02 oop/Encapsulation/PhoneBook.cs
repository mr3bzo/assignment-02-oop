using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02.Encapsulation
{
    internal struct PhoneBook
    {
        #region Attribute
        string[] names;
        ulong[]   numbers;
        int size;
        #endregion
        #region Property
        public int Size
        {

            get { return size; }
        }
        //Indexer 
        // is a special property
        //named always with this and can take parameter
        public long this[string name]
        {
            get
            {
                if (names is not null && names is not null && numbers is not null)
                    for (int i = 0; i < size; i++)
                        if (names[i] == name)
                            return (long)numbers[i];



                return -1;
            }
            set
            {

                if (names is not null && numbers is not null)
                    for (int i = 0; i < size; i++)
                        if (names[i] == name)
                        {
                            numbers[i] = (ulong)value;
                            return;

                        }

            }
        }
        public string this[int n]
        {
            get
            {

                return $"Position :{n} Name :{names[n]}  numbers :{numbers[n]}";
            }
           
        }
        #endregion
        #region Constructors
        public PhoneBook(int size)
        {
            this.size = size;
            names = new string[size];
            numbers=new ulong[size];
        }
        #endregion
        #region Methods
        public void AddPerson(uint pos,string name,ulong number)
        {
            if(names is not null && numbers is not null && pos<size)
            {
                names[pos] = name;
                numbers[pos] = number;
            }
        }
        public long GetNumber(string name)
        {
            if(names is not null && names is not null && numbers is not null)
                for (int i = 0; i < size; i++)
                    if (names[i] == name)
                        return (long)numbers[i];
                    
                
            
            return -1;
        }
        public void SetNumber(string name,ulong namber)
        {
            if (names is not null && numbers is not null)
                for (int i = 0; i < size; i++)
                    if (names[i] == name)
                    {
                        numbers[i] = namber;
                        return;
                    }
        }
        #endregion

    }
}
