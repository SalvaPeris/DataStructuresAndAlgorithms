using _4.Dictionaries_and_Sets.Models;
using System.Collections;
using System.Runtime.InteropServices;

internal class Program
{
    /*private static void Main(string[] args)
    {
        Hashtable phoneBook = new Hashtable()
        {
            {"SalvaPeris", "000-000-000"},
            {"PepeMartinez", "111-111-111"}
        };
    }*/

    private static void Main(string[] args)
    {
        Dictionary<int, Employee> employees = new Dictionary<int, Employee>();
        employees.Add(1, new Employee() { FirstName = "Salva", LastName = "Peris", PhoneNumber = "000-111-222"});
        employees.Add(2, new Employee() { FirstName = "Pepe", LastName = "Martínez", PhoneNumber = "000-111-333" });
        
        bool isCorrect = true;

        do
        {
            Console.WriteLine("Enter the employee identifier: ");
            string idString = Console.ReadLine();
            isCorrect = int.TryParse(idString, out int id);
            if (isCorrect)
            {
                Console.ForegroundColor = ConsoleColor.White;
                if(employees.TryGetValue(id, out Employee employee))
                {
                    Console.WriteLine("First name: {1} {0} Last name: {2} {0} Phone number: {3}", Environment.NewLine, employee.FirstName, employee.LastName, employee.PhoneNumber);
                } else
                {
                    Console.WriteLine("The employee with the given identifier does not exist.");
                }
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        while (isCorrect);
    }
}