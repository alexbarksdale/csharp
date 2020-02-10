using System;

namespace Tutorial2
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            const int PasswordLength = 10;
            var buffer = new char[PasswordLength];
            for (byte i = 0; i < PasswordLength; i += 1)
            {
                buffer[i] = (char) ('a' + random.Next(0, 26));
            }

            var password = new string(buffer);
            System.Console.WriteLine(password);
            // Arrays
            // ### Length
            var numbers = new [] { 3, 25, 6, 2, 3, 6, 7 };
            System.Console.WriteLine("Length: {0}", numbers.Length);

            // ### IndexOf()
            int index = Array.IndexOf(numbers, 6);
            System.Console.WriteLine("Index: {0}", index);

            // ### Clear()
            Array.Clear(numbers, 0, 2); // clear from 0 to 2
            foreach (var n in numbers)
            {
                System.Console.WriteLine(n);
            }

            // ### Copy()
            var another = new int[3];
            Array.Copy(numbers, another, 3);

            System.Console.WriteLine("Copy:");
            foreach (var n in another)
            {
                System.Console.WriteLine(n);
            }

            // Sort()
            Array.Sort(numbers);
            System.Console.WriteLine("Effect of Sort");
            foreach (var n in numbers)
            {
                System.Console.WriteLine(n);
            }

            // Reverse()
            Array.Reverse(numbers);
            System.Console.WriteLine("Effect of Reverse");
            foreach (var n in numbers)
            {
                System.Console.WriteLine(n);
            }

        }
    }
}