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
            bool flag = false;
            do
            {
                if (flag) { Console.WriteLine("\nВы ввели не подходящие данные. Попробуйте снова"); }

                result = int.Parse(Console.ReadLine());
                flag = true;
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

            
            Console.WriteLine("Выберите гендер: 1 - мужчина, 2 - женщина, НЕИЗВЕСТНО - 3");
            Gender gender = genderInput();

            Console.WriteLine("\n Новый юзер создан");
            return new User(FirstName, LastName, gender, age);
        }

    }
}
