using System;
using Tutorial.Math;
using Tutorial.NonPrimitiveTypes;

namespace Tutorial {

    public class PersonAge {
        public int Age;
    }
    class Course {
        static void Main(string[] args) {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            var calculator = new Calculator();
            int result = calculator.Add(1, 2);
            System.Console.WriteLine(result);

            var chapter4 = new Chatper4();
            chapter4.NonPrimitive();

            int number = 1;
            Increment(number);
            System.Console.WriteLine(number);

            var person = new PersonAge() { Age = 20 };
            MakeOld(person);
            System.Console.WriteLine(person.Age);
        }

        public static void Increment(int number) {
            number += 10;
        }

        public static void MakeOld(PersonAge person) {
            person.Age += 10;
        }

    }
}