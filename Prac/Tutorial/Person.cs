namespace Tutorial {
    public class Person {
        public string FirstName;
        public string LastName;
        public void Introduce() {
            System.Console.WriteLine("My name is {0} {1}", FirstName, LastName);
        }
    }
}