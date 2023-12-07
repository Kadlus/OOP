using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{

    class Database
    {
        private List<User> userRecords = new List<User>(); //seznam uživatelů
        private List<Contract> contractRecords = new List<Contract>();
        Faker faker = new Faker("cz"); //instance třídy Faker
        public Database() //konstruktor
        {
            userRecords = MakeContract(); //naplnění daty
        }

        public List<User> GenerateUsers(int count) //metoda, která vytvoří list uživatelů, počet uživatelů jako vstupní parametr
        {
            for (int i = 0; i < count; i++)
            {
                //userRecords.Add(new User(faker.Name.FirstName(), faker.Name.LastName(), faker.Date.Past(40)));
                //v každém průchdu cyklu vložím nového uživatele
            }
            return userRecords; //vrátím plný list uživatelů
        }

        public List<User> GetUsers()
        {
            return userRecords = new List<User>()
            {
                new User("Michal", "Kmiť", new DateTime(1993, 11, 13), true),
                new User("John", "Smith", new DateTime(1990, 5, 20), false),
                new User("Anna", "Johnson", new DateTime(1985, 3, 8), true),
                new User("David", "Brown", new DateTime(1982, 7, 15), true),
                new User("Sophia", "Lee", new DateTime(1988, 9, 25), false),
                new User("Michal", "Kmiť", new DateTime(1992, 2, 10), true),
                new User("Emily", "Wilson", new DateTime(1995, 4, 16), false),
                new User("Oliver", "Davis", new DateTime(1987, 12, 30), true),
                new User("Emma", "Martinez", new DateTime(1983, 6, 5), false),
                new User("Liam", "Taylor1", new DateTime(1989, 10, 11), true),
                new User("Michal", "Kmiť", new DateTime(1991, 1, 2), true),
                new User("John", "Smith", new DateTime(1986, 8, 14), true),
                new User("Sophia", "Harris", new DateTime(1984, 2, 27), false),
                new User("Ella", "Brown", new DateTime(1994, 4, 5), false),
                new User("Benjamin", "Davis", new DateTime(1993, 10, 3), true),
                new User("Emma", "Anderson", new DateTime(1992, 5, 9), false),
                new User("Liam", "Johnson", new DateTime(1987, 6, 30), true),
                new User("Liam", "Williams", new DateTime(1990, 1, 15), true),
                new User("Sophia", "Smith", new DateTime(1985, 11, 8), false),
                new User("Oliver", "Taylor", new DateTime(1995, 7, 12), true),
                new User("Ella", "Davis", new DateTime(1988, 4, 21), false),
                new User("Emma", "Williams", new DateTime(1986, 3, 28), false),
                new User("Liam", "Martinez", new DateTime(1989, 9, 22), true),
                new User("Oliver", "Johnson", new DateTime(1991, 12, 17), true),
                new User("John", "Anderson", new DateTime(1994, 2, 8), true),
                new User("Benjamin", "Harris", new DateTime(1993, 5, 7), true),
                new User("Sophia", "Smith", new DateTime(1984, 7, 1), false),
                new User("Oliver", "Brown", new DateTime(1990, 6, 26), true),
                new User("David", "Davis", new DateTime(1987, 1, 9), true),
                new User("Ella", "Johnson", new DateTime(1989, 8, 6), false),
                new User("Anna", "Smith", new DateTime(1986, 4, 2), true),
                new User("Emma", "Lee1", new DateTime(1992, 12, 14), false),
                new User("John", "Brown", new DateTime(1995, 3, 25), true),
                new User("Liam", "Wilson", new DateTime(1991, 9, 11), true),
                new User("Sophia", "Kmiť", new DateTime(1983, 5, 16), false),
                new User("Benjamin", "Harris", new DateTime(1988, 3, 29), true),
                new User("David", "Anderson", new DateTime(1985, 6, 19), true),
                new User("Oliver", "Smith", new DateTime(1994, 8, 7), true),
                new User("Emily", "Martinez", new DateTime(1990, 7, 23), false),
                new User("Anna", "Kmiť", new DateTime(1993, 1, 6), true),
                new User("David", "Harris", new DateTime(1986, 4, 30), true),
                new User("Emily", "Wilson", new DateTime(1989, 2, 21), false),
                new User("John", "Kmiť", new DateTime(1987, 3, 28), true),
                new User("Benjamin", "Brown", new DateTime(1995, 10, 5), true),
                new User("Emma", "Smith", new DateTime(1992, 11, 14), false),
                new User("Anna", "Johnson", new DateTime(1984, 12, 31), true),
                new User("Liam", "Kmiť", new DateTime(1985, 8, 20), true),
            };
        }

        public static List<User> MakeContract()
        {
            List<User> userRecords = new List<User>()
    {
        new User("Sophie", "Mitchell", new DateTime(2000, 1, 1), false, new Contract(21, 62000, false, new DateTime(2041, 1, 1))),
        new User("William", "Ward", new DateTime(2001, 1, 1), true, new Contract(22, 63000, true, new DateTime(2042, 2, 2))),
        new User("Madison", "Hill", new DateTime(2002, 1, 1), false, new Contract(23, 64000, false, new DateTime(2043, 3, 3))),
        new User("Henry", "Sullivan", new DateTime(2003, 1, 1), true, new Contract(24, 65000, true, new DateTime(2044, 4, 4))),
        new User("Ella", "Ford", new DateTime(2004, 1, 1), false, new Contract(25, 66000, false, new DateTime(2045, 5, 5))),
        new User("Oscar", "Meyer", new DateTime(2005, 1, 1), true, new Contract(26, 67000, true, new DateTime(2046, 6, 6))),
        new User("Grace", "Simpson", new DateTime(2006, 1, 1), false, new Contract(27, 68000, false, new DateTime(2047, 7, 7))),
        new User("Luke", "Fisher", new DateTime(2007, 1, 1), true, new Contract(28, 69000, true, new DateTime(2048, 8, 8))),
        new User("Hannah", "Carter", new DateTime(2008, 1, 1), false, new Contract(29, 70000, false, new DateTime(2049, 9, 9))),
        new User("Jackson", "Reid", new DateTime(2009, 1, 1), true, new Contract(30, 71000, true, new DateTime(2050, 10, 10))),
        new User("Natalie", "Adams", new DateTime(2041, 1, 1), false, new Contract(49, 98000, false, new DateTime(2069, 11, 30))),
        new User("David", "Fleming", new DateTime(2042, 1, 1), true, new Contract(50, 99000, true, new DateTime(2070, 12, 31))),
        new User("Eva", "Wallace", new DateTime(2043, 1, 1), false, new Contract(51, 100000, false, new DateTime(2071, 1, 1))),
        new User("Isaac", "Hunter", new DateTime(2044, 1, 1), true, new Contract(52, 101000, true, new DateTime(2072, 2, 2))),
        new User("Zoe", "Gordon", new DateTime(2045, 1, 1), false, new Contract(53, 102000, false, new DateTime(2073, 3, 3))),
        new User("Mason", "Dixon", new DateTime(2046, 1, 1), true, new Contract(54, 103000, true, new DateTime(2074, 4, 4))),
        new User("Lillian", "Mills", new DateTime(2047, 1, 1), false, new Contract(55, 104000, false, new DateTime(2075, 5, 5))),
        new User("Logan", "Kane", new DateTime(2048, 1, 1), true, new Contract(56, 105000, true, new DateTime(2076, 6, 6))),
        new User("Penelope", "Rose", new DateTime(2049, 1, 1), false, new Contract(57, 106000, false, new DateTime(2077, 7, 7))),
        new User("Carter", "Stone", new DateTime(2050, 1, 1), true, new Contract(58, 107000, true, new DateTime(2078, 8, 8)))
    };

            return userRecords;
        }



        public void PrintUsers(List<User> users) //výpis uživatelů
        {
            foreach (User user in users)
            {
                Console.WriteLine("First name = " + user.FirstName);
                Console.WriteLine("Last name = " + user.LastName);
                Console.WriteLine("Age = " + user.Age);
                Console.WriteLine("Date of birth = " + user.DateOfBirth);
            }
        }
        public void AddUser(User user) //metody pro vložení nového uživatele
        {
            if (user == null) //ošetření vstupu
            {
                Console.WriteLine("Nastala chyba");
                return; //pokud dojde k chybě, tak zde skončí program
            }
            userRecords.Add(user);
        }
        public void RemoveUser(string name) //smazání uživatele podle jména
        {
            User tmpUser = userRecords.FirstOrDefault(u => u.FirstName == name); //najde prvního uživatele podle vstupního parametru metody
            if (tmpUser == null)
            {
                Console.WriteLine("Nastala chyba při mazání nebyl uživatel nebyl nalezen");
            }
            userRecords.Remove(tmpUser); //odstraní uživatele z listu
        }

        public void UpdateUser (string name, User user) //aktualizace objektu v listu
        {
            //první parametr metody vybere konkrétního uživatele, druhý parametr určí změny vlastností
            User tmpUser = userRecords.FirstOrDefault(u => u.FirstName == name);
            if (tmpUser == null) 
            {
                Console.WriteLine("Uživatel nebyl nalezen");
                return;
            }

            //aktualizace údajů
            tmpUser.FirstName = user.FirstName; 
            tmpUser.LastName = user.LastName;             
        }

        public void UsersContracts()
        {
            var query = from u in userRecords where u.Contract.Salary > 15000 
                        select new
            {
                FirstName = u.FirstName,
                LastName = u.LastName,
                Age = u.Age,
                Salary = u.Contract.Salary
            };

            foreach (var item in query)
            {
                Console.WriteLine(item.FirstName);
                Console.WriteLine(item.LastName);
                Console.WriteLine(item.Age);
                Console.WriteLine(item.Salary);
            }

        }
    }
}
