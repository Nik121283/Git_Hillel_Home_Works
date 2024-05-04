using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_DZ3.Creatures
{
    public enum Gender
    {
        Male = 1,
        Female = 2,
        Unknown = 3
    }

    public class User : Creature
    {


        //свойства
        public string LastName { get; set; }


        //конструкторы
        public User()
        {
            //добавляет в статическое поле типа List класса Родителя  всех созданных существ
            allSpecies.Add(this);
        }

        public User(int age)
        {
            Age = age;

            //добавляет в статическое поле типа List класса Родителя  всех созданных существ
            allSpecies.Add(this);
        }

        public User(string FirstName, string LastName, Gender gender, int age)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            Gender = gender;
            Age = age;

            //добавляет в статическое поле типа List класса Родителя  всех созданных существ
            allSpecies.Add(this);
        }

        //методы
        public override string ToString()
        {
            if(this.Age > 10)
            {
                return $"\n Hi, my name is: {FirstName} and last name: {LastName},I am {Age} years old. I am {Gender} ";
            }
            else
            {
                return $"\n Hi, my name is: {FirstName} and last name: {LastName},I am BABY {Age} years old. I am {Gender} ";
            }
            
        }

    }
}
