using System;
using System.Collections.Generic;
using System.Text;

namespace Extention
{
    interface Human
    {
        public string Gender { get; set; }
    }
    struct User:Human
    {
        public User(string name,string surname,int age,string gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }
        public string Name;
        public string Surname;
        private int Age;

        public string Gender { get; set; }
    }
}
