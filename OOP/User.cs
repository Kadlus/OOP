using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{

    class User
    {
        public static int Id { get; set; } = 0; //vlastnost
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public Contract Contract { get; set; }


        public User (string firstName, string lastName, DateTime dateOfBirth, bool gender, Contract contract) //konstruktor
        {
            Id++;
            FirstName = firstName;
            LastName = lastName;
            Age = (DateTime.Now - dateOfBirth).Days / 365;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Contract = contract;
        }

        public User(string firstName, string lastName, DateTime dateOfBirth, bool gender) //konstruktor
        {
            Id++;
            FirstName = firstName;
            LastName = lastName;
            Age = (DateTime.Now - dateOfBirth).Days / 365;
            DateOfBirth = dateOfBirth;
            Gender = gender;
        }

        public User ()
        {

        }
    }
}
