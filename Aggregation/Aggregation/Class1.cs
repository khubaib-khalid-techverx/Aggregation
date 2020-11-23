using System;
using System.Collections.Generic;
using System.Text;

namespace Aggregation
{
    class Employee
    {
        public string name;
        public int age;
        public Address address;

        public Employee(string name, int age, Address a)
        {
            this.name = name;
            this.age = age;
            this.address = a;

        }

        public void show()
        {
            Console.WriteLine(name +" "+age+" "+address.city+" "+address.state);

        }


    }
}
