using HW2_DZ3.Creatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW2_DZ3.Facrories
{
    public class PetFactory : CreatureFactory
    {

        public override int ControledAgeInput()
        {
            int result = 0;

            do
            {
                result = int.Parse(Console.ReadLine());
            }
            while (! (result > 0 & result < 40));

            return result;
        }

        public override Creature createCreature()
        {
            
            Console.WriteLine("\nСоздаем новое домашнее животное\n");

            Console.WriteLine("Введите имя домашнего животного");
            string FirstName = ControledDataInput();

            Console.WriteLine("Введите вид и породу домашнего животного");
            string Vid_i_poroda = ControledDataInput();

            Console.WriteLine("Введите возраст животного");
            int age = ControledAgeInput();

            Console.WriteLine("Выберите гендер: М - мужчина, Ж - женщина, НЕИЗВЕСТНО - любая другая клавиша");
            Gender gender = genderInput();

            return new Pet(FirstName, Vid_i_poroda, age, gender);
        }
    }
}
