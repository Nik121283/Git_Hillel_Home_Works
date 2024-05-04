using HW2_DZ3.Creatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_DZ3.Facrories
{

    internal class UserFactory : CreatureFactory
    {
        public override int ControledAgeInput()
        {
            int result = 0;

            do
            {
                result = int.Parse(Console.ReadLine());
            }
            while (!(result > 0 && result < 100));

            return result;
        }

        public override Creature createCreature()
        {
            Console.WriteLine("\nСоздаем нового юзера\n");

            Console.WriteLine("Введите имя");
            string FirstName = ControledDataInput();

            Console.WriteLine("Введите фамилию");
            string LastName = ControledDataInput();

            Console.WriteLine("Введите возраст");
            int age = ControledAgeInput();

            
            Console.WriteLine("Выберите гендер: М - мужчина, W - женщина, НЕИЗВЕСТНО - любая другая клавиша");
            Gender gender = genderInput();

            return new User(FirstName, LastName, gender, age);
        }

    }
}
