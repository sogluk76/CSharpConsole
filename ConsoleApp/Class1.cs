namespace ConsoleApp.Models
{

    public class User
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public int Old { get; set; }

        public double AnnualSalaryBrut { get; set; }

        public double Tax { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Id = 1;
            user.Name = "Lukas";
            user.LastName = "Gosselin";
            user.Old = 20;
            user.AnnualSalaryBrut = 6000;
            user.Tax = 0.2;

            Console.WriteLine($"Id: " +
                $"{user.Id}, " +
                $"\nName: {user.Name}, " +
                $"\nLast Name: {user.LastName}, " +
                $"\nAge: {user.Old}, " +
                $"\nAnnual Salary: {user.AnnualSalaryBrut}, " +
                $"\nTax: {user.Tax}");
        }
    }
}