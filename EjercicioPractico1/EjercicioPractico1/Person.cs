using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioPractico1
{
    public class Person
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime dateBirth { get; set; }
        public string address { get; set; }

        public Person(int personId, string name, string surname, DateTime birth, string userAddress)
        {
            id = personId;
            firstName = name;
            lastName = surname;
            dateBirth = birth;
            address = userAddress;
        }
    }
}
