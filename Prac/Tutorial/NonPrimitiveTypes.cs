using System;
namespace Tutorial.NonPrimitiveTypes {

    public enum ShippingMethod {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    public class Chatper4 {
        public void NonPrimitive() {
            // Arrays
            var numbers = new int[3] { 1, 2, 3 };
            var flags = new bool[3] { true, true, false };
            for (byte i = 0; i < 3; i += 1) {
                System.Console.WriteLine("Numbers {0}", numbers[i]);
                System.Console.WriteLine("Bool {0}", flags[i]);
            }

            // Strings
            string firstName = "Hello";
            string fullName = string.Format("My name is {0}", firstName);
            var names = new string[3] { "John", "Jack", "Alex" };
            string formattedNames = string.Join(", ", names);
            System.Console.WriteLine(formattedNames);

            string text = "Hi john Look into the following paths \n c:\\folder1\\folder2\\nc";
            System.Console.WriteLine(text);

            // Enums
            var method = ShippingMethod.Express;
            System.Console.WriteLine((int)method);

            int methodId = 3;
            System.Console.WriteLine((ShippingMethod)methodId);
            System.Console.WriteLine(method.ToString());

            string methodName = "Express";
            // #### Convert a string to an Enum
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            System.Console.WriteLine(shippingMethod);

            // References and Types
            int a = 10;
            int b = a;
            b += 1;
            System.Console.WriteLine(string.Format("a: {0} b: {1}", a, b));

            var arrayOne = new int[3] { 1, 2, 3 };
            var arrayTwo = arrayOne;
            arrayTwo[0] = 0;
            System.Console.WriteLine(string.Format("a1: {0} a2: {1}", arrayOne[0], arrayTwo[0]));

        }

    }
}