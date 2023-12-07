using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*
             
             //prázdný list
            //metoda pro naplnění listu
            users = db.GenerateUsers(5); //naplní listy daty

            db.AddUser(new User("Ivetka", "Bartošová", new DateTime(1966, 4, 8))); //přidání nového uživatele na konec listu
            //výpis uživatelů
            db.PrintUsers(users);

            Console.WriteLine("Zadejte jméno uživatele, kterého chcete smazat");
            string removeUser = Console.ReadLine();
            db.RemoveUser(removeUser);
            db.UpdateUser("Ivetka", new User("Mařena", "Bohuna", new DateTime(1966, 4, 8)));
            db.PrintUsers(users);
            */

            Database db = new Database(); //instance třidy databáze
            List<User> users = db.GetUsers(); //zavolání metody nad listem a vložení uživatelů
            //technologie LINQ, slouží pro obecné dotazování nad daty
            //příkazy můžeme použít pro pole, listy, soubory nebo s databází
            //usnadní práci programátorům, aby se nemuseli učit jazyk SQL

            //vypsat uživatele podle konkrétního jména
            //from názevproměnné in datová struktura(pole, soubor nebo list) na konci bude select názevproměnné
            //where == podmínka
            //datový typ var se používá, pokud máme např. objekty, kde jsou různé datové typym univerzální použití
            //tento datový typ var podporuje kolekce

            //tento dotaz vybere z listu všechny uživatele se jménem "Michal"

            /*
            var query = from user in users 
                        where user.FirstName == "Michal"
                        select user;
            

            

            //vypíše pouze ženy
            var query = from user in users
                        where user.Gender == true
                        select user;

            //vytvořit dotaz, kde budou uživatelé starší 30 let
            //vytvořte ještě jeden vlastní dotaz

            foreach (var user in query)
            {
                Console.WriteLine(user.FirstName);
                Console.WriteLine(user.LastName);
                Console.WriteLine(user.Age);
                Console.WriteLine(user.DateOfBirth);
                if (user.Gender) //vrátí true/false
                {
                    Console.WriteLine("Žena");
                }
                else
                {
                    Console.WriteLine("Muž");
                }
            }

            */

            db.UsersContracts();

            Console.ReadKey();

        }

    }
}
