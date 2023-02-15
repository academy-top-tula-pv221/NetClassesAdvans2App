using Printer = System.Console;

namespace NetClassesAdvans2App
{
    using Person = User;
    class Address
    {
        public string City { set; get; } = null!;
        public string Street { set; get; }
        public void Print() 
        {
            Printer.WriteLine($"{City} {Street}");
        }
    }
    class User
    {
        public string? Name { set; get; }
        public int Age { set; get; }
        public Address Address { set; get; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new() { Name = "Bob", Age = 32 };
            //if(user is not null)
            //    if(user.Address is not null)
            //        user.Address.Print();
            string s = user?.Address?.Street!;

            Person user1 = new();
        }
    }
}