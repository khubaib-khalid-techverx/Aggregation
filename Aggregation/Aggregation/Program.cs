using System;

namespace Aggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            Address a = new Address();
            a.city = "Lahore";
            a.state = "Pakistan";
            Employee e = new Employee("Khubaib",22,a);
            e.show();

        }
    }
}
