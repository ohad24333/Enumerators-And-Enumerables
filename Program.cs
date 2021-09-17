using System;

namespace Enumerators_And__Enumerables
{
    class Program
    {
        static void Main(string[] args)
        {
            //question 1

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i * 10);
            }

            //question 2

            Sidra10To100 vs = new Sidra10To100();
            foreach (var item in vs)
            {
                Console.WriteLine(item);
            }

            //question 3

            Console.WriteLine( "Enter Number:" );
            int number = int.Parse(Console.ReadLine());

            PowerNumberClaas vs1 = new PowerNumberClaas(number);

            foreach (var item in vs1)
            {
                Console.WriteLine(item);
            }

            //question 4

            StudentWhoPracticeALot studentWhoPracticeALot = new StudentWhoPracticeALot();
            studentWhoPracticeALot.students.Add(new Student("Ohad", 14));
            studentWhoPracticeALot.students.Add(new Student("Or", 9));
            studentWhoPracticeALot.students.Add(new Student("Eden", 13));
            studentWhoPracticeALot.students.Add(new Student("Yuval", 19));
            studentWhoPracticeALot.students.Add(new Student("Yula", 7));

            foreach (Student student in studentWhoPracticeALot)
            {
                Console.WriteLine($"Name: {student.Name},  Grade: {student.Grade}");
            }

        }
    }
}
