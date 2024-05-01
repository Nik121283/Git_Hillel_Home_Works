using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_DZ3.Creatures
{
    internal class Pet : Creature
    {

        public string Vid_i_poroda { get; set; }

        public Pet()
        {
            //добавляет в статическое поле типа List класса Родителя  всех созданных существ
            allSpecies.Add(this);
        }

        public Pet(int age)
        {
            Age = age;

            //добавляет в статическое поле типа List класса Родителя  всех созданных существ
            allSpecies.Add(this);
        }

        public Pet(string name, string vid_i_poroda, int age, Gender gender)
        {
            FirstName = name;
            Vid_i_poroda = vid_i_poroda;
            Age = age;
            Gender = gender;

            //добавляет в статическое поле типа List класса Родителя  всех созданных существ
            allSpecies.Add(this);
        }

        public override string ToString()
        {
            return $"\n Hi, my name is: {FirstName} and i am: {Vid_i_poroda}, I am {Age} years old. I am {Gender} ";
        }

    }
}
