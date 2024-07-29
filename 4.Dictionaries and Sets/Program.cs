using _4.Dictionaries_and_Sets.Models;
using System.Collections;

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
        employees.Add(1, new Employee() { FirstName = "Pepe", LastName = "Martínez", PhoneNumber = "000-111-333" });

    }
}