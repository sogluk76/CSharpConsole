class Programm
{

    //Exercice 2

    static double Taxes(double salaire, double taxe)
    {
        return (salaire * (1 - taxe / 100));
    }




    static void Main(string[] args)
    {
        //Exercice 1

        Console.WriteLine("Exercice 1\n\n");
        int number = 10;
        string name = "Rollon Normand";
        double percentage = 10.23;
        char gender = 'M';
        bool isVerified = true;
        Console.WriteLine("Id : " + number);
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Percentage : " + percentage);
        Console.WriteLine("Gender : " + gender);
        Console.WriteLine("Verified : " + isVerified);
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Press Entry Key To Exit...");
        Console.ReadLine();
        //------------------------------------------------------

        //Exercice 2

        Console.WriteLine("Exercice 2\n\n");
        Console.Write("Salaire : ");
        double salaire = Double.Parse(Console.ReadLine());
        Console.Write("Taxe : ");
        double taxe = Double.Parse(Console.ReadLine());
        if(salaire > 50000)
        {
            Console.WriteLine("Votre salaire dépasse 50 000 euros par an. Nous vous conseillons de faire des dons pour réduire vos impôts.");
        }

        else if (salaire < 1500 * 12)
        {
            Console.WriteLine("Votre salaire mensuel brut est en dessous de 1500 euros. C'est normal pour un alternant.");
        }

        else if (salaire >= 30000 && salaire <= 40000)
        {
            Console.WriteLine("Votre salaire brut est compris entre 30 000 et 40 000 euros par an. Nous vous conseillons de venir à CESI pour une formation de +5 en développement.");
        }

        else 
        {
            Console.WriteLine("Votre salaire est dans une fourchette normale.");
        }

         
        Console.WriteLine("Salaire Brut : " + salaire + " euros\nTaxe : " + taxe + " %");
        salaire = Taxes(salaire, taxe);
        Console.WriteLine("Salaire Net : " + salaire + " euros");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("\nPress Enter Key To Exit...");
        //------------------------------------------------------

        // Exercise 3
        Console.WriteLine("Exercise 3\n");

        string[] months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        double[] salaries = new double[12];
        salaries[0] = salaire / 11;
        //for (int i = 0; i < 12; i++)
        //{
        //    Console.Write("Salary for " + months[i] + ": " + salaries);

        //} 

        Console.WriteLine("\nSalary per month:");

        for (int i = 0; i < 12; i++)
        {
            Console.WriteLine(months[i] + ": " + salaries[i] + " euros");
        }

        Console.WriteLine("---------------------------------------------\n");
        Console.WriteLine("\nPress Enter Key To Exit...");
        Console.ReadLine();
    }
}